using System.Collections.Generic;

namespace MusicShop.DomainModel.Catalog
{
    public interface ICatalogModel
    {
        int CurrentPage { get; set; }

        string SortType { get; set; }

        int TotalPage { get; }

        int ProductsPagesCount { get; }

        List<Product> ProductsPages { get; set; }

        List<Product> Products { get; }

        List<Category> Categories { get; }

        List<Product> CategoryProducts { get; set; }

        List<Product> GetCategoryProduct(List<Category> categories);

        List<Manufacturer> GetManufacturers(List<Product> products);

        List<Product> GetFilteredProducts(List<Product> products, string name, decimal minPrice, decimal maxPrice, Manufacturer manufacturer, bool isStock);

        void DeleteProduct(Product product);
    }
}
