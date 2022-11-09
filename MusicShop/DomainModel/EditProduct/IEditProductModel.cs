using System.Collections.Generic;

namespace MusicShop.DomainModel.EditProduct
{
    public interface IEditProductModel
    {
        Product Product { get; set; }

        List<Manufacturer> Manufacturers { get; }

        List<Category> Categories { get; }

        void EditProduct(string name, decimal price, short quantity, int idManufacturer, int idCategory, string description);
    }
}
