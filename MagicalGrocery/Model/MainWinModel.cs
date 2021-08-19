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
        public Family AddFamily(Family fam)
        {
            return BLFactory.getBL().addFamily(fam);
        }
        public Address AddAddress(Address add)
        {
            return BLFactory.getBL().addAddress(add);
        }
    }
}
