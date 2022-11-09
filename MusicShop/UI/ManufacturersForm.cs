using MusicShop.Presentations.Views;
using System;

namespace MusicShop.UI
{
    public partial class ManufacturersForm : StyleForm, IManufacturerView
    {
        public object ManufacturersSource { set => manufacturersDataGridView.DataSource = value; }

        public string ManufacturerName 
        {
            get
            {
                if (String.IsNullOrWhiteSpace(manufacturerNameTextBox.Text))
                {
                    return String.Empty;
                }
                return manufacturerNameTextBox.Text;
            }
        }

        public object SelectedManufacturer
        {
            get
            {
                if (manufacturersDataGridView.SelectedRows.Count > 0)
                {
                    return manufacturersDataGridView.SelectedRows[0].DataBoundItem;
                }
                return null;
            }
        }

        public event EventHandler AddManufacturerEvent;
        
        public event EventHandler RemoveManufacturerEvent;

        public event EventHandler EditManufacturerEvent;

        public event EventHandler NameSearchEvent;

        public ManufacturersForm()
        {
            InitializeComponent();
            manufacturersDataGridView.AutoGenerateColumns = false;
        }

        private void AddBlinkButton_Click(object sender, EventArgs e)
        {
            AddManufacturerEvent?.Invoke(sender, e);
        }

        private void EditBlinkButton_Click(object sender, EventArgs e)
        {
            EditManufacturerEvent?.Invoke(sender, e);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            RemoveManufacturerEvent?.Invoke(sender, e);
        }

        private void manufacturerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            NameSearchEvent?.Invoke(sender, e);
        }
    }
}
