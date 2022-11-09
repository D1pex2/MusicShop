using MusicShop.DomainModel;
using MusicShop.DomainModel.Catalog;
using MusicShop.DomainModel.EditProduct;
using MusicShop.DomainModel.ProductModel;
using MusicShop.Presentations.Common;
using MusicShop.Presentations.Views;
using MusicShop.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MusicShop.Presentations.Presenters
{
    public class CatalogPresenter : IPresenter
    {
        private readonly ICatalogView view;

        private readonly ICatalogModel model;

        public CatalogPresenter(ICatalogView view, ICatalogModel model)
        {
            this.view = view;
            this.model = model;

            this.view.SelectCategoryEvent += View_SelectCategory;
            this.view.OpenProductEvent += View_OpenProduct;
            this.view.FilterProductEvent += View_FilterProduct;
            this.view.ResetFilterEvent += View_ResetFilter;
            this.view.NextPageEvent += View_NextPage;
            this.view.PreviousPageEvent += View_PreviousPage;
            this.view.FirstPageEvent += View_FirstPage;
            this.view.LastPageEvent += View_LastPage;
            this.view.AddProductEvent += View_AddProduct;
            this.view.EditProductEvent += View_EditProduct;
            this.view.DeleteProductEvent += View_DeleteProduct;
            this.view.SortEvent += View_Sort;
            this.view.RefreshEvent += View_Refresh;
        }

        private void View_Refresh(object sender, EventArgs e)
        {
            try
            {
                view.CategoryNodes = GetCategoryTreeNodes(model.Categories.Where(c => c.IdMainCategory == null).ToList());
                view.Manufacturers = model.GetManufacturers(model.CategoryProducts);
                UpdateView(model.Products);
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        private void View_Sort(object sender, EventArgs e)
        {
            model.SortType = view.SortType;
            UpdateView(model.Products);
        }

        private void View_DeleteProduct(object sender, EventArgs e)
        {
            try
            {
                if (view.SelectedProduct == null)
                {
                    return;
                }
                var product = view.SelectedProduct as Product;
                if (view.ConfirmAction($"Вы уверены, что хотите удалить запись о товаре {product.Name}?") == DialogResult.Yes)
                {
                    if (product.OrderProducts.Count > 0)
                    {
                        view.ShowError($"Не удалось удалить запись о товаре {product.Name}, т.к он находится в заказах.");
                        return;
                    }
                    model.DeleteProduct(product);
                    UpdateView();
                    view.ShowInfo("Запись успешно удалена.");
                }
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        private void View_EditProduct(object sender, EventArgs e)
        {
            if (view.SelectedProduct == null)
            {
                return;
            }
            new EditProductPresenter(new EditProductForm(), new EditProductModel(view.SelectedProduct as Product)).Run();
            UpdateView(model.Products);
        }

        private void View_AddProduct(object sender, EventArgs e)
        {
            new EditProductPresenter(new EditProductForm(), new EditProductModel()).Run();
            UpdateView(model.Products);
        }

        private void View_LastPage(object sender, EventArgs e)
        {
            model.CurrentPage = model.TotalPage;
            UpdateView();
        }

        private void View_FirstPage(object sender, EventArgs e)
        {
            model.CurrentPage = 1;
            UpdateView();
        }

        private void View_PreviousPage(object sender, EventArgs e)
        {
            model.CurrentPage--;
            UpdateView();
        }

        private void View_NextPage(object sender, EventArgs e)
        {
            model.CurrentPage++;
            UpdateView();
        }

        private void View_ResetFilter(object sender, EventArgs e)
        {
            UpdateView(model.CategoryProducts);
        }

        private void View_FilterProduct(object sender, EventArgs e)
        {
            UpdateView(model.GetFilteredProducts(model.CategoryProducts, view.FilterName, view.MinPrice, view.MaxPrice,
                (view.SelectedManufacturer as Manufacturer), view.IsStock));
            view.ShowInfo($"Найдено {model.ProductsPagesCount} товаров");
        }

        private void View_SelectCategory(object sender, TreeViewEventArgs e)
        {
            model.CategoryProducts = model.GetCategoryProduct(GetCurrentCategories(e.Node));
            SetPriceConstraint(model.CategoryProducts);
            view.Manufacturers = model.GetManufacturers(model.CategoryProducts);
            UpdateView(model.CategoryProducts);
        }

        private void SetPriceConstraint(List<Product> products)
        {
            if (products.Count != 0)
            {
                view.MinPrice = products.Min(p => p.Price);
                view.MaxPrice = products.Max(p => p.Price);
            }
        }

        private TreeNode[] GetCategoryTreeNodes(List<Category> categories)
        {
            List<TreeNode> nodes = new List<TreeNode>();
            foreach (var category in categories)
            {
                nodes.Add(CreateCategoryNode(category));
            }
            return nodes.ToArray();
        }

        private TreeNode CreateCategoryNode(Category category)
        {
            TreeNode categoryNode = new TreeNode(category.Name)
            {
                ToolTipText = category.Name,
                Tag = category
            };
            foreach (var subCategory in model.Categories.Where(c => c.IdMainCategory == category.IdCategory))
            {
                categoryNode.Nodes.Add(CreateCategoryNode(subCategory));
            }
            return categoryNode;
        }

        private List<Category> GetCurrentCategories(TreeNode node)
        {
            if (node.Tag == null)
            {
                return model.Categories;
            }
            List<Category> categories = new List<Category>();
            categories.Add(node.Tag as Category);
            foreach (TreeNode child in node.Nodes)
            {
                categories.AddRange(GetCurrentCategories(child));
            }
            return categories;
        }

        private void View_OpenProduct(object sender, EventArgs e)
        {
            if (view.SelectedProduct == null)
            {
                return;
            }
            new ProductPresenter(
                new ProductForm
                {
                    FormBorderStyle = FormBorderStyle.None,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                    Parent = view.Parent
                }, new ProductModel(view.SelectedProduct as Product)).Run();
            view.Hide();
        }

        private void UpdateView(List<Product> products = null)
        {
            try
            {
                if (products != null)
                {
                    model.ProductsPages = products;
                }
                view.DataSource = model.ProductsPages;
                view.PageStatus = $"Страница {model.CurrentPage} из {model.TotalPage}";
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        public void Run()
        {
            try
            {
                view.EnableEdit = Connection.CurrentUser.Role.IdRole == Core.Context.Roles.FirstOrDefault(r => r.RoleName == "Менеджер").IdRole;
                view.CategoryNodes = GetCategoryTreeNodes(model.Categories.Where(c => c.IdMainCategory == null).ToList());
                view.Manufacturers = model.GetManufacturers(model.CategoryProducts);
                SetPriceConstraint(model.Products);
                UpdateView(model.Products);
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
            view.Show();
        }
    }
}