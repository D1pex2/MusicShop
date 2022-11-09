using MusicShop.Presentations.Common;
using System;

namespace MusicShop.Presentations.Views
{
    public interface ICustomerOrdersView : IView
    {
        object OrdersSource { set; }

        object SelectedOrder { get; }

        object ProductsSource { set; }

        object SelectedProduct { get; }

        event EventHandler SelectOrderEvent;

        event EventHandler OpenProductEvent;
    }
}