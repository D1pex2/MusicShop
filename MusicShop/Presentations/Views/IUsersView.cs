using MusicShop.Presentations.Common;
using System;

namespace MusicShop.Presentations.Views
{
    public interface IUsersView : IView
    {
        object UsersSource { set; }

        object SelectedUser { get; }

        object Roles { set; }

        object SelectedRole { get; set; }

        string Login { get; }

        event EventHandler FilterEvent;

        event EventHandler AddEvent;

        event EventHandler EditEvent;

        event EventHandler DeleteEvent;
    }
}
