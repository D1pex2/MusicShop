using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicShop.DomainModel.Catalog
{
    public class CatalogModel : ICatalogModel
    {
        /// <summary>
        /// Тип сортировки
        /// </summary>
        public string SortType { get; set; }

        /// <summary>
        /// Товары из БД, отсортированные в зависимости от свойства SortType
        /// </summary>
        public List<Product> Products 
        {
            get
            {
                switch (SortType)
                {
                    case "По рейтингу":
                        return Core.Context.Products.OrderByDescending(p => p.Comments.Average(c => c.Rating)).ToList();
                    case "Сначала дешевые":
                        return Core.Context.Products.OrderBy(p => p.Price).ToList();
                    case "Сначала дорогие":
                        return Core.Context.Products.OrderByDescending(p => p.Price).ToList();
                    default:
                        return Core.Context.Products.ToList();
                }
            }
        }

        public List<Category> Categories 
        {
            get
            {
                return Core.Context.Categories.OrderBy(c => c.Name).ToList();
            }
        }


        private List<Product> categoryProducts;

        public List<Product> CategoryProducts { get => categoryProducts ?? Products; set => categoryProducts = value; }

        private int currentPage = 1;

        public int CurrentPage
        {
            get => currentPage;
            set
            {
                if (value > 0 && value <= TotalPage)
                {
                    currentPage = value;
                }
            }
        }

        private const int sizePage = 20;

        private int totalPage = 1;

        public int TotalPage { get => totalPage; private set => totalPage = value < 1 ? 1 : value; }

        public int ProductsPagesCount { get => productsPages.Count; }

        private List<Product> productsPages;

        public List<Product> ProductsPages
        {
            get
            {
                return productsPages.Skip((currentPage - 1) * sizePage).Take(sizePage).ToList();
            }
            set
            {
                CurrentPage = 1;
                TotalPage = (int)Math.Ceiling((decimal)value.Count / sizePage);
                productsPages = value;
            }
        }

        public List<Product> GetCategoryProduct(List<Category> categories)
        {
            var products = new List<Product>();
            foreach (var category in categories)
            {
                products.AddRange(Products.Where(p => p.IdCategory == category.IdCategory));
            }
            return products;
        }

        public void DeleteProduct(Product product)
        {
            Core.Context.ProductImages.RemoveRange(product.ProductImages);
            Core.Context.Products.Remove(product);
            productsPages.Remove(product);
            Core.Context.SaveChanges();
        }

        public List<Manufacturer> GetManufacturers(List<Product> products)
        {
            var manufacturers = products.Select(p => p.Manufacturer).Distinct().OrderBy(m => m.Name).ToList();
            manufacturers.Insert(0, new Manufacturer() { IdManufacturer = -1 ,Name = "Все производители" });
            return manufacturers;
        }

        /// <summary>
        /// Фильтрует список товаров по параметрам
        /// </summary>
        /// <param name="products">Список для фильрации</param>
        /// <param name="name">Наименование для поиска совпадений в списке товаров</param>
        /// <param name="minPrice">Минимальная цена товара</param>
        /// <param name="maxPrice">Максимальная цена товара</param>
        /// <param name="manufacturer">Производитель товаров</param>
        /// <param name="isStock">Фильтровать ли товары только в наличии</param>
        /// <returns>Отфильтрованный список товаров</returns>
        public List<Product> GetFilteredProducts(List<Product> products, string name, decimal minPrice, decimal maxPrice, Manufacturer manufacturer, bool isStock)
        {
            var filteredProducts = products;
            filteredProducts = filteredProducts
                .Where(p => p.Name.ToLower().Contains(name.ToLower()))
                .Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
            filteredProducts = manufacturer.IdManufacturer == -1 ? filteredProducts : filteredProducts.Where(p => p.Manufacturer == manufacturer).ToList();
            filteredProducts = isStock ? filteredProducts.Where(p => p.Quantity > 0).ToList() : filteredProducts;
            return filteredProducts;
        }
    }
}
