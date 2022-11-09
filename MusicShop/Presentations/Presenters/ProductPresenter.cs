using MusicShop.DomainModel;
using MusicShop.DomainModel.ProductModel;
using MusicShop.Presentations.Common;
using MusicShop.Presentations.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicShop.Presentations.Presenters
{
    public class ProductPresenter : IPresenter
    {

        private readonly IProductView view;

        private readonly IProductModel model;

        public ProductPresenter(IProductView view, IProductModel model)
        {
            this.view = view;
            this.model = model;

            bool enableRate = Core.Context.Orders.Where(o => o.IdUser == Connection.CurrentUser.IdUser)
                .SelectMany(o => o.OrderProducts).Select(op => op.Product).Any(p => p.IdProduct == model.Product.IdProduct);
            view.EnableRate = enableRate;
            if (enableRate && Core.Context.Comments.Any(c => c.IdProduct == model.Product.IdProduct && c.IdUser == Connection.CurrentUser.IdUser))
            {
                view.SelectedRating = Core.Context.Comments
                    .FirstOrDefault(c => c.IdProduct == model.Product.IdProduct && c.IdUser == Connection.CurrentUser.IdUser).Rating;
            }

            this.view.AddToCartEvent += View_AddToCart;
            this.view.RateEvent += View_Rate;
        }

        private void View_Rate(object sender, EventArgs e)
        {
            try
            {
                model.Rate(view.SelectedRating);
                view.ShowInfo("Спасибо за ваш отзыв.");
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        private void View_AddToCart(object sender, EventArgs e)
        {
            try
            {
                model.AddToCart(model.Product);
                view.ShowInfo($"Товар {model.Product.Name} успешно добавлен в корзину");
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        private void UpdateView()
        {
            try
            {
                view.Text = model.Product.Name;
                view.Images = model.Product.Pictures;
                view.Category = model.Product.Category.Name;
                view.CurrentProductName = model.Product.Name;
                view.AvgRating = model.Product.AvgRating;
                view.Quantity = model.Product.Quantity;
                view.Description = model.Product.Description;
                view.Price = model.Product.Price;
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        public void Run()
        {
            UpdateView();
            view.Show();
        }
    }
}
