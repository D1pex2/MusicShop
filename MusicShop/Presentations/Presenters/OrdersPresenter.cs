using MusicShop.DomainModel;
using MusicShop.DomainModel.Orders;
using MusicShop.Presentations.Common;
using MusicShop.Presentations.Views;
using MusicShop.UI;
using System;
using System.Collections.Generic;

namespace MusicShop.Presentations.Presenters
{
    public class OrdersPresenter : IPresenter
    {
        private readonly IOrdersView view;

        private readonly IOrdersModel model;

        public OrdersPresenter(IOrdersView view, IOrdersModel model)
        {
            this.view = view;
            this.model = model;

            this.view.FilterEvent += View_Filter;
            this.view.ResetEvent += View_Reset;
            this.view.PreviousPageEvent += View_PreviousPage;
            this.view.NextPageEvent += View_NextPage;
            this.view.LastPageEvent += View_LastPage;
            this.view.FirstPageEvent += View_FirstPage;
            this.view.OpenOrderEvent += View_OpenOrder;
        }

        private void View_OpenOrder(object sender, EventArgs e)
        {
            if (view.SelectedOrder == null) return;
            try
            {
                var order = Core.Context.Orders.Find((view.SelectedOrder as OrderView).IdOrder);
                if (order == null) return;
                new OrderPresenter(new OrderForm(), new OrderModel(order)).Run();
                UpdateView(model.Orders);
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        private void View_FirstPage(object sender, EventArgs e)
        {
            model.CurrentPage = 1;
            UpdateView();
        }

        private void View_LastPage(object sender, EventArgs e)
        {
            model.CurrentPage = model.TotalPage;
            UpdateView();
        }

        private void View_NextPage(object sender, EventArgs e)
        {
            model.CurrentPage++;
            UpdateView();
        }

        private void View_PreviousPage(object sender, EventArgs e)
        {
            model.CurrentPage--;
            UpdateView();
        }

        private void View_Reset(object sender, EventArgs e)
        {
            UpdateView(model.Orders);
        }

        private void View_Filter(object sender, EventArgs e)
        {
            UpdateView(model.GetFilteredOrders(model.Orders, view.FullName, view.BeginDate, view.EndDate));
            view.ShowInfo($"Найдено {model.OrdersPagesCount} заказов");
        }

        private void UpdateView(List<OrderView> products = null)
        {
            try
            {
                if (products != null)
                {
                    model.OrdersPages = products;
                }
                view.OrdersSource = model.OrdersPages;
                view.PageStatus = $"Страница {model.CurrentPage} из {model.TotalPage}";
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        public void Run()
        {
            UpdateView(model.Orders);
            view.Show();
        }
    }
}
