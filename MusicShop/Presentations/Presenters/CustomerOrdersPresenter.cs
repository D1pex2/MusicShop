using MusicShop.DomainModel;
using MusicShop.DomainModel.ProductModel;
using MusicShop.Presentations.Common;
using MusicShop.Presentations.Views;
using MusicShop.UI;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MusicShop.Presentations.Presenters
{
    public class CustomerOrdersPresenter : IPresenter
    {

        private readonly ICustomerOrdersView view;

        public CustomerOrdersPresenter(ICustomerOrdersView view)
        {
            this.view = view;

            this.view.SelectOrderEvent += View_SelectOrder;
            this.view.OpenProductEvent += View_OpenProduct;
        }

        private void View_OpenProduct(object sender, EventArgs e)
        {
            new ProductPresenter(
                new ProductForm
                {
                    FormBorderStyle = FormBorderStyle.None,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                    Parent = view.Parent
                }, new ProductModel(view.SelectedProduct as Product)).Run();
            view.Hide();
        }

        private void View_SelectOrder(object sender, EventArgs e)
        {
            var order = view.SelectedOrder as Order;
            if (order != null)
            {
                view.ProductsSource = order.OrderProducts.Select(op => op.Product).ToList();
            }
        }

        public void UpdateView()
        {
            view.OrdersSource = Core.Context.Orders
                .Where(o => o.IdUser == Connection.CurrentUser.IdUser).OrderByDescending(o => o.OrderDate).ToList();
        }

        public void Run()
        {
            UpdateView();
            view.Show();
        }
    }
}
