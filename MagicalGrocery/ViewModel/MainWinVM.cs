using MagicalGrocery.commands;
using MagicalGrocery.controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MagicalGrocery.ViewModel
{
    public class MainWinVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public AddItemCommand AddCommand { get; set; }
        public AddItemCommand AddCommand1 { get; set; }

        public MainWinVM()
        {
            AddCommand = new AddItemCommand();
            AddCommand.AddItem += AddCommand_AddItem;
            AddCommand1 = new AddItemCommand();
            AddCommand1.AddItem += AddCommand1_AddItem; ;
        }

        private void AddCommand1_AddItem(Grid obj)
        {
            SignUserControl enterUser = new SignUserControl();
            enterUser.HorizontalAlignment = HorizontalAlignment.Center;
            enterUser.VerticalAlignment = VerticalAlignment.Center;
            obj.Children.Clear();
            obj.Children.Add(enterUser);
        }

        private void AddCommand_AddItem(Grid arg1)
        {
            EnterUserControl enterUser = new EnterUserControl();
            enterUser.HorizontalAlignment = HorizontalAlignment.Center;
            enterUser.VerticalAlignment = VerticalAlignment.Center;
            arg1.Children.Clear();
            arg1.Children.Add(enterUser);
        }

    }
}
