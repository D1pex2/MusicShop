using MusicShop.Presentations.Views;
using System;
using System.Windows.Forms;

namespace MusicShop.UI
{
    public partial class ChoiceCategoryForm : StyleForm, IChoiceCategoryView
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

        public event EventHandler CategorySelectedEvent;

        public ChoiceCategoryForm()
        {
            InitializeComponent();
        }

        private void OkBlinkButton_Click(object sender, EventArgs e)
        {
            CategorySelectedEvent?.Invoke(sender, e);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
