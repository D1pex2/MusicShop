using System.Windows.Forms;

namespace MusicShop.UI
{
    public partial class StyleForm : Form
    {
        public StyleForm()
        {
            InitializeComponent();
        }

        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowInfo(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult ConfirmAction(string message)
        {
            return MessageBox.Show(message, "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}