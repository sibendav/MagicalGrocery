using LiveCharts;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for miniShopForListBox.xaml
    /// </summary>
    public partial class lineChart : UserControl
    {
        public SeriesCollection SeriesCollection { get; set; }
        public lineChart(SeriesCollection SeriesCollection)
        {
            InitializeComponent();
            this.SeriesCollection = SeriesCollection;
            lbl.Series = SeriesCollection;
            string[] lblName = new string[12];
            for (int i = 0; i < 12; i++)
            {
                lblName[i] = ((Month)i).ToString();
            }
            datalbl.Labels = lblName;
        }
    }
}
