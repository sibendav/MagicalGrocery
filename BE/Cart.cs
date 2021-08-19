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
        private int CartId;
        [Key]
        public int cartId
        {
            get { return CartId; }
            set { CartId = value; }
        }
        private int FamilyId;
        [ForeignKey("Family")]
        public int familyId
        {
            get { return FamilyId; }
            set { FamilyId = value; }
        }
        private DateTime PaymentDate;
        public DateTime paymentDate
        {
            get { return PaymentDate; }
            set { PaymentDate = value; }
        }
        private int NumOfProducts;
        public int numOfProducts
        {
            get { return NumOfProducts; }
            set { NumOfProducts = value; }
        }
        private double SumToPay;
        public double sumToPay
        {
            get { return SumToPay; }
            set { SumToPay = value; }
        }
        private bool Status;
        public bool status
        {
            get { return Status; }
            set { Status = value; }
        }
        private int StoreId;
        [ForeignKey("Store")]
        public int storeId
        {
            get { return StoreId; }
            set { StoreId = value; }
        }
    }
}
