using System;
using System.Windows;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using LiveCharts;
using LiveCharts.Wpf;

namespace Test_task_well.VeiwModel
{
    class WindowVM : MainVM
    {
        public double DensityFeild { get; set; } = 0;
        public double HeightFeild { get; set; } = 0;
        public SeriesCollection SeriesViews { get; set; }

        public void MainVM()
        {
            ChartPressure();
        }
        public void ChartPressure()
        {
            SeriesViews = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<double> { 6, 5, 7, 4 }
                }
            };
        }
        public void InputValues(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hi");
        }
        public void Launch(object sender, RoutedEventArgs e)
        {

        }
    }
}

