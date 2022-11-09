namespace MusicShop.DomainModel.EditManufacturer
{
    public interface IEditManufacturerModel
    {
        Manufacturer Manufacturer { get; set; }

        void EditManufactuer(string name, string country);
    }
}
