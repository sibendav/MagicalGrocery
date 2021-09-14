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
    /// Interaction logic for profile.xaml
    /// </summary>
    public partial class profile : UserControl
    {
        public profileVM CurrentVm { set; get; }

        public profile(Family fam, Grid gr)
        {
            InitializeComponent();
            CurrentVm = new profileVM(fam, gr);
            this.DataContext = CurrentVm;
            
        }

        
    }
}
