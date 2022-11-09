using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicShop.DomainModel.EditProduct
{
    public class EditProductModel : IEditProductModel
    {

        public Product Product { get; set; }

        public List<Manufacturer> Manufacturers
        {
            get
            {
                var manufacturers = Core.Context.Manufacturers.OrderBy(m => m.Name).ToList();
                manufacturers.Insert(manufacturers.Count, new Manufacturer() { IdManufacturer = -1, Name = "Добавить производителя" });
                return manufacturers;
            }
        }

        public List<Category> Categories 
        {
            get
            {
                var categories = Core.Context.Categories.OrderBy(c => c.Name).ToList();
                categories.Insert(categories.Count, new Category() { IdCategory = -1, Name = "Добавить категорию" });
                return categories;
            }
        }

        public EditProductModel()
        {
            Product = new Product();
        }

        public EditProductModel(Product product)
        {
            Product = product;
        }

        public void EditProduct(string name, decimal price, short quantity, int idManufacturer, int idCategory, string description)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Пожалуйста введите название продукта.");
            }
            if (Core.Context.Manufacturers.Find(idManufacturer) == null)
            {
                throw new Exception("Пожалуйста введите корректного производителя.");
            }
            if (Core.Context.Categories.Find(idCategory) == null)
            {
                throw new Exception("Пожалуйста введите корректную категорию.");
            }
            Product.Name = name;
            Product.Price = price;
            Product.Quantity = quantity;
            Product.IdManufacturer = idManufacturer;
            Product.IdCategory = idCategory;
            if (String.IsNullOrWhiteSpace(description))
            {
                Product.Description = null;
            }
            else
            {
                Product.Description = description;
            }
            if (Product.IdProduct == 0)
            {
                Core.Context.Products.Add(Product);
            }
            Core.Context.SaveChanges();
        }
    }
}
