using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Store
    {
        [Key]
        private int StoreId;
        public int storeId
        {
            get { return StoreId; }
            set { StoreId = value; }
        }
        private string StoreName;
        public string storeName
        {
            get { return StoreName; }
            set { StoreName = value; }
        }
        [ForeignKey("Store")]
        private int StoreAddressId;
        public int storeAddressId
        {
            get { return StoreAddressId; }
            set { StoreAddressId = value; }
        }
    }
}
