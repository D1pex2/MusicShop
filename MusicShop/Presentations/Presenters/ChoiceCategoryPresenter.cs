using MusicShop.DomainModel;
using MusicShop.Presentations.Common;
using MusicShop.Presentations.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MusicShop.Presentations.Presenters
{
    public class ChoiceCategoryPresenter : IPresenter
    { 
        private readonly IChoiceCategoryView view;

        private Category category;

        public Category Category { get => category; private set => category = value; }

        private List<Category> Categories { get => Core.Context.Categories.OrderBy(c => c.Name).ToList(); }

        public ChoiceCategoryPresenter(IChoiceCategoryView view)
        {
            this.view = view;

            this.view.CategorySelectedEvent += View_CategorySelected;
        }

        private void View_CategorySelected(object sender, EventArgs e)
        {
            Category = view.SelectedCategory.Tag as Category;
            view.Close();
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
            view.ShowDialog();
        }
    }
}
