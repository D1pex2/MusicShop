using MusicShop.Presentations.Common;
using System;

namespace MusicShop.Presentations.Views
{
    public interface IOrderView : IView
    {
        object OrderProducts { set; }

        string FullName { set; }

        string Phone { set; }

        string Address { get; set; }

        DateTime OrderDate { set; }

        DateTime DeliveryDate { get; set; }

        event EventHandler ChangeOrderEvent;

        event EventHandler DeleteOrderEvent;

        event EventHandler SaveOrderEvent;
    }
}
