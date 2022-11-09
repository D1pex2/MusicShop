using MusicShop.Presentations.Common;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace MusicShop.Presentations.Views
{
    public interface IEditProductView : IView
    {
        string CurrentProductName { get; set; }

        object Manufacturer { get; set; }

        object ProductManufacturer { set; }

        object Category { get; set; }

        object ProductCategory { set; }

        decimal Price { get; set; }

        short Quantity { get; set; }

        string Description { get; set; }

        object SelectedImage { get; }

        object Images { set; }

        event EventHandler SelectManufacturerEvent;

        event EventHandler SelectCategoryEvent;

        event EventHandler EditProductEvent;

        event EventHandler AddImageEvent;

        event EventHandler DeleteImageEvent;

        event EventHandler ChoiceCategoryEvent;
    }
}
