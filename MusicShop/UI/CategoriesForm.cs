using MusicShop.Presentations.Views;
using System;
using System.Windows.Forms;

namespace MusicShop.UI
{
    public partial class CategoriesForm : StyleForm, ICategoriesView
    {
        public TreeNode[] CategoryNodes
        {
            set
            {
                categoryTreeView.Nodes.Clear();
                categoryTreeView.Nodes.AddRange(value);
                categoryTreeView.ExpandAll();
            }
        }

        public TreeNode SelectedCategory { get => categoryTreeView.SelectedNode; }

        public event EventHandler DeleteCategoryEvent;

        public event EventHandler EditCategoryEvent;

        public event EventHandler AddCategoryEvent;

        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void AddBlinkButton_Click(object sender, EventArgs e)
        {
            AddCategoryEvent?.Invoke(sender, e);
        }

        private void EditBlinkButton_Click(object sender, EventArgs e)
        {
            EditCategoryEvent?.Invoke(sender, e);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteCategoryEvent?.Invoke(sender, e);
        }
    }
}
