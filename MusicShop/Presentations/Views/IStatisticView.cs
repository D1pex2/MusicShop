using MusicShop.Presentations.Common;
using System;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace MusicShop.Presentations.Views
{
    public interface IStatisticView : IView
    {
        Chart Chart { get; }

        SeriesChartType ChartType { get; }

        DateTime Period { get; }

        event EventHandler SaveImageEvent;

        event EventHandler ChangeChartEvent;

    }
}
