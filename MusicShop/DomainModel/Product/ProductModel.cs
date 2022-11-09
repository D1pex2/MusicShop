using System;
using System.Linq;

namespace MusicShop.DomainModel.ProductModel
{
    public class ProductModel : IProductModel
    {
        private Product product;

        public Product Product 
        {
            get
            {
                return product;
            }
            set => product = value; 
        }

        public ProductModel(Product product)
        {
            Product = product;
        }

        public void AddToCart(Product product)
        {
            if (Core.Context.Products.Find(product.IdProduct) == null)
            {
                throw new Exception("Данный товар недоступен для заказа");
            }
            Cart cartProduct = new Cart
            {
                IdProduct = Product.IdProduct,
                IdUser = Connection.CurrentUser.IdUser,
                Quantity = 1
            };
            if (Connection.CurrentUser.Role.RoleName != "Покупатель")
            {
                throw new Exception("Авторизуйтесь под учетной записью покупателя, чтобы добавлять товары в корзину");
            }
            if (Core.Context.Carts.Any(p => p.IdProduct == cartProduct.IdProduct && p.IdUser == Connection.CurrentUser.IdUser))
            {
                throw new Exception("Товар уже находится в корзине");
            }
            Core.Context.Carts.Add(cartProduct);
            Core.Context.SaveChanges();
        }

        public void Rate(decimal rating)
        {
            if (Core.Context.Comments.Any(c => c.Product.IdProduct == Product.IdProduct && c.IdUser == Connection.CurrentUser.IdUser))
            {
                var comment = Core.Context.Comments
                    .FirstOrDefault(c => c.Product.IdProduct == Product.IdProduct && c.IdUser == Connection.CurrentUser.IdUser);
                comment.Rating = rating;
            }
            else
            {
                Comment comment = new Comment
                {
                    IdProduct = Product.IdProduct,
                    IdUser = Connection.CurrentUser.IdUser,
                    Rating = rating
                };
                Core.Context.Comments.Add(comment);
            }
            Core.Context.SaveChanges();
        }
    }
}
