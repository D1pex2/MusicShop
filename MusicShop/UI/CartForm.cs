using MusicShop.Presentations.Views;
using System;
using System.Windows.Forms;

namespace MusicShop.UI
{
    public partial class CartForm : StyleForm, ICartView 
    {
        public object DataSource { set => cartDataGridView.DataSource = value; }

        public decimal Cost { set => costLabel.Text = $"Стоимость: {value} р."; }

        public string DeliveryAddress { get => deliveryAddressRichTextBox.Text; }

        public DateTime DeliveryDate { get => deliveryDateTimePicker.Value; }

        public int SelectedProductId { get => Convert.ToInt32(cartDataGridView.Rows[cartDataGridView.SelectedCells[0].RowIndex].Cells[idProductColumn.Index].Value); }
        
        public event EventHandler AddOrderEvent;

        public event EventHandler RemoveProductEvent;

        public event EventHandler IncreaseQuantityEvent;

        public event EventHandler DecreaseQuantityEvent;

        public event EventHandler OpenProductEvent;

        public CartForm()
        {
            InitializeComponent();
            cartDataGridView.AutoGenerateColumns = false;
            deliveryDateTimePicker.Value = deliveryDateTimePicker.MinDate = DateTime.Now.AddDays(1);
            deliveryDateTimePicker.MaxDate = DateTime.Now.AddMonths(3);
        }

        private void AddOrderBlinkButton_Click(object sender, EventArgs e)
        {
            AddOrderEvent?.Invoke(sender, e);
        }

        private void CartDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] == removeColumn && e.RowIndex >= 0)
            {
                RemoveProductEvent?.Invoke(sender, e);
            }
            if (senderGrid.Columns[e.ColumnIndex] == increaseQuantityColumn && e.RowIndex >= 0)
            {
                IncreaseQuantityEvent?.Invoke(sender, e);
            }
            if (senderGrid.Columns[e.ColumnIndex] == decreaseQuantityColumn && e.RowIndex >= 0)
            {
                DecreaseQuantityEvent?.Invoke(sender, e);
            }
        }

        private void CartDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenProductEvent?.Invoke(sender, e);
        }
    }
}
