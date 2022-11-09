using MusicShop.Presentations.Views;
using System;
using System.Windows.Forms;

namespace MusicShop.UI
{
    public partial class LoginForm : StyleForm, ILoginView
    {
        public string Username { get => loginTextBox.Text; }
        public string Password { get => passwordTextBox.Text; }

        public event EventHandler LoginEvent;

        public event EventHandler RegistrationEvent;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
        }

        private void RegistrationLabel_Click(object sender, EventArgs e)
        {
            RegistrationEvent?.Invoke(sender, e);
        }

        private void LoginBlinkButton_Click(object sender, EventArgs e)
        {
            LoginEvent?.Invoke(sender, e);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}