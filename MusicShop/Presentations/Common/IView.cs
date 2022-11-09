using System;
using System.Windows.Forms;

namespace MusicShop.Presentations.Common
{
    public interface IView
    {
        string Text { get; set; }
        Control Parent { get; set; }
        void Show();
        DialogResult ShowDialog();
        DialogResult ConfirmAction(string message);
        void Close();
        void Hide();
        void ShowError(string errorMessage);
        void ShowInfo(string message);
    }
}
