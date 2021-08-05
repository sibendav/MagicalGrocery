using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ProductInCart
    {
        private int ProductId;
        public int productId
        {
            get { return ProductId; }
            set { ProductId = value; }
        }
        private int Amount;
        public int amount
        {
            get { return Amount; }
            set { Amount = value; }
        }
        private double Price;
        public double price
        {
            get { return Price; }
            set { Price = value; }
        }
        private int ProductQRcode;
        public int productQRcode
        {
            get { return ProductQRcode; }
            set { ProductQRcode = value; }
        }
    }
}
