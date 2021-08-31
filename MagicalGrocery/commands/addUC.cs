using BE;
using MagicalGrocery.controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MagicalGrocery.commands
{
    public class addUC : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public Grid thisGrid { get; set; }
        public Family thisFamily { get; set; }

        public addUC(Family fam, Grid gr)
        {
            this.thisFamily = fam;
            this.thisGrid = gr;
        }

        //public event Action<UserControl> AddItem;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            UserControl p = new UserControl();
            if ((string)parameter == "profile")
                p = new profile();
            if ((string)parameter == "his")
                p = new allShoppings();
            if ((string)parameter == "sta")
                p = new statistics();
            if ((string)parameter == "reco")
                p = new recommendation();
            if ((string)parameter == "news")
                p = new currentShop();
            p.HorizontalAlignment = HorizontalAlignment.Right;
            p.VerticalAlignment = VerticalAlignment.Center;
            this.thisGrid.Children.Clear();
            this.thisGrid.Children.Add(p);
        }
    }
}
