using MusicShop.Presentations.Views;
using System;
using System.Windows.Forms;

namespace MusicShop.UI
{
    public partial class CustomerOrdersForm : StyleForm, ICustomerOrdersView
    {
        public object OrdersSource { set => ordersDataGridView.DataSource = value; }

        public object SelectedOrder 
        {
            get
            {
                if (ordersDataGridView.SelectedRows.Count > 0)
                {
                    return ordersDataGridView.SelectedRows[0].DataBoundItem;
                }
                return null;
            }
        }

        public object ProductsSource { set => productsDataGridView.DataSource = value; }

        public object SelectedProduct 
        { 
            get
            {
                if (productsDataGridView.SelectedRows.Count > 0)
                {
                    return productsDataGridView.SelectedRows[0].DataBoundItem;
                }
                return null;
            }
        }

        public event EventHandler SelectOrderEvent;

        public event EventHandler OpenProductEvent;

        public CustomerOrdersForm()
        {
            InitializeComponent();
            ordersDataGridView.AutoGenerateColumns = false;
            productsDataGridView.AutoGenerateColumns = false;
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            SelectOrderEvent?.Invoke(sender, e);
        }

        private void ProductsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenProductEvent?.Invoke(sender, e);
        }
    }
}
