using MusicShop.Presentations.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MusicShop.UI
{
    public partial class ProductForm : StyleForm, IProductView
    {
        public string Category { set => categoryLabel.Text = value; }

        public string CurrentProductName { set => productNameLabel.Text = value; }

        public decimal AvgRating { set => avgRatingLabel.Text = $"Оценка {value}/10"; }

        public decimal SelectedRating 
        { 
            get => Convert.ToDecimal(ratingComboBox.SelectedItem);
            set => ratingComboBox.SelectedIndex = (int)(value - 1);
        }

        public bool EnableRate { set => ratingLabel.Visible = ratingComboBox.Visible = value; }

        public string Description { set => descriptionRichTextBox.Text = value; }

        public decimal Price { set => priceLabel.Text = $"{value} р."; }

        public int Quantity 
        { 
            set
            {
                if (value < 1)
                {
                    inStockLabel.ForeColor = Color.Red;
                    inStockLabel.Text = "Нет в наличии";
                    return;
                }
                inStockLabel.Text = $"В наличии {value} шт.";
                inStockLabel.ForeColor = Color.FromArgb(128, 255, 128);
            }
        }
        
        public List<Image> Images
        {
            set
            {
                if (value == null)
                {
                    splitContainer.Panel2Collapsed = true;
                }
                else if (value.Count == 1)
                {
                    imagesSplitContainer.Panel1Collapsed = true;
                    selectedPictureBox.Image = value.Last();
                }
                else
                {
                    selectedPictureBox.Image = value.Last();
                    foreach (var img in value)
                    {
                        imagesDataGridView.Rows.Add(img);
                    }
                }
            }
        }

        public event EventHandler AddToCartEvent;

        public event EventHandler RateEvent;

        public ProductForm()
        {
            InitializeComponent();
        }

        private void ImagesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedPictureBox.Image = imagesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as Image;
        }

        private void AddToCartBlinkButton_Click(object sender, EventArgs e)
        {
            AddToCartEvent?.Invoke(sender, e);
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            Manager.ShowParentInTabPage(Parent as TabPage);
            Close();
        }

        private void RatingComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            RateEvent?.Invoke(sender, e);
        }
    }
}
