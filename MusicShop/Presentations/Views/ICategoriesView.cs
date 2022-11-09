using MusicShop.Presentations.Common;
using System;
using System.Windows.Forms;

namespace MusicShop.Presentations.Views
{
    public interface ICategoriesView : IView
    {
        TreeNode[] CategoryNodes { set; }

        TreeNode SelectedCategory { get; }

        event EventHandler DeleteCategoryEvent;

        event EventHandler EditCategoryEvent;

        event EventHandler AddCategoryEvent;
    }
}
