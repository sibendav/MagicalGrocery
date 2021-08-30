using DevExpress.Utils.CommonDialogs.Internal;
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
        public currentShop()
        {
            InitializeComponent();
            //for (int i = 0; i < 3; i++)
            //{
            //    listbox.Items.Add(new miniShopForListBox());
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\Users\simha\source\repos\MagicalGrocery\MagicalGrocery\images";
            openFileDialog1.Filter = "Document Files|*.txt|Pictures Files|*.jpeg;*.jpg;*.png|All Files(*.*)|*.*"; ;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == true)
            {
                var path = openFileDialog1.FileName;
                BLL.BLFactory.getBL().addToFirebase(path);
            }
        }
    }
}
