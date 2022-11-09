using MusicShop.Presentations.Views;
using System;

namespace MusicShop.UI
{
    public partial class OrderForm : StyleForm, IOrderView
    {
        public object OrderProducts { set => productsDataGridView.DataSource = value; }

        public string FullName { set => fullNameLabel.Text = value; }

        public string Phone { set => phoneLabel.Text = value; }

        public string Address { get => deliveryAddressRichTextBox.Text; set => deliveryAddressRichTextBox.Text = value; }

        public DateTime OrderDate { set => orderDateLabel.Text = value.ToShortDateString(); }

        public DateTime DeliveryDate { get => deliveryDateTimePicker.Value; set => deliveryDateTimePicker.Value = value; }

        public event EventHandler ChangeOrderEvent;

        public event EventHandler DeleteOrderEvent;

        public event EventHandler SaveOrderEvent;

        public OrderForm()
        {
            InitializeComponent();
            productsDataGridView.AutoGenerateColumns = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteOrderEvent?.Invoke(sender, e);
        }

        private void OkBlinkButton_Click(object sender, EventArgs e)
        {
            ChangeOrderEvent?.Invoke(sender, e);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetDocButton_Click(object sender, EventArgs e)
        {
            SaveOrderEvent?.Invoke(sender, e);
        }
    }
}
