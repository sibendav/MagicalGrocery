using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Windows.Navigation;
using BE;
using BLL;

namespace MagicalGrocery.Model
{
    public class MainWinModel
    {
        public void Add(Family fam)
        {
            BLFactory.getBL().addFamily(fam);
        }
    }
}
