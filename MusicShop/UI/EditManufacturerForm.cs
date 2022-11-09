using MusicShop.Presentations.Views;
using System;

namespace MusicShop.UI
{
    public partial class EditManufacturerForm : StyleForm, IEditManufacturerView
    {
        public string ManufacturerName { get => nameTextBox.Text.Trim(); set => nameTextBox.Text = value; }

        public string Country { get => countryTextBox.Text.Trim(); set => countryTextBox.Text = value; }

        public event EventHandler EditManufacturerEvent;

        public EditManufacturerForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkBlinkButton_Click(object sender, EventArgs e)
        {
            EditManufacturerEvent?.Invoke(sender, e);
        }
    }
}
