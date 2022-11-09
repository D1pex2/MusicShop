using System;
using System.Text;

namespace MusicShop.DomainModel.EditManufacturer
{
    public class EditManufacturerModel : IEditManufacturerModel
    {
        public Manufacturer Manufacturer { get; set; }

        public EditManufacturerModel(Manufacturer manufacturer)
        {
            Manufacturer = manufacturer;
        }

        public EditManufacturerModel()
        {
            Manufacturer = new Manufacturer();
        }

        public void EditManufactuer(string name, string country)
        {
            StringBuilder errors = new StringBuilder();
            if (String.IsNullOrWhiteSpace(name))
            {
                errors.AppendLine("Пожалуйста введите название производителя.");
            }
            if(String.IsNullOrWhiteSpace(country))
            {
                errors.AppendLine("Пожалуйста введите страну производителя.");
            }
            if(errors.Length > 0)
            {
                throw new Exception(errors.ToString());
            }
            Manufacturer.Name = name;
            Manufacturer.Country = country;
            if (Manufacturer.IdManufacturer == 0)
            {
                Core.Context.Manufacturers.Add(Manufacturer);
            }
            Core.Context.SaveChanges();
        }
    }
}
