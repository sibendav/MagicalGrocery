using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ProductInCart
    {
        private int CartId;
        [ForeignKey("Cart")]
        public int cartId
        {
            get { return CartId; }
            set { CartId = value; }
        }

        private int ProductId;
        [ForeignKey("Product")]
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
        [ForeignKey("QRcode")]
        public int productQRcode
        {
            get { return ProductQRcode; }
            set { ProductQRcode = value; }
        }
    }
}
