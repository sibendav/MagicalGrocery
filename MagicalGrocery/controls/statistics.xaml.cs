using BE;
using BLL;
using LiveCharts;
using LiveCharts.Wpf;
using MagicalGrocery.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static BE.Enum;

namespace MagicalGrocery.controls
{
    /// <summary>
    /// Interaction logic for statistics.xaml
    /// </summary>
    public partial class statistics : UserControl
    {
        public statisticVM currentVM { get; set; }
        public statistics(Family fam)
        {
            InitializeComponent();
            this.currentVM = new statisticVM(fam);
        }

        private void store_Click(object sender, RoutedEventArgs e)
        {
            statGrid.Children.Clear();
            statGrid.Children.Add(new statByStore(ConvertStoreToDictionary(currentVM.shoppingVMs)));
        }

        public SeriesCollection ConvertStoreToDictionary(ObservableCollection<buyVM> shoppingVMs)
        {
            Dictionary<string, double> collection = new Dictionary<string, double>();

            collection = shoppingVMs.ToDictionary(item => (item.storeName + " " + item.city).ToString(), item => item.price);

            SeriesCollection PieChartSeriesCollection = new SeriesCollection();
            foreach (var pair in collection)
            {
                PieChartSeriesCollection.Add(new PieSeries { Title = $"{pair.Value} ({pair.Key})", Values = new ChartValues<double> { pair.Value }, DataLabels = true, Fill = (Brush)new BrushConverter().ConvertFrom(idGenerator.getColorID()) });
            }
            return PieChartSeriesCollection;
        }

        private void cat_Click(object sender, RoutedEventArgs e)
        {
            statGrid.Children.Clear();
            statGrid.Children.Add(new statByStore(ConvertCatToDictionary(currentVM.CategoryVMs)));
        }
        public SeriesCollection ConvertCatToDictionary(ObservableCollection<buyVM> CategoryVMs)
        {
            Dictionary<string, int> collection = new Dictionary<string, int>();

            collection = CategoryVMs.ToDictionary(item => item.category.ToString(), item => item.numcategories);

            SeriesCollection PieChartSeriesCollection = new SeriesCollection();
            foreach (var pair in collection)
            {
                PieChartSeriesCollection.Add(new PieSeries { Title = $"{pair.Value} ({pair.Key})", Values = new ChartValues<int> { pair.Value }, DataLabels = true, Fill = (Brush)new BrushConverter().ConvertFrom(idGenerator.getColorID()) });
            }
            return PieChartSeriesCollection;
        }

        private void news_Click(object sender, RoutedEventArgs e)
        {
            statGrid.Children.Clear();
            Dictionary<Month, double> dic = new Dictionary<Month, double>();
            for(int i=0; i<12; i++)
            { 
                dic.Add((Month)i, 0);
            }
            foreach (var i in currentVM.currentModel.purchases)
            {
                dic[(Month)i.paymentDate.Month] += i.sumToPay;
            }
            //var Result = currentVM.currentModel.purchases.GroupBy(item => item.paymentDate.Month.ToString()).
            //    ToDictionary(item => item.Key, item => item.Count());           

            //SeriesCollection PieChartSeriesCollection = new SeriesCollection();
            //foreach (var pair in dic)
            //{
            //    PieChartSeriesCollection.Add(new LineSeries { Title = $"{pair.Value} ({pair.Key})", Values = new ChartValues<double> { pair.Value }, DataLabels = true, Fill = (Brush)new BrushConverter().ConvertFrom(idGenerator.getColorID()) });
            //}

            SeriesCollection SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<double>(dic.Keys.OrderBy(k => k).Select(x => dic[x])),
                }
            };

            statGrid.Children.Add(new lineChart(SeriesCollection));
        }
    }
}
