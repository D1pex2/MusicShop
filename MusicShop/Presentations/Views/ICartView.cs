using MusicShop.Presentations.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicShop.Presentations.Views
{
    public interface ICartView : IView
    {
        object DataSource { set; }

        decimal Cost { set; }

        string DeliveryAddress { get; }

        DateTime DeliveryDate { get; }

        int SelectedProductId { get; }

        event EventHandler AddOrderEvent;

        event EventHandler RemoveProductEvent;

        event EventHandler IncreaseQuantityEvent;

        event EventHandler DecreaseQuantityEvent;

        event EventHandler OpenProductEvent;
    }
}
