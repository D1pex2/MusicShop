using MusicShop.Presentations.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicShop.UI
{
    public partial class EditProductForm : StyleForm, IEditProductView
    {

        public string CurrentProductName { get => nameTextBox.Text.Trim(); set => nameTextBox.Text = value; }

        public object Manufacturer { get => manufacturerComboBox.SelectedItem; set => manufacturerComboBox.DataSource = value; }

        public object ProductManufacturer { set => manufacturerComboBox.SelectedItem = value; }

        public object Category { get => categoryComboBox.SelectedItem; set => categoryComboBox.DataSource = value; }

        public object ProductCategory { set => categoryComboBox.SelectedItem = value; }

        public decimal Price { get => priceNumericUpDown.Value; set => priceNumericUpDown.Value = value; }

        public short Quantity { get => Convert.ToInt16(quantityNumericUpDown.Value); set => quantityNumericUpDown.Value = value; }

        public string Description { get => descriptionRichTextBox.Text; set => descriptionRichTextBox.Text = value; }

        public object Images { set => imagesDataGridView.DataSource = value; }

        public object SelectedImage 
        { 
            get
            {
                if(imagesDataGridView.Rows.Count > 0)
                {
                    return imagesDataGridView.SelectedRows[0].DataBoundItem;
                }
                return null;
            }
        }

        public event EventHandler SelectManufacturerEvent;

        public event EventHandler SelectCategoryEvent;

        public event EventHandler EditProductEvent;

        public event EventHandler AddImageEvent;

        public event EventHandler DeleteImageEvent;

        public event EventHandler ChoiceCategoryEvent;

        public EditProductForm()
        {
            InitializeComponent();
            imagesDataGridView.AutoGenerateColumns = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectCategoryEvent?.Invoke(sender, e);
        }

        private void ManufacturerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectManufacturerEvent?.Invoke(sender, e);
        }

        private void OkBlinkButton_Click(object sender, EventArgs e)
        {
            EditProductEvent?.Invoke(sender, e);
        }

        private void DeleteImageToolStripButton_Click(object sender, EventArgs e)
        {
            DeleteImageEvent?.Invoke(sender, e);
        }

        private void AddImageToolStripButton_Click(object sender, EventArgs e)
        {
            AddImageEvent?.Invoke(sender, e);
        }

        private void ChoiceCateogoryButton_Click(object sender, EventArgs e)
        {
            ChoiceCategoryEvent?.Invoke(sender, e);
        }
    }
}
