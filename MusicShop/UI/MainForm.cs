using MusicShop.DomainModel;
using MusicShop.DomainModel.CartModel;
using MusicShop.DomainModel.Catalog;
using MusicShop.DomainModel.Login;
using MusicShop.DomainModel.Orders;
using MusicShop.DomainModel.Users;
using MusicShop.Presentations.Presenters;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MusicShop.UI
{
    public partial class MainForm : StyleForm
    {
        private CatalogPresenter catalogPresenter;
        private CartPresenter cartPresenter;
        private CustomerOrdersPresenter customerOrdersPresenter;
        private OrdersPresenter ordersPresenter;
        private ManufacturersPresenter manufacturersPresenter;
        private CategoriesPresenter categoriesPresenter;
        private StatisticPresenter statisticPresenter;
        private UsersPresenter usersPresenter;

        public MainForm()
        {
            InitializeComponent();
            Manager.TabControl = contentTabControl;
            contentTabControl.ItemSize = menuTabControl.ItemSize = new Size(0, 1);
            Connection.UserChanged += UserChanged;

            var connectionPath = $@"{Environment.CurrentDirectory}\config.cfg";
            try
            {
                if (File.Exists(connectionPath))
                {
                    var connectionString = File.ReadAllText(connectionPath);
                    if (Core.Context.Database.Connection.State == System.Data.ConnectionState.Open)
                    {
                        Core.Context.Database.Connection.Close();
                    }
                    Core.Context.Database.Connection.ConnectionString = connectionString;
                    Core.Context.Database.Connection.Open();
                    SetRolesConstraint();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                ShowError("Ошибка подключения к серверу. Обратитесь к системному администратору.");
            }
        }

        private void UserChanged(object sender, EventArgs e)
        {
            SetRolesConstraint();
        }

        /// <summary>
        /// Метод разграничения прав доступа
        /// </summary>
        private void SetRolesConstraint()
        {
            //Очищаем все элементы в главном окне
            foreach (TabPage tabPage in contentTabControl.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    control.Dispose();
                }
            }
            if (Connection.CurrentUser != Connection.Admin)
            {
                CatalogForm catalogForm = new CatalogForm
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                    Parent = catalogTabPage
                };
                catalogTabPage.Tag = catalogForm;
                catalogPresenter = new CatalogPresenter(catalogForm, new CatalogModel());
                catalogPresenter.Run();
                Manager.ShowParentInTabPage(catalogTabPage);
            }
            switch (Connection.CurrentUser.Role.RoleName)
            {
                case "Покупатель":
                    menuTabControl.SelectedTab = customerTabPage;
                    CartForm cartForm = new CartForm
                    {
                        FormBorderStyle = FormBorderStyle.None,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        Parent = cartTabPage
                    };
                    cartTabPage.Tag = cartForm;
                    cartPresenter = new CartPresenter(cartForm, new CartModel());
                    CustomerOrdersForm customerOrdersForm = new CustomerOrdersForm
                    {
                        FormBorderStyle = FormBorderStyle.None,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        Parent = customerOrdersTabPage
                    };
                    customerOrdersTabPage.Tag = customerOrdersForm;
                    customerOrdersPresenter = new CustomerOrdersPresenter(customerOrdersForm);
                    break;
                case "Менеджер":
                    menuTabControl.SelectedTab = managerTabPage;
                    OrdersForm ordersForm = new OrdersForm
                    {
                        FormBorderStyle = FormBorderStyle.None,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        Parent = ordersTabPage
                    };
                    ordersTabPage.Tag = ordersForm;
                    ordersPresenter = new OrdersPresenter(ordersForm, new OrdersModel());
                    ManufacturersForm manufacturersForm = new ManufacturersForm
                    {
                        FormBorderStyle = FormBorderStyle.None,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        Parent = manufacturersTabPage
                    };
                    manufacturersTabPage.Tag = manufacturersForm;
                    manufacturersPresenter = new ManufacturersPresenter(manufacturersForm);
                    CategoriesForm categoriesForm = new CategoriesForm
                    {
                        FormBorderStyle = FormBorderStyle.None,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        Parent = categoriesTabPage
                    };
                    categoriesTabPage.Tag = categoriesForm;
                    categoriesPresenter = new CategoriesPresenter(categoriesForm);
                    StatisticForm statisticForm = new StatisticForm
                    {
                        FormBorderStyle = FormBorderStyle.None,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        Parent = statisticTabPage
                    };
                    statisticTabPage.Tag = statisticForm;
                    statisticPresenter = new StatisticPresenter(statisticForm);
                    break;
                case "Администратор":
                    menuTabControl.SelectedTab = adminTabPage;
                    UsersForm usersForm = new UsersForm
                    {
                        FormBorderStyle = FormBorderStyle.None,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        Parent = usersTabPage
                    };
                    usersTabPage.Tag = usersForm;
                    usersPresenter = new UsersPresenter(usersForm);
                    usersPresenter?.Run();
                    contentTabControl.SelectedTab = usersTabPage;
                    break;
                default:
                    menuTabControl.SelectedTab = guestTabPage;
                    break;
            }
            loginLabel.Visible = Connection.CurrentUser == Connection.Guest;
            logoutLabel.Visible = Connection.CurrentUser != Connection.Guest;
            usernameLabel.Text = Connection.CurrentUser.Login;
        }

        private void Logout()
        {
            if (ConfirmAction("Вы точно хотите выйти из учётной записи?") == DialogResult.Yes)
            {
                Connection.CurrentUser = Connection.Guest;
            }
        }

        private void Login()
        {
            new LoginPresenter(new LoginForm(), new LoginModel()).Run();
        }

        private void CatalogBlinkButton_Click(object sender, EventArgs e)
        {
            contentTabControl.SelectedTab = catalogTabPage;
        }

        private void LogoutLabel_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = DialogResult.Yes != ConfirmAction("Вы точно хотите закрыть приложение?");
        }

        private void CartBlinkButton_Click(object sender, EventArgs e)
        {
            cartPresenter?.Run();
            contentTabControl.SelectedTab = cartTabPage;
        }

        private void ContentTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text = contentTabControl.SelectedTab.Text;
        }

        private void CustomerOrderBlinkButton_Click(object sender, EventArgs e)
        {
            customerOrdersPresenter?.Run();
            contentTabControl.SelectedTab = customerOrdersTabPage;
        }

        private void ManagerManufacturerBlinkButton_Click(object sender, EventArgs e)
        {
            manufacturersPresenter?.Run();
            contentTabControl.SelectedTab = manufacturersTabPage;
        }

        private void ManagerOrderBlinkButton_Click(object sender, EventArgs e)
        {
            ordersPresenter?.Run();
            contentTabControl.SelectedTab = ordersTabPage;
        }

        private void CustomerProfileBlinkButton_Click(object sender, EventArgs e)
        {
            new EditUserPresenter(new EditUserForm(), new UserModel(Core.Context.Users.Find(Connection.CurrentUser.IdUser))).Run();
            try
            {
                Connection.CurrentUser = Core.Context.Users.Find(Connection.CurrentUser.IdUser);
                usernameLabel.Text = Connection.CurrentUser.Login;
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void ManagerCategoryBlinkButton_Click(object sender, EventArgs e)
        {
            categoriesPresenter?.Run();
            contentTabControl.SelectedTab = categoriesTabPage;
        }

        private void ManagerStatisticBlinkButton_Click(object sender, EventArgs e)
        {
            statisticPresenter?.Run();
            contentTabControl.SelectedTab = statisticTabPage;
        }

        private void UsersBlinkButton_Click(object sender, EventArgs e)
        {
            usersPresenter?.Run();
            contentTabControl.SelectedTab = usersTabPage;
        }

        private void ConnectionBlinkButton_Click(object sender, EventArgs e)
        {
            new ConnectionPresenter(new ConnectionForm()).Run();
        }
    }
}
