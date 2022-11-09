using MusicShop.Presentations.Common;
using System;

namespace MusicShop.Presentations.Views
{
    public interface IEditCategoryView : IView
    {
        string CategoryName { get; set; }

        object MainCategory { get; set; }

        object CurrentMainCategory { set; }

        event EventHandler EditCategoryEvent;

        event EventHandler ChoiceCategoryEvent;
    }
}
