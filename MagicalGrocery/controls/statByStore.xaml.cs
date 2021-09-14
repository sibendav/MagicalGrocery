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
        public statByStore(SeriesCollection shoppingVMs)
        {
            InitializeComponent();         
            lcvStore.Series = shoppingVMs;
        }
        
    }
}
