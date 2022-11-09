using MusicShop.Presentations.Views;
using System;

namespace MusicShop.UI
{
    public partial class OrdersForm : StyleForm, IOrdersView
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

        public string FullName { get => fullNameTextBox.Text; }

        public DateTime BeginDate { get => beginDateTimePicker.Value; }

        public DateTime EndDate { get => endDateTimePicker.Value; }

        public string PageStatus { set => pageToolStripLabel.Text = value; }

        public event EventHandler FilterEvent;

        public event EventHandler NextPageEvent;

        public event EventHandler PreviousPageEvent;

        public event EventHandler FirstPageEvent;

        public event EventHandler LastPageEvent;

        public event EventHandler ResetEvent;

        public event EventHandler OpenOrderEvent;

        public OrdersForm()
        {
            InitializeComponent();
            ordersDataGridView.AutoGenerateColumns = false;
            endDateTimePicker.Value = DateTime.Now.AddMonths(3);
            beginDateTimePicker.Value = DateTime.Now;
        }

        private void FilterBlinkButton_Click(object sender, EventArgs e)
        {
            FilterEvent?.Invoke(sender, e);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetEvent?.Invoke(sender, e);
        }

        private void OpenProductBlinkButton_Click(object sender, EventArgs e)
        {
            OpenOrderEvent?.Invoke(sender, e);
        }

        private void FirstPageToolStripButton_Click(object sender, EventArgs e)
        {
            FirstPageEvent?.Invoke(sender, e);
        }

        private void PreviousPageToolStripButton_Click(object sender, EventArgs e)
        {
            PreviousPageEvent?.Invoke(sender, e);
        }

        private void NextPageToolStripButton_Click(object sender, EventArgs e)
        {
            NextPageEvent?.Invoke(sender, e);
        }

        private void LastPageToolStripButton_Click(object sender, EventArgs e)
        {
            LastPageEvent?.Invoke(sender, e);
        }
    }
}
