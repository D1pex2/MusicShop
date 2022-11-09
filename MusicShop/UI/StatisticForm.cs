using MusicShop.Presentations.Views;
using System;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace MusicShop.UI
{
    public partial class StatisticForm : StyleForm, IStatisticView
    {
        public Chart Chart { get => chart; }

        public SeriesChartType ChartType 
        {
            get
            {
                chart.Legends[0].Enabled = false;
                switch (typeComboBox.SelectedItem.ToString())
                {
                    case "Линейная диаграмма":
                        return SeriesChartType.Line;
                    case "Столбчатая диаграмма":
                        return SeriesChartType.Bar;
                    default:
                        chart.Legends[0].Enabled = true;
                        return SeriesChartType.Pie;
                }
            }
        }

        public DateTime Period 
        { 
            get
            {
                switch (periodComboBox.SelectedItem.ToString())
                {
                    case "За год":
                        return DateTime.Now.AddYears(-1);
                    case "За квартал":
                        return DateTime.Now.AddMonths(-3);
                    case "За месяц":
                        return DateTime.Now.AddMonths(-1);
                    case "За неделю":
                        return DateTime.Now.AddDays(-7);
                    case "За день":
                        return DateTime.Now.AddDays(-1);
                    default:
                        return DateTime.MinValue;
                }
            }
        }

        public event EventHandler SaveImageEvent;

        public event EventHandler ChangeChartEvent;


        public StatisticForm()
        {
            InitializeComponent();
            chart.ChartAreas[0].AxisX.Interval = 1;
            periodComboBox.SelectedIndex = typeComboBox.SelectedIndex = 0;
        }

        private void SaveBlinkButton_Click(object sender, EventArgs e)
        {
            SaveImageEvent?.Invoke(sender, e);
        }

        private void PeriodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeChartEvent?.Invoke(sender, e);
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeChartEvent?.Invoke(sender, e);
        }
    }
}
