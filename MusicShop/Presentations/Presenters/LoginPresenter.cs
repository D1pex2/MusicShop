using MusicShop.DomainModel;
using MusicShop.DomainModel.Login;
using MusicShop.DomainModel.Users;
using MusicShop.Presentations.Common;
using MusicShop.Presentations.Views;
using MusicShop.UI;
using System;
using System.Windows.Forms;

namespace MusicShop.Presentations.Presenters
{
    public class LoginPresenter : IPresenter
    {
        private readonly ILoginView view;
        private readonly ILoginModel model;

        public LoginPresenter(ILoginView view, ILoginModel model)
        {
            this.view = view;
            this.model = model;

            this.view.LoginEvent += View_Login;
            this.view.RegistrationEvent += View_Registration;
        }

        private void View_Registration(object sender, EventArgs e)
        {
            new EditUserPresenter(new EditUserForm(), new UserModel()).Run();
        }

        private void View_Login(object sender, EventArgs e)
        {
            try
            {
                Connection.CurrentUser = model.Login(view.Username, view.Password);
                view.ShowInfo($"Добро пожаловать, {Connection.CurrentUser.Login}");
                view.Close();
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        public void Run()
        {
            view.ShowDialog();
        }
    }
}
