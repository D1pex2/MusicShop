using MusicShop.DomainModel;
using MusicShop.Presentations.Common;
using MusicShop.Presentations.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicShop.Presentations.Presenters
{
    public class ConnectionPresenter : IPresenter
    {
        private readonly IConnectionView view;

        public ConnectionPresenter(IConnectionView view)
        {
            this.view = view;
            UpdateView();
            this.view.EditConnectionStringEvent += View_EditConnectionString;
        }

        private void View_EditConnectionString(object sender, EventArgs e)
        {
            if (view.ConfirmAction("Вы точно хотите изменить строку подключения?") == DialogResult.Yes)
            {
                SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
                connectionStringBuilder.DataSource = view.Server;
                connectionStringBuilder.InitialCatalog = view.Database;
                connectionStringBuilder.UserID = view.Username;
                connectionStringBuilder.Password = view.Password;
                var connectionString = connectionStringBuilder.ConnectionString;
                try
                {
                    if (Core.Context.Database.Connection.State == ConnectionState.Open)
                    {
                        Core.Context.Database.Connection.Close();
                    }
                    Core.Context.Database.Connection.ConnectionString = connectionString;
                    Core.Context.Database.Connection.Open();
                    File.WriteAllText($@"{Environment.CurrentDirectory}\config.cfg", connectionString);
                    view.ShowInfo("Подключение успешно. Строка подключения успешно сохранена.");
                    view.Close();
                }
                catch (Exception ex)
                {
                    view.ShowError(ex.Message);
                }
            }
        }

        public void UpdateView()
        {
            try
            {
                SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder(Core.Context.Database.Connection.ConnectionString);
                view.Server = connectionStringBuilder.DataSource;
                view.Database = connectionStringBuilder.InitialCatalog;
                view.Username = connectionStringBuilder.UserID;
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