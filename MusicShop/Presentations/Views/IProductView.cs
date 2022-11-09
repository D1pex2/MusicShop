using MusicShop.Presentations.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MusicShop.Presentations.Views
{
    public interface IProductView : IView
    {
        string Category { set; }

        string CurrentProductName { set; }

        decimal AvgRating { set; }

        int Quantity { set; }

        string Description { set; }

        decimal Price { set; }

        decimal SelectedRating { get; set; }

        bool EnableRate { set; }

        List<Image> Images { set; }

        event EventHandler AddToCartEvent;

        event EventHandler RateEvent;
    }
}
