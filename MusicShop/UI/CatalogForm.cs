using MusicShop.Presentations.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicShop.UI
{
    public partial class CatalogForm : StyleForm, ICatalogView
    {
        public bool EnableEdit 
        { 
            set
            {
                addProductToolStripButton.Visible = editPageToolStripButton.Visible = deleteProductToolStripButton.Visible = value;
            }
        }
        
        public string SortType { get => sortComboBox.SelectedItem.ToString(); }
        
        public object Manufacturers { set => manufacturerComboBox.DataSource = value; }

        public object SelectedManufacturer { get => manufacturerComboBox.SelectedItem; }

        public object DataSource { set => catalogDataGridView.DataSource = value; }

        public decimal MinPrice { get => minPriceNumericUpDown.Value; set => minPriceNumericUpDown.Value = minPriceNumericUpDown.Minimum = maxPriceNumericUpDown.Minimum = value; }

        public decimal MaxPrice { get => maxPriceNumericUpDown.Value; set => maxPriceNumericUpDown.Value = minPriceNumericUpDown.Maximum = maxPriceNumericUpDown.Maximum = value; }

        public bool IsStock { get => isStockCheckBox.Checked; }

        public string FilterName 
        { 
            get
            {
                if (String.IsNullOrWhiteSpace(productNameTextBox.Text))
                {
                    return String.Empty;
                }
                return productNameTextBox.Text;
            }
        }

        public object SelectedProduct 
        {
            get
            {
                if (catalogDataGridView.Rows.Count > 0)
                {
                    return catalogDataGridView.SelectedRows[0].DataBoundItem;
                }
                return null;
            }
        }

        public string PageStatus { set => pageToolStripLabel.Text = value; }

        public TreeNode[] CategoryNodes 
        { 
            set
            {
                categoryTreeView.Nodes.Clear();
                categoryTreeView.Nodes.Add("Все товары");
                categoryTreeView.Nodes.AddRange(value);
            }
        }

        public event EventHandler OpenProductEvent;

        public event TreeViewEventHandler SelectCategoryEvent;

        public event EventHandler FilterProductEvent;

        public event EventHandler ResetFilterEvent;

        public event EventHandler NextPageEvent;

        public event EventHandler PreviousPageEvent;

        public event EventHandler FirstPageEvent;

        public event EventHandler LastPageEvent;

        public event EventHandler AddProductEvent;

        public event EventHandler EditProductEvent;

        public event EventHandler DeleteProductEvent;

        public event EventHandler SortEvent;

        public event EventHandler RefreshEvent;

        public CatalogForm()
        {
            InitializeComponent();
            catalogDataGridView.AutoGenerateColumns = false;
            sortComboBox.SelectedIndex = 0;
        }

        private void CatalogPictureBox_Click(object sender, EventArgs e)
        {
            var mirrorImage = catalogPictureBox.Image;
            mirrorImage.RotateFlip(RotateFlipType.Rotate180FlipY);
            catalogPictureBox.Image = mirrorImage;
            if (splitContainer.Panel1Collapsed)
            {
                splitContainer.Panel1Collapsed = false;
            }
            else
            {
                splitContainer.Panel1Collapsed = true;
            }
        }

        private void CategoryTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SelectCategoryEvent?.Invoke(sender, e);
        }

        private void NextPageToolStripSplitButton_ButtonClick(object sender, EventArgs e)
        {
            NextPageEvent?.Invoke(sender, e);
        }

        private void PreviousPageToolStripSplitButton_ButtonClick(object sender, EventArgs e)
        {
            PreviousPageEvent?.Invoke(sender, e);
        }

        private void FilterBlinkButton_Click(object sender, EventArgs e)
        {
            FilterProductEvent?.Invoke(sender, e);

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetFilterEvent?.Invoke(sender, e);
        }

        private void OpenProductBlinkButton_Click(object sender, EventArgs e)
        {
            OpenProductEvent?.Invoke(sender, e);
        }

        private void FirstPageToolStripButton_Click(object sender, EventArgs e)
        {
            FirstPageEvent?.Invoke(sender, e);
        }

        private void LastPageToolStripButton_Click(object sender, EventArgs e)
        {
            LastPageEvent?.Invoke(sender, e);
        }

        private void AddProductToolStripButton_Click(object sender, EventArgs e)
        {
            AddProductEvent?.Invoke(sender, e);
        }

        private void EditPageToolStripButton_Click(object sender, EventArgs e)
        {
            EditProductEvent?.Invoke(sender, e);
        }

        private void DeleteProductToolStripButton_Click(object sender, EventArgs e)
        {
            DeleteProductEvent?.Invoke(sender, e);
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortEvent?.Invoke(sender, e);
        }

        private void RefreshToolStripButton_Click(object sender, EventArgs e)
        {
            RefreshEvent?.Invoke(sender, e);
        }
    }
}