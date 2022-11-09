using MusicShop.DomainModel;
using MusicShop.Presentations.Common;
using MusicShop.Presentations.Views;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MusicShop.Presentations.Presenters
{
    public class StatisticPresenter : IPresenter
    {
        private readonly IStatisticView view;

        public StatisticPresenter(IStatisticView view)
        {
            this.view = view;

            this.view.SaveImageEvent += View_SaveImage;
            this.view.ChangeChartEvent += View_ChangeChart;
        }

        private void View_ChangeChart(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void View_SaveImage(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "png|*.png";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    view.Chart.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                    view.ShowInfo($"Изображение сохранено по пути: {saveFileDialog.FileName}");
                }
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        private void UpdateView()
        {
            var series = view.Chart.Series[0];
            series.ChartType = view.ChartType;
            try
            {
                var orders = Core.Context.Orders.Where(o => o.OrderDate >= view.Period)
                    .SelectMany(o => o.OrderProducts).GroupBy(op => op.Product)
                    .Select(g => new { Name = g.Key.Name, Quantity = g.Sum(q => q.Quantity), Category = g.Key.Category }).ToList();
                series.Points.Clear();
                foreach (var order in orders)
                {
                    series.Points.AddXY(order.Name, order.Quantity);
                }
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