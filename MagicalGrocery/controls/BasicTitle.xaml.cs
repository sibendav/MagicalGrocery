using MagicalGrocery.controls;
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

namespace MagicalGrocery
{
    /// <summary>
    /// Interaction logic for BasicTitle.xaml
    /// </summary>
    public partial class BasicTitle : UserControl
    {
        private MainWinVM currentVM;

        public BasicTitle()
        {
            InitializeComponent();
            currentVM = new MainWinVM();
            this.DataContext = currentVM;            
        }

        
    }
}
