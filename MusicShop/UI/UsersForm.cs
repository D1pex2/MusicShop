using MusicShop.DomainModel;
using MusicShop.Presentations.Views;
using System;

namespace MusicShop.UI
{
    public partial class UsersForm : StyleForm, IUsersView
    {
        public object UsersSource { set => usersDataGridView.DataSource = value; }

        public object SelectedUser
        {
            get
            {
                if (usersDataGridView.SelectedRows.Count > 0)
                {
                    return usersDataGridView.SelectedRows[0].DataBoundItem;
                }
                return null;
            }
        }

        public object Roles { set => rolesComboBox.DataSource = value; }

        public object SelectedRole { get => rolesComboBox.SelectedItem; set => rolesComboBox.SelectedItem = value; }

        public string Login { get => loginTextBox.Text; }

        public event EventHandler FilterEvent;

        public event EventHandler AddEvent;

        public event EventHandler EditEvent;

        public event EventHandler DeleteEvent;

        public UsersForm()
        {
            InitializeComponent();
            usersDataGridView.AutoGenerateColumns = false;
        }

        private void AddBlinkButton_Click(object sender, EventArgs e)
        {
            AddEvent?.Invoke(sender, e);
        }

        private void EditBlinkButton_Click(object sender, EventArgs e)
        {
            EditEvent?.Invoke(sender, e);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteEvent?.Invoke(sender, e);
        }

        private void RolesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterEvent?.Invoke(sender, e);
        }

        private void ManufacturerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterEvent?.Invoke(sender, e);
        }
    }
}
