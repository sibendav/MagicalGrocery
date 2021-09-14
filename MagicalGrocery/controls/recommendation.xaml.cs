using Accord.MachineLearning.Rules;
using BE;
using BLL;
using MagicalGrocery.Model;
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

namespace MagicalGrocery.controls
{
    /// <summary>
    /// Interaction logic for recommendation.xaml
    /// </summary>
    public partial class recommendation : UserControl
    {
        public FamilyRecommendationModel currentModel { get; set; }
        public ObservableCollection<Product> ProductVMs { get; set; }

        public recommendation(Family fam)
        {
            InitializeComponent();
            currentModel = new FamilyRecommendationModel(fam);
            ProductVMs = new ObservableCollection<Product>(currentModel.familyProducts);
            thisReco.ItemsSource = ProductVMs;
            //this.DataContext = currentModel;
        }
        
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<object[]> items = new List<object[]>();
            foreach (Product item in ProductVMs)
            {
                items.Add(new object[] { item.productName, item.productPrice, item.productPicDir });
            }
            AprioriAlgorithm.CreatePDF(currentModel.familyProducts, currentModel.thisFamily);
        }
        
    }
}
