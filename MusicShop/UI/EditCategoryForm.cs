using MusicShop.Presentations.Views;
using System;

namespace MusicShop.UI
{
    public partial class EditCategoryForm : StyleForm, IEditCategoryView
    {
        public string CategoryName { get => nameTextBox.Text.Trim(); set => nameTextBox.Text = value; }

        public object MainCategory { get => categoryComboBox.SelectedItem; set => categoryComboBox.DataSource = value; }

        public object CurrentMainCategory 
        { 
            set
            {
                if (value == null)
                {
                    categoryComboBox.SelectedIndex = 0;
                    return;
                }
                categoryComboBox.SelectedItem = value;
            }
        }

        public event EventHandler EditCategoryEvent;

        public event EventHandler ChoiceCategoryEvent;

        public EditCategoryForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkBlinkButton_Click(object sender, EventArgs e)
        {
            EditCategoryEvent?.Invoke(sender, e);
        }

        private void ChoiceCateogoryButton_Click(object sender, EventArgs e)
        {
            ChoiceCategoryEvent?.Invoke(sender, e);
        }
    }
}
