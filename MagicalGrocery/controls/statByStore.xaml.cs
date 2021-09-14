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

namespace MagicalGrocery
{
    /// <summary>
    /// Interaction logic for ButtonTitles.xaml
    /// </summary>
    public partial class statByStore : UserControl
    {
        public SeriesCollection PieChartSeriesCollection { get; set; }
        public statByStore(ObservableCollection<buyVM> shoppingVMs)
        {
            InitializeComponent();         
            lcvStore.Series = ConvertStoreToDictionary(shoppingVMs);
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
    }
}
