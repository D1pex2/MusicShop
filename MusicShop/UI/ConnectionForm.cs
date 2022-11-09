using MusicShop.Presentations.Views;
using System;

namespace MusicShop.UI
{
    public partial class ConnectionForm : StyleForm, IConnectionView
    {
        public string Server { get => serverTextBox.Text; set => serverTextBox.Text = value; }

        public string Database { get => databaseTextBox.Text; set => databaseTextBox.Text = value; }

        public string Username { get => usernameTextBox.Text; set => usernameTextBox.Text = value; }

        public string Password { get => passwordTextBox.Text; set => passwordTextBox.Text = value; }

        public event EventHandler EditConnectionStringEvent;

        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkBlinkButton_Click(object sender, EventArgs e)
        {
            EditConnectionStringEvent?.Invoke(sender, e);
        }
    }
}
