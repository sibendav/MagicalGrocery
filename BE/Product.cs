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
        private int productId;
        private string productName;
        private int storeId;
        private double productPrice;
        private double productPercentOff;
        private DateTime productExpDate;
        private int productAmount;
        private string productPicDir;
        private int productStock;
        private Categories category;
    }
}
