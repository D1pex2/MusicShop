using System;

namespace MusicShop.DomainModel
{
    public interface IOrderModel
    {
        Order Order { get; }

        void DeleteOrder();

        void SaveOrder(string address, DateTime deliveryDate);
    }
}
