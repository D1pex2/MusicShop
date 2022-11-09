using MusicShop.DomainModel;
using MusicShop.DomainModel.EditManufacturer;
using MusicShop.Presentations.Common;
using MusicShop.Presentations.Views;
using MusicShop.UI;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MusicShop.Presentations.Presenters
{
    public class ManufacturersPresenter : IPresenter
    {
        private readonly IManufacturerView view;

        public ManufacturersPresenter(IManufacturerView view)
        {
            this.view = view;

            this.view.AddManufacturerEvent += View_AddManufacturer;
            this.view.RemoveManufacturerEvent += View_RemoveManufacturer;
            this.view.EditManufacturerEvent += View_EditManufacturer;
            this.view.NameSearchEvent += View_NameSearch;
        }

        private void View_NameSearch(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void View_EditManufacturer(object sender, EventArgs e)
        {
            var manufacturer = view.SelectedManufacturer as Manufacturer;
            if (manufacturer == null) return;
            new EditManufacturerPresenter(new EditManufacturerForm(), new EditManufacturerModel(manufacturer)).Run();
            UpdateView();
        }

        private void View_RemoveManufacturer(object sender, EventArgs e)
        {
            var manufacturer = view.SelectedManufacturer as Manufacturer;
            if (manufacturer == null) return;
            if (view.ConfirmAction("Вы уверены, что хотите удалить запись?") == DialogResult.Yes)
            {
                if (manufacturer.Products.Count > 0)
                {
                    view.ShowError("Удаление отменено, чтобы удалить запись удалите все товары этого производителя.");
                }
                else
                {
                    try
                    {
                        Core.Context.Manufacturers.Remove(manufacturer);
                        Core.Context.SaveChanges();
                        view.ShowInfo("Запись успешно удалена.");
                        UpdateView();
                    }
                    catch (Exception ex)
                    {
                        view.ShowError(ex.Message);
                    }
                }
            }
        }

        private void View_AddManufacturer(object sender, EventArgs e)
        {
            new EditManufacturerPresenter(new EditManufacturerForm(), new EditManufacturerModel()).Run();
            UpdateView();
        }

        private void UpdateView()
        {
            try
            {
                view.ManufacturersSource = Core.Context.Manufacturers.Where(m => m.Name.Contains(view.ManufacturerName)).ToList();
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        public void Run()
        {
            UpdateView();
            view.Show();
        }
    }
}