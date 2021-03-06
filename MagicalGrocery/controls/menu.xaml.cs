using BE;
using MagicalGrocery.commands;
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
    /// Interaction logic for menu.xaml
    /// </summary>
    public partial class menu : UserControl
    {
        public Family thisFamily;

        public swichUCVM currentVM;

        public menu(Family fam)
        {
            InitializeComponent();
            title.nameFam.Content += fam.familyName;
            thisFamily = fam;

            currentVM = new swichUCVM(fam, mainGrid);
            this.DataContext = currentVM;
        }
        

       
    }
}
