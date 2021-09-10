using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalGrocery.Model
{
    public class profileModel
    {
        public Family fam { set; get; }
        public Address add { set; get; }
        public List<Cart> carts { set; get; }

        public profileModel(Family family)
        {
            this.fam = family;
            this.add = BLL.BLFactory.getBL().returnAddress(family.addressOfFamilyId);
            this.carts = BLL.BLFactory.getBL().returnAllOfFamilyCart(family.familyId);
        }

        public Family updateFamily()
        {
            //if (fam.familyName != fam1.familyName)
            return BLFactory.getBL().updateFamily(fam);
        }
        public Address updateAddress()
        {
            //if (add.city != add1.city || add.street != add1.street || add.number != add1.number || add.entery != add1.entery || add.floor != add1.floor)
            return BLFactory.getBL().updateAddress(add);
        }
    }
}
