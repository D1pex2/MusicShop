using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicShop.DomainModel.Orders
{
    public class OrdersModel : IOrdersModel
    {
        public List<OrderView> Orders { get => Core.Context.OrderViews.OrderByDescending(o => o.OrderDate).ToList(); }

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

        public int OrdersPagesCount { get => ordersPages.Count; }

        private List<OrderView> ordersPages;

        public List<OrderView> OrdersPages
        {
            get
            {
                return ordersPages.Skip((currentPage - 1) * sizePage).Take(sizePage).ToList();
            }
            set
            {
                CurrentPage = 1;
                TotalPage = (int)Math.Ceiling((decimal)value.Count / sizePage);
                ordersPages = value;
            }
        }
        
        public List<OrderView> GetFilteredOrders(List<OrderView> orders, string fullName, DateTime beginDate, DateTime endDate)
        {
            List<OrderView> filteredOrders = orders
                .Where(o => o.FullName.ToLower().Contains(fullName.ToLower()))
                .Where(o => o.OrderDate >= beginDate && o.OrderDate <= endDate).ToList();
            return filteredOrders;
        }
    }
}
