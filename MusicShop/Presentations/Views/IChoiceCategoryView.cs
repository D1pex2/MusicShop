using MusicShop.Presentations.Common;
using System;
using System.Windows.Forms;

namespace MusicShop.Presentations.Views
{
    public interface IChoiceCategoryView : IView
    {
        TreeNode[] CategoryNodes { set; }

        TreeNode SelectedCategory { get; }

        event EventHandler CategorySelectedEvent;
    }
}
