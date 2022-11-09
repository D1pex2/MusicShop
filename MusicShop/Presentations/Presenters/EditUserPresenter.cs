using MusicShop.DomainModel;
using MusicShop.DomainModel.Login;
using MusicShop.DomainModel.Users;
using MusicShop.Presentations.Common;
using MusicShop.Presentations.Views;
using MusicShop.UI;
using System;
using System.Linq;

namespace MusicShop.Presentations.Presenters
{
    public class EditUserPresenter : IPresenter
    {
        private readonly IRegistrationView view;
        private readonly IUserModel model;

        public EditUserPresenter(IRegistrationView view, IUserModel model)
        {
            this.view = view;
            this.model = model;

            this.view.RegistrationEvent += View_Registration;
        }

        private void View_Registration(object sender, EventArgs e)
        {
            try
            {
                bool newUser = model.User.IdUser == 0;
                var role = view.SelectedRole as Role;
                if (role == null || Connection.CurrentUser != Connection.Admin)
                {
                    role = Core.Context.Roles.FirstOrDefault(r => r.RoleName == "Покупатель");
                }
                model.EditUser(view.UserLogin, view.UserPassword, view.UserName, view.UserSurname, view.UserPatronymic, view.UserPhone, role);
                if (newUser)
                {
                    view.ShowInfo($"Аккаунт успешно зарегистрирован под логином {model.User.Login}.");
                }
                else
                {
                    view.ShowInfo("Изменения успешно приняты.");
                }
                view.Close();
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
                view.Roles = Core.Context.Roles.ToList();
                view.EnableSelectRole = Connection.CurrentUser == Connection.Admin;
                if (model.User.IdUser != 0)
                {
                    view.Text = model.User.Login;
                }
                view.UserLogin = model.User.Login;
                view.UserSurname = model.User.Surname;
                view.UserPassword = model.User.Password;
                view.UserName = model.User.Name;
                view.UserPhone = model.User.Phone;
                view.UserPatronymic = model.User.Patronymic;
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        public void Run()
        {
            UpdateView();
            view.ShowDialog();
        }
    }
}
