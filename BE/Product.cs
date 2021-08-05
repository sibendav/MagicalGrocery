using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BE.Enum;

namespace BE
{
    public class Product
    {
        private int ProductId;
        public int productId
        {
            get { return ProductId; }
            set { ProductId = value; }
        }
        private string ProductName;
        public string productName
        {
            get { return ProductName; }
            set { ProductName = value; }
        }
        private int StoreId;
        public int storeId
        {
            get { return StoreId; }
            set { StoreId = value; }
        }
        private double ProductPrice;
        public double productPrice
        {
            get { return ProductPrice; }
            set { ProductPrice = value; }
        }
        private double ProductPercentOff;
        public double productPercentOff
        {
            get { return ProductPercentOff; }
            set { ProductPercentOff = value; }
        }
        private DateTime ProductExpDate;
        public DateTime productExpDate
        {
            get { return ProductExpDate; }
            set { ProductExpDate = value; }
        }
        private int ProductAmount;
        public int productAmount
        {
            get { return ProductAmount; }
            set { ProductAmount = value; }
        }
        private string ProductPicDir;
        public string productPicDir
        {
            get { return ProductPicDir; }
            set { ProductPicDir = value; }
        }
        private int ProductStock;
        public int productStock
        {
            get { return ProductStock; }
            set { ProductStock = value; }
        }
        private Categories Category;
        public Categories category
        {
            get { return Category; }
            set { Category = value; }
        }
    }
}
