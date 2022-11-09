using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicShop.DomainModel.CartModel
{
    public class CartModel : ICartModel
    {
        public List<Cart> CartProducts
        {
            get
            {
                return Core.Context.Carts.Where(c => c.IdUser == Connection.CurrentUser.IdUser).ToList();
            }
        }

        public decimal Cost { get => CartProducts.Sum(c => c.Product.Price * c.Quantity); }

        public void RemoveProduct(Cart cartProduct)
        {
            Core.Context.Carts.Remove(cartProduct);
            Core.Context.SaveChanges();
        }

        public void ReloadProducts(IEnumerable<Product> products)
        {
            foreach (var product in products)
            {
                if (Core.Context.Products.Find(product.IdProduct) != null)
                {
                    Core.Context.Entry(product).Reload();
                }
            }
        }

        public void AddOrder(Order order)
        {
            ReloadProducts(CartProducts.Select(c => c.Product));
            if (Core.Context.Carts.Where(p => p.IdUser == Connection.CurrentUser.IdUser).Count() < 1)
            {
                throw new Exception("Добавьте товар в корзину для оформления заказа");
            }
            if (Core.Context.Carts.Any(p => p.Product.Quantity < p.Quantity && p.IdUser == Connection.CurrentUser.IdUser))
            {
                throw new Exception("В наличии недостаточно товара для оформления заказа");
            }
            if (String.IsNullOrWhiteSpace(order.DeliveryAddress))
            {
                throw new Exception("Пожалуйста укажите адрес доставки");
            }
            Core.Context.CreateOrderFromCart(order.IdUser, order.DeliveryDate, order.DeliveryAddress);
            ReloadProducts(CartProducts.Select(c => c.Product));
            Core.Context.Carts.RemoveRange(Core.Context.Carts.Where(c => c.IdUser == Connection.CurrentUser.IdUser));
            Core.Context.SaveChanges();
        }

        public void ChangeCartQuantity(Cart cartProduct, short quantity)
        {
            if (cartProduct != null)
            {
                cartProduct.Quantity = quantity;
                if (Core.Context.ChangeTracker.HasChanges())
                {
                    Core.Context.SaveChanges();
                }
            }
        }
    }
}
