using MusicShop.DomainModel;
using MusicShop.DomainModel.CartModel;
using MusicShop.DomainModel.ProductModel;
using MusicShop.Presentations.Common;
using MusicShop.Presentations.Views;
using MusicShop.UI;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MusicShop.Presentations.Presenters
{
    public class CartPresenter : IPresenter
    {
        private readonly ICartView view;

        private readonly ICartModel model;

        public CartPresenter(ICartView view, ICartModel model)
        {
            this.view = view;
            this.model = model;

            this.view.RemoveProductEvent += View_RemoveProduct;
            this.view.AddOrderEvent += View_AddOrder;
            this.view.IncreaseQuantityEvent += View_IncreaseQuantity;
            this.view.DecreaseQuantityEvent += View_DecreaseQuantity;
            this.view.OpenProductEvent += View_OpenProduct;
        }

        private void View_OpenProduct(object sender, EventArgs e)
        {
            var product = Core.Context.Products.FirstOrDefault(p => p.IdProduct == view.SelectedProductId);
            if (product == null) return;
            new ProductPresenter(
                new ProductForm
                {
                    FormBorderStyle = FormBorderStyle.None,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                    Parent = view.Parent
                }, new ProductModel(product)).Run();
            view.Hide();
        }

        private void View_DecreaseQuantity(object sender, EventArgs e)
        {
            var cartProduct = model.CartProducts.FirstOrDefault(c => c.IdProduct == view.SelectedProductId);
            short quantity = cartProduct.Quantity;
            if (quantity > 1)
            {
                quantity--;
                ChangeQuantity(cartProduct, quantity);
            }
        }

        private void ChangeQuantity(Cart cartProduct, short quantity)
        {
            try
            {
                model.ChangeCartQuantity(cartProduct, quantity);
                UpdateView();
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        private void View_IncreaseQuantity(object sender, EventArgs e)
        {
            var cartProduct = model.CartProducts.FirstOrDefault(c => c.IdProduct == view.SelectedProductId);
            short quantity = cartProduct.Quantity;
            if (quantity < cartProduct.Product.Quantity)
            {
                quantity++;
                ChangeQuantity(cartProduct, quantity);
            }
        }

        private void View_AddOrder(object sender, EventArgs e)
        {
            if (view.ConfirmAction("Подтвердите оформление заказа") != DialogResult.Yes)
                return;
            try
            {
                Order order = new Order
                {
                    IdUser = Connection.CurrentUser.IdUser,
                    DeliveryAddress = view.DeliveryAddress,
                    DeliveryDate = view.DeliveryDate,
                };
                model.AddOrder(order);
                view.ShowInfo("Заказ успешно оформлен");
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
            UpdateView();
        }

        private void View_RemoveProduct(object sender, EventArgs e)
        {
            if (view.ConfirmAction("Вы уверены, что хотите убрать товар из корзины?") != DialogResult.Yes)
                return;
            try
            {
                model.RemoveProduct(model.CartProducts.FirstOrDefault(c => c.IdProduct == view.SelectedProductId));
                UpdateView();
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        public void UpdateView()
        {
            try
            {
                view.Cost = model.Cost;
                view.DataSource = model.CartProducts
                    .Select(c => new { Name = c.Product.Name, Image = c.Product.LastPicture, Price = c.Product.Price, 
                        Quantity = c.Quantity, c.IdProduct, InStockQuantity = c.Product.Quantity }).ToList();
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