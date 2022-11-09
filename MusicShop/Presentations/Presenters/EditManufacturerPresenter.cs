using MusicShop.DomainModel;
using MusicShop.DomainModel.EditManufacturer;
using MusicShop.Presentations.Common;
using MusicShop.Presentations.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Presentations.Presenters
{
    public class EditManufacturerPresenter : IPresenter
    {
        private readonly IEditManufacturerView view;

        private readonly IEditManufacturerModel model;

        public EditManufacturerPresenter(IEditManufacturerView view, IEditManufacturerModel model)
        {
            this.view = view;
            this.model = model;

            this.view.EditManufacturerEvent += View_EditManufacturer;
        }

        private void View_EditManufacturer(object sender, EventArgs e)
        {
            try
            {
                model.EditManufactuer(view.ManufacturerName, view.Country);
                view.ShowInfo($"Производитель {model.Manufacturer.Name} успешно записан.");
                view.Close();
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        private void UpdateView()
        {
            if (model.Manufacturer.IdManufacturer != 0)
            {
                try
                {
                    view.ManufacturerName = model.Manufacturer.Name;
                    view.Country = model.Manufacturer.Country;
                }
                catch (Exception ex)
                {
                    view.ShowError(ex.Message);
                }
            }
        }

        public void Run()
        {
            UpdateView();
            view.ShowDialog();
        }
    }
}
