using MusicShop.DomainModel;
using MusicShop.DomainModel.EditCategory;
using MusicShop.Presentations.Common;
using MusicShop.Presentations.Views;
using MusicShop.UI;
using System;
using System.Linq;

namespace MusicShop.Presentations.Presenters
{
    public class EditCategoryPresenter : IPresenter
    {
        private readonly IEditCategoryView view;

        private readonly IEditCategoryModel model;

        public EditCategoryPresenter(IEditCategoryView view, IEditCategoryModel model)
        {
            this.view = view;
            this.model = model;

            this.view.EditCategoryEvent += View_EditCategory;
            this.view.ChoiceCategoryEvent += View_ChoiceCategory;
        }

        private void View_ChoiceCategory(object sender, EventArgs e)
        {
            ChoiceCategoryPresenter choiceCategoryPresenter = new ChoiceCategoryPresenter(new ChoiceCategoryForm());
            choiceCategoryPresenter.Run();
            if (choiceCategoryPresenter.Category != null)
            {
                view.CurrentMainCategory = choiceCategoryPresenter.Category;
            }
        }

        private void View_EditCategory(object sender, EventArgs e)
        {
            try
            {
                int? idMainCategory = (view.MainCategory as Category).IdCategory;
                if (idMainCategory == -1)
                {
                    idMainCategory = null;
                }
                model.EditCategory(view.CategoryName, idMainCategory);
                view.ShowInfo($"Категория {model.Category.Name} успешно записана.");
                view.Close();
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        private void UpdateView()
        {
            try
            {
                view.MainCategory = model.Categories;
                view.CurrentMainCategory = null;
                if (model.Category.IdCategory != 0)
                {
                    view.CategoryName = model.Category.Name;
                    view.CurrentMainCategory = Core.Context.Categories.FirstOrDefault(c => c.IdCategory == model.Category.IdMainCategory);
                }
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        public void Run()
        {
            UpdateView();
            view.ShowDialog();
        }
    }
}
