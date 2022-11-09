using MusicShop.Presentations.Views;
using System;

namespace MusicShop.UI
{
    public partial class EditUserForm : StyleForm, IRegistrationView
    {

        public EditUserForm()
        {
            InitializeComponent();
        }

        public object Roles { set => rolesComboBox.DataSource = value; }

        public object SelectedRole { get => rolesComboBox.SelectedItem; set => rolesComboBox.SelectedItem = value;}

        public bool EnableSelectRole { set => rolesComboBox.Visible = value; }

        public string UserName { get => nameTextBox.Text.Trim(); set => nameTextBox.Text = value; }

        public string UserSurname { get => surnameTextBox.Text.Trim(); set => surnameTextBox.Text = value; }

        public string UserPatronymic { get => patronymicTextBox.Text.Trim(); set => patronymicTextBox.Text = value; }

        public string UserPhone { get => phoneTextBox.Text; set => phoneTextBox.Text = value; }

        public string UserLogin { get => loginTextBox.Text.Trim().ToLower(); set => loginTextBox.Text = value;  }

        public string UserPassword 
        { 
            get => passwordTextBox.Text;
            set
            {
                passwordTextBox.Text = value;
                confirmPasswordTextBox.Text = value;
            }
        }

        public event EventHandler RegistrationEvent;

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
            confirmPasswordTextBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
        }

        private void RegistrationBlinkButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == confirmPasswordTextBox.Text)
            {
                RegistrationEvent?.Invoke(sender, e);
            }
            else
            {
                ShowError("Пароли не совпадают.");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}