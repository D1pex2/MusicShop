using MusicShop.DomainModel;
using MusicShop.DomainModel.EditCategory;
using MusicShop.DomainModel.EditManufacturer;
using MusicShop.DomainModel.EditProduct;
using MusicShop.Presentations.Common;
using MusicShop.Presentations.Views;
using MusicShop.UI;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MusicShop.Presentations.Presenters
{
    public class EditProductPresenter : IPresenter
    {

        private readonly IEditProductView view;

        private readonly IEditProductModel model;

        public EditProductPresenter(IEditProductView view, IEditProductModel model)
        {
            this.view = view;
            this.model = model;

            this.view.SelectCategoryEvent += View_SelectCategory;
            this.view.SelectManufacturerEvent += View_SelectManufacturer;
            this.view.EditProductEvent += View_EditProduct;
            this.view.AddImageEvent += View_AddImage;
            this.view.DeleteImageEvent += View_DeleteImage;
            this.view.ChoiceCategoryEvent += View_ChoiceCategory;
        }

        private void View_ChoiceCategory(object sender, EventArgs e)
        {
            ChoiceCategoryPresenter choiceCategoryPresenter = new ChoiceCategoryPresenter(new ChoiceCategoryForm());
            choiceCategoryPresenter.Run();
            if (choiceCategoryPresenter.Category != null)
            {
                view.ProductCategory = choiceCategoryPresenter.Category;
            }
        }

        private void View_DeleteImage(object sender, EventArgs e)
        {
            if (view.SelectedImage == null)
            {
                return;
            }
            if (view.ConfirmAction("Вы точно хотите удалить изображение?") == DialogResult.Yes)
            {
                try
                {
                    if (Core.Context.Products.FirstOrDefault(p => p.IdProduct == model.Product.IdProduct) != null)
                    {
                        Core.Context.ProductImages.Remove(view.SelectedImage as ProductImage);
                    }
                    else
                    {
                        model.Product.ProductImages.Remove(view.SelectedImage as ProductImage);
                    }
                    Core.Context.SaveChanges();
                    UpdateImages();
                }
                catch (Exception ex)
                {
                    view.ShowError(ex.Message);
                }
            }
        }

        private byte[] GetPhoto(string filePath)
        {
            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            byte[] photo = reader.ReadBytes((int)stream.Length);
            reader.Close();
            stream.Close();
            return photo;
        }

        private void View_AddImage(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    Multiselect = true,
                    Filter = "Images|*.jpg;*.jpeg;*.png"
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var photoPath in openFileDialog.FileNames)
                    {
                        model.Product.ProductImages.Add(
                            new ProductImage()
                            {
                                Image = GetPhoto(photoPath)
                            }
                        );
                    }
                    Core.Context.SaveChanges();
                    UpdateImages();
                }
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        private void View_EditProduct(object sender, EventArgs e)
        {
            try
            {
                model.EditProduct(view.CurrentProductName, view.Price, view.Quantity, 
                    (view.Manufacturer as Manufacturer).IdManufacturer, (view.Category as Category).IdCategory, view.Description);
                view.ShowInfo($"Товар {model.Product.Name} успешно записан.");
                view.Close();
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        private void View_SelectManufacturer(object sender, EventArgs e)
        {
            if((view.Manufacturer as Manufacturer).IdManufacturer == -1)
            {
                new EditManufacturerPresenter(new EditManufacturerForm(), new EditManufacturerModel()).Run();
                view.Manufacturer = model.Manufacturers;
            }
        }

        private void View_SelectCategory(object sender, EventArgs e)
        {
            if ((view.Category as Category).IdCategory == -1)
            {
                new EditCategoryPresenter(new EditCategoryForm(), new EditCategoryModel()).Run();
                view.Category = model.Categories;
            }
        }

        private void UpdateImages()
        {
            view.Images = model.Product.ProductImages.ToList();
        }

        private void UpdateView()
        {
            try
            {
                view.Manufacturer = model.Manufacturers;
                view.Category = model.Categories;
                if (model.Product.IdProduct != 0)
                {
                    view.Text = $"Редактирование {model.Product.Name}";
                    view.CurrentProductName = model.Product.Name;
                    if (!String.IsNullOrWhiteSpace(view.Description))
                    {
                        view.Description = model.Product.Description;
                    }
                    view.Price = model.Product.Price;
                    view.Quantity = model.Product.Quantity;
                    view.ProductManufacturer = model.Product.Manufacturer;
                    view.ProductCategory = model.Product.Category;
                    UpdateImages();
                }
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        public void Run()
        {
            UpdateView();
            view.ShowDialog();
        }
    }
}
