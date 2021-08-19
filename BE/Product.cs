using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BE.Enum;

namespace BE
{
    public class Product
    {
        [Key]
        //private int ProductId;
        public int productId { get; set; }
        //{
        //    get { return ProductId; }
        //    set { ProductId = value; }
        //}
        //private string ProductName;
        public string productName { get; set; }
        //{
        //    get { return ProductName; }
        //    set { ProductName = value; }
        //}
        //private int StoreId;
        [ForeignKey("store")]
        public int storeId { get; set; }
        public virtual Store store { get; set; }
        //{
        //    get { return StoreId; }
        //    set { StoreId = value; }
        //}
        //private double ProductPrice;
        public double productPrice { get; set; }
        //{
        //    get { return ProductPrice; }
        //    set { ProductPrice = value; }
        //}
        //private double ProductPercentOff;
        public double productPercentOff { get; set; }
        //{
        //    get { return ProductPercentOff; }
        //    set { ProductPercentOff = value; }
        //}
        //private DateTime ProductExpDate;
        public DateTime productExpDate { get; set; }
        //{
        //    get { return ProductExpDate; }
        //    set { ProductExpDate = value; }
        //}
        //private int ProductAmount;
        public int productAmount { get; set; }
        //{
        //    get { return ProductAmount; }
        //    set { ProductAmount = value; }
        //}
        //private string ProductPicDir;
        public string productPicDir { get; set; }
        //{
        //    get { return ProductPicDir; }
        //    set { ProductPicDir = value; }
        //}
        //private int ProductStock;
        public int productStock { get; set; }
        //{
        //    get { return ProductStock; }
        //    set { ProductStock = value; }
        //}
        //private Categories Category;
        public Categories category { get; set; }
        //{
        //    get { return Category; }
        //    set { Category = value; }
        //}
    }
}
