using MusicShop.DomainModel;
using MusicShop.Presentations.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicShop.Presentations.Views
{
    public interface ICatalogView : IView
    {
        TreeNode[] CategoryNodes { set; }

        bool EnableEdit { set; }

        object SelectedManufacturer { get; }

        object Manufacturers { set; }

        object SelectedProduct { get; }

        object DataSource { set; }

        decimal MinPrice { get; set; }

        decimal MaxPrice { get; set; }

        bool IsStock { get; }

        string FilterName { get; }

        string PageStatus { set; }

        string SortType { get; }

        event EventHandler OpenProductEvent;

        event TreeViewEventHandler SelectCategoryEvent;

        event EventHandler FilterProductEvent;

        event EventHandler ResetFilterEvent;

        event EventHandler NextPageEvent;

        event EventHandler PreviousPageEvent;

        event EventHandler FirstPageEvent;

        event EventHandler LastPageEvent;

        event EventHandler AddProductEvent;

        event EventHandler EditProductEvent;

        event EventHandler DeleteProductEvent;

        event EventHandler SortEvent;

        event EventHandler RefreshEvent;
    }
}
