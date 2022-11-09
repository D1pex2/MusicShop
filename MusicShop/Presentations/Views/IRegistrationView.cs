using MusicShop.Presentations.Common;
using System;

namespace MusicShop.Presentations.Views
{
    public interface IRegistrationView : IView
    {
        object Roles { set; }

        object SelectedRole { get; set; }

        bool EnableSelectRole { set; }

        string UserName { get; set; }

        string UserSurname { get; set; }

        string UserPatronymic { get; set; }

        string UserPhone { get; set; }

        string UserLogin { get; set; }

        string UserPassword { get; set; }

        event EventHandler RegistrationEvent;
    }
}