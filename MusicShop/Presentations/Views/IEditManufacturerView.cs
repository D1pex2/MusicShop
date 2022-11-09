using MusicShop.Presentations.Common;
using System;

namespace MusicShop.Presentations.Views
{
    public interface IEditManufacturerView : IView
    {
        string ManufacturerName { get; set; }

        string Country { get; set; }

        event EventHandler EditManufacturerEvent;
    }
}
