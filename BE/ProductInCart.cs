using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ProductInCart
    {
        //private int CartId;
        [Key]
        public int ProductInCartId { get; set; }

        [ForeignKey("cart")]
        public int cartId { get; set; }
        public virtual Cart cart { get; set; }
        //{
        //    get { return CartId; }
        //    set { CartId = value; }
        //}

        //private int ProductId;
        [ForeignKey("product")]
        public int productId { get; set; }
        public virtual Product product { get; set; }
        //{
        //    get { return ProductId; }
        //    set { ProductId = value; }
        //}
        //private int Amount;
        public int amount { get; set; }
        //{
        //    get { return Amount; }
        //    set { Amount = value; }
        //}
        //private double Price;
        public double price { get; set; }
        //{
        //    get { return Price; }
        //    set { Price = value; }
        //}
        //private int ProductQRcode;
        [ForeignKey("qrcode")]
        public int productQRcode { get; set; }
        public virtual QRcode qrcode { get; set; }
        //{
        //    get { return ProductQRcode; }
        //    set { ProductQRcode = value; }
        //}
    }
}
