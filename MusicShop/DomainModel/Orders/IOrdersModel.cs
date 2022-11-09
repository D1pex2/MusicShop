using System;
using System.Collections.Generic;

namespace MusicShop.DomainModel.Orders
{
    public interface IOrdersModel
    {
        int CurrentPage { get; set; }

        int TotalPage { get; }

        int OrdersPagesCount { get; }

        List<OrderView> OrdersPages { get; set; }

        List<OrderView> Orders { get; }

        List<OrderView> GetFilteredOrders(List<OrderView> orders, string fullName, DateTime beginDate, DateTime endDate);
    }
}
