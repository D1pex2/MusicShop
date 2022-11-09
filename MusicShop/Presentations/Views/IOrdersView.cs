using MusicShop.Presentations.Common;
using System;

namespace MusicShop.Presentations.Views
{
    public interface IOrdersView : IView
    {
        object OrdersSource { set; }

        object SelectedOrder { get; }

        string FullName { get; }

        string PageStatus { set; }

        DateTime BeginDate { get; }

        DateTime EndDate { get; }

        event EventHandler FilterEvent;

        event EventHandler ResetEvent;

        event EventHandler OpenOrderEvent;

        event EventHandler NextPageEvent;

        event EventHandler PreviousPageEvent;

        event EventHandler FirstPageEvent;

        event EventHandler LastPageEvent;

    }
}
