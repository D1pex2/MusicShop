using System.Windows.Forms;

namespace MusicShop.UI
{
    sealed class Manager
    {
        public static TabControl TabControl { get; set; }

        private Manager() { }

        public static void ShowParentInTabPage(TabPage tabPage)
        {
            foreach (Control control in tabPage.Controls)
            {
                if (control == tabPage.Tag)
                {
                    control.Show();
                }
                else
                {
                    control.Dispose();
                }
            }
            TabControl.SelectedTab = tabPage;
        }
    }
}
