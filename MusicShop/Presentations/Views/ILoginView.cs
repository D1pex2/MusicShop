using MusicShop.Presentations.Common;
using System;

namespace MusicShop.Presentations.Views
{
    public interface ILoginView : IView
    {
        string Username { get; }
        string Password { get; }

        event EventHandler LoginEvent;

        event EventHandler RegistrationEvent;
    }
}
