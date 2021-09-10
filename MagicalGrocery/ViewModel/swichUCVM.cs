using BE;
using MagicalGrocery.commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MagicalGrocery.ViewModel
{
    public class swichUCVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public addUC addSUC { get; set; }

        public swichUCVM(Family fam, Grid gr)
        {
            addSUC = new addUC(fam, gr);
        }
    }
}
