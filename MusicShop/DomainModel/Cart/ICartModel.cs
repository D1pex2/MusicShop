using System.Collections.Generic;

namespace MusicShop.DomainModel.CartModel
{
    public interface ICartModel
    {
        List<Cart> CartProducts { get; }

        decimal Cost { get; }

        void RemoveProduct(Cart cartProduct);

        void AddOrder(Order order);

        void ChangeCartQuantity(Cart cartProduct, short quantity);
    }
}
