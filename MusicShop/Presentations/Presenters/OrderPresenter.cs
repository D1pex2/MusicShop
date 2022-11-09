using MusicShop.DomainModel;
using MusicShop.Presentations.Common;
using MusicShop.Presentations.Views;
using System;
using System.Linq;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace MusicShop.Presentations.Presenters
{
    public class OrderPresenter : IPresenter
    {
        private readonly IOrderView view;

        private readonly IOrderModel model;

        public OrderPresenter(IOrderView view, IOrderModel model)
        {
            this.view = view;
            this.model = model;

            this.view.ChangeOrderEvent += View_ChangeOrder;
            this.view.DeleteOrderEvent += View_DeleteOrder;
            this.view.SaveOrderEvent += View_SaveOrder;
        }

        private void View_SaveOrder(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "docx|*.docx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var wordApp = new Word.Application();
                    var doc = wordApp.Documents.Add($@"{Environment.CurrentDirectory}\Template\OrderTemplate.docx");
                    string fullName = $"{model.Order.User.Surname} {model.Order.User.Name} {model.Order.User.Patronymic}";
                    doc.Content.Find.Execute(FindText: "%fullName%", ReplaceWith: fullName, Replace: Word.WdReplace.wdReplaceAll);
                    doc.Content.Find.Execute(FindText: "%phone%", ReplaceWith: model.Order.User.Phone, Replace: Word.WdReplace.wdReplaceAll);
                    doc.Content.Find.Execute(FindText: "%address%", ReplaceWith: model.Order.DeliveryAddress, Replace: Word.WdReplace.wdReplaceAll);
                    doc.Content.Find.Execute(FindText: "%orderDate%", ReplaceWith: model.Order.OrderDate.ToShortDateString(), Replace: Word.WdReplace.wdReplaceAll);
                    doc.Content.Find.Execute(FindText: "%deliveryDate%", ReplaceWith: model.Order.DeliveryDate.ToShortDateString(), Replace: Word.WdReplace.wdReplaceAll);
                    doc.Content.Find.Execute(FindText: "%sum%", ReplaceWith: $"{model.Order.OrderProducts.Sum(op => op.Quantity * op.Product.Price)} руб.", Replace: Word.WdReplace.wdReplaceAll);
                    foreach (var orderProduct in model.Order.OrderProducts)
                    {
                        var row = doc.Tables[1].Rows.Add();
                        row.Cells[1].Range.Text = orderProduct.Product.Name;
                        row.Cells[2].Range.Text = orderProduct.Product.Price.ToString();
                        row.Cells[3].Range.Text = orderProduct.Quantity.ToString();
                    }
                    doc.SaveAs(saveFileDialog.FileName);
                    wordApp.Quit();
                    view.ShowInfo($"Заказ успешно сохранен по пути: {saveFileDialog.FileName}");
                }
                catch (Exception ex)
                {
                    view.ShowError(ex.Message);
                }
            }
        }

        private void View_DeleteOrder(object sender, EventArgs e)
        {
            if (view.ConfirmAction("Вы уверены, что хотите удалить заказ?") != DialogResult.Yes)
            {
                return;
            }
            try
            {
                model.DeleteOrder();
                view.ShowInfo("Заказ успешно удален.");
                view.Close();
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        private void View_ChangeOrder(object sender, EventArgs e)
        {
            if (view.ConfirmAction("Подтвердите изменение заказа.") != DialogResult.Yes)
            {
                return;
            }
            try
            {
                model.SaveOrder(view.Address, view.DeliveryDate);
                view.ShowInfo("Заказ успешно изменен.");
                view.Close();
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        private void UpdateView()
        {
            var user = model.Order.User;
            view.Phone = user.Phone;
            view.FullName = $"{user.Surname} {user.Name} {user.Patronymic}";
            view.OrderProducts = model.Order.OrderProducts
                .Select(op => new { LastPicture = op.Product.LastPicture, Name = op.Product.Name, Price = op.Product.Price, op.Quantity }).ToList();
            view.Address = model.Order.DeliveryAddress;
            view.OrderDate = model.Order.OrderDate;
            view.DeliveryDate = model.Order.DeliveryDate;
        }

        public void Run()
        {
            UpdateView();
            view.ShowDialog();
        }
    }
}
