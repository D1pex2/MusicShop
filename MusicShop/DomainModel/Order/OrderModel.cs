using System;
using System.Text;

namespace MusicShop.DomainModel
{
    public class OrderModel : IOrderModel
    {
        private Order order;

        public Order Order { get => order; private set => order = value; }

        public OrderModel(Order order)
        {
            Order = order;
        }

        public void DeleteOrder()
        {
            Core.Context.OrderProducts.RemoveRange(Order.OrderProducts);
            Core.Context.Orders.Remove(Order);
            Core.Context.SaveChanges();
        }

        public void SaveOrder(string address, DateTime deliveryDate)
        {
            StringBuilder errors = new StringBuilder();
            if (String.IsNullOrWhiteSpace(address))
            {
                errors.AppendLine("Укажите адрес доставки.");
            }
            if (deliveryDate <= Order.OrderDate)
            {
                errors.AppendLine("Укажите корректную дату доставки");
            }
            if (errors.Length > 0)
            {
                throw new Exception(errors.ToString());
            }
            Order.DeliveryAddress = address;
            Order.DeliveryDate = deliveryDate;
            Core.Context.SaveChanges();
        }
    }
}
