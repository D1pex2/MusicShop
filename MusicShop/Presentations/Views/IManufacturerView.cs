using MusicShop.Presentations.Common;
using System;

namespace MusicShop.Presentations.Views
{
    public interface IManufacturerView : IView
    {
        object ManufacturersSource { set; }

        object SelectedManufacturer { get; }

        string ManufacturerName { get; }

        event EventHandler AddManufacturerEvent;

        event EventHandler RemoveManufacturerEvent;

        event EventHandler EditManufacturerEvent;

        event EventHandler NameSearchEvent;
    }
}
