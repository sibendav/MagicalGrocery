using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MagicalGrocery.Model
{
    public class CartModel
    {
        public Cart ca { set; get; }
        public Store sto { set; get; }
        public Family fam { set; get; }
        public Grid thisGrid { set; get; }

        public CartModel(Grid gr, Family fami)
        {            
            fam = fami;
            thisGrid = gr;
        }
        public Store addStore()
        {
            return BLL.BLFactory.getBL().addStore(sto);
        }

        public Cart addCart()
        {
            return BLL.BLFactory.getBL().addCart(ca);
        }
        public Address addAddress(Address ad)
        {
            return BLL.BLFactory.getBL().addAddress(ad);
        }
    }
}
