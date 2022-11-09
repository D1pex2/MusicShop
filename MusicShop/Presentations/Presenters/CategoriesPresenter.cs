using MusicShop.DomainModel;
using MusicShop.DomainModel.EditCategory;
using MusicShop.Presentations.Common;
using MusicShop.Presentations.Views;
using MusicShop.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicShop.Presentations.Presenters
{
    public class CategoriesPresenter : IPresenter
    {
        private readonly ICategoriesView view;

        private List<Category> Categories { get => Core.Context.Categories.OrderBy(c => c.Name).ToList(); }

        public CategoriesPresenter(ICategoriesView view)
        {
            this.view = view;

            this.view.EditCategoryEvent += View_EditCategory;
            this.view.DeleteCategoryEvent += View_DeleteCategory;
            this.view.AddCategoryEvent += View_AddCategory;
        }

        private void View_AddCategory(object sender, EventArgs e)
        {
            new EditCategoryPresenter(new EditCategoryForm(), new EditCategoryModel()).Run();
            UpdateView();
        }

        private void View_DeleteCategory(object sender, EventArgs e)
        {
            if (view.SelectedCategory == null)
            {
                return;
            }
            if (view.ConfirmAction("Вы уверены, что хотите удалить категорию?") == DialogResult.Yes)
            {
                try
                {
                    if (GetCurrentCategories(view.SelectedCategory).SelectMany(c => c.Products).Count() > 0)
                    {
                        view.ShowError("Удаление отменено, чтобы удалить категории удалите у нее все товары.");
                        return;
                    }
                    Core.Context.Categories.RemoveRange(GetCurrentCategories(view.SelectedCategory));
                    Core.Context.SaveChanges();
                    view.ShowInfo("Категория успешно удалена");
                    UpdateView();
                }
                catch (Exception ex)
                {
                    view.ShowError(ex.Message);
                }
            }
        }

        private void View_EditCategory(object sender, EventArgs e)
        {
            if (view.SelectedCategory == null)
            {
                return;
            }
            new EditCategoryPresenter(new EditCategoryForm(), new EditCategoryModel(view.SelectedCategory.Tag as Category)).Run();
            UpdateView();
        }

        private TreeNode[] GetCategoryTreeNodes(List<Category> categories)
        {
            List<TreeNode> nodes = new List<TreeNode>();
            foreach (var category in categories)
            {
                nodes.Add(CreateCategoryNode(category));
            }
            return nodes.ToArray();
        }

        private TreeNode CreateCategoryNode(Category category)
        {
            TreeNode categoryNode = new TreeNode(category.Name)
            {
                ToolTipText = category.Name,
                Tag = category
            };
            foreach (var subCategory in Categories.Where(c => c.IdMainCategory == category.IdCategory))
            {
                categoryNode.Nodes.Add(CreateCategoryNode(subCategory));
            }
            return categoryNode;
        }

        private List<Category> GetCurrentCategories(TreeNode node)
        {
            List<Category> categories = new List<Category>();
            categories.Add(node.Tag as Category);
            foreach (TreeNode child in node.Nodes)
            {
                categories.AddRange(GetCurrentCategories(child));
            }
            return categories;
        }

        private void UpdateView()
        {
            try
            {
                view.CategoryNodes = GetCategoryTreeNodes(Categories.Where(c => c.IdMainCategory == null).ToList());
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        public void Run()
        {
            UpdateView();
            view.Show();
        }
    }
}
