using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cart
    {
        private int cartId;
        private int FamilyId;
        private DateTime paymentDate;
        private List<ProductInCart> pruducts;
        private int numOfProducts;
        private double sumToPay;
    }
}
