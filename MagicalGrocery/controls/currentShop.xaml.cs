using BE;
using DevExpress.Utils.CommonDialogs.Internal;
using MagicalGrocery.ViewModel;
using Microsoft.Win32;
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
    /// Interaction logic for currentShop.xaml
    /// </summary>
    public partial class currentShop : UserControl
    {
        private productsVM currentVM;
        public Cart thisCart { set; get; }

        public currentShop(Cart currentCart)
        {
            InitializeComponent();
            currentVM = new productsVM();
            this.DataContext = currentVM;

            //for (int i = 0; i < 3; i++)
            //{
            //    listbox.Items.Add(new miniShopForListBox());
            //}
        }

        
    }
}
