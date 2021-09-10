using BE;
using MagicalGrocery.ViewModel;
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

namespace MagicalGrocery.controls
{
    /// <summary>
    /// Interaction logic for allShoppings.xaml
    /// </summary>
    public partial class allShoppings : UserControl
    {
        public profileVM CurrentVm { set; get; }
        
        public allShoppings(Family fam)
        {
            InitializeComponent();
            CurrentVm = new profileVM(fam);
            this.DataContext = CurrentVm;

            //for (int i=0; i < 3; i++)
            //{
            //    listbox.Items.Add(new miniShopForListBox());
            //}
        }
    }
}
