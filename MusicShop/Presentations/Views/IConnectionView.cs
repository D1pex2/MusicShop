using MusicShop.Presentations.Common;
using System;

namespace MusicShop.Presentations.Views
{
    public interface IConnectionView : IView
    {
        string Server { get; set; }

        string Database { get; set; }

        string Username { get; set; }

        string Password { get; set; }

        event EventHandler EditConnectionStringEvent;
    }
}
