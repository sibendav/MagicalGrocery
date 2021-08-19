using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cart
    {
        //private int CartId;
        [Key]
        public int cartId { get; set; }     
        //{
        //    get { return CartId; }
        //    set { CartId = value; }
        //}
        //private int FamilyId;
        [ForeignKey("family")]
        public int familyId { get; set; }
        public virtual Family family { get; set; }
        //{
        //    get { return FamilyId; }
        //    set { FamilyId = value; }
        //}
        //private DateTime PaymentDate;
        public DateTime paymentDate { get; set; }
        //{
        //    get { return PaymentDate; }
        //    set { PaymentDate = value; }
        //}
        //private int NumOfProducts;
        public int numOfProducts { get; set; }
        //{
        //    get { return NumOfProducts; }
        //    set { NumOfProducts = value; }
        //}
        //private double SumToPay;
        public double sumToPay { get; set; }
        //{
        //    get { return SumToPay; }
        //    set { SumToPay = value; }
        //}
        //private bool Status;
        public bool status { get; set; }
        //{
        //    get { return Status; }
        //    set { Status = value; }
        //}
        //private int StoreId;
        //[ForeignKey("store")]
        //public int storeId { get; set; }
        //public virtual Store store { get; set; }
        //{
        //    get { return StoreId; }
        //    set { StoreId = value; }
        //}
    }
}
