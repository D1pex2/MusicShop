using MusicShop.DomainModel;
using MusicShop.DomainModel.Users;
using MusicShop.Presentations.Common;
using MusicShop.Presentations.Views;
using MusicShop.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicShop.Presentations.Presenters
{
    public class UsersPresenter : IPresenter
    {
        private readonly IUsersView view;

        public UsersPresenter(IUsersView view)
        {
            this.view = view;

            this.view.AddEvent += View_Add;
            this.view.EditEvent += View_Edit;
            this.view.DeleteEvent += View_Delete;
            this.view.FilterEvent += View_Filter;
        }

        private void View_Filter(object sender, EventArgs e)
        {
            FilterUsers();
        }

        private void View_Delete(object sender, EventArgs e)
        {
            var user = view.SelectedUser as User;
            if (user == null)
            {
                return;
            }
            if (view.ConfirmAction($"Вы уверены, что хотите удалить пользователя под логином {user.Login}?") == DialogResult.Yes)
            {
                try
                {
                    Core.Context.Comments.RemoveRange(user.Comments);
                    Core.Context.Carts.RemoveRange(user.Carts);
                    Core.Context.Orders.RemoveRange(user.Orders);
                    Core.Context.Users.Remove(user);
                    Core.Context.SaveChanges();
                    FilterUsers();
                    view.ShowInfo($"Пользователь под логином {user.Login} успешно удален.");
                }
                catch (Exception ex)
                {
                    view.ShowError(ex.Message);
                }
            }
        }

        private void View_Edit(object sender, EventArgs e)
        {
            if (view.SelectedUser as User == null)
            {
                return;
            }
            new EditUserPresenter(new EditUserForm(), new UserModel(view.SelectedUser as User)).Run();
            FilterUsers();
        }

        private void View_Add(object sender, EventArgs e)
        {
            new EditUserPresenter(new EditUserForm(), new UserModel()).Run();
            FilterUsers();
        }

        public void FilterUsers()
        {
            try
            {
                var users = Core.Context.Users.Where(u => u.Login.Contains(view.Login));
                var role = view.SelectedRole as Role;
                if (role != null && role.IdRole != -1)
                {
                    users = users.Where(u => u.Role.IdRole == role.IdRole);
                }
                view.UsersSource = users.ToList();
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        private void UpdateView()
        {
            try
            {
                var roles = Core.Context.Roles.ToList();
                roles.Insert(0, new Role { IdRole = -1, RoleName = "Все роли" });
                view.Roles = roles;
                view.UsersSource = Core.Context.Users.ToList();
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        public void Run()
        {
            UpdateView();
            view.Show();
        }
    }
}