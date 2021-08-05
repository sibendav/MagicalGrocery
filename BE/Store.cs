using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Store
    {
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
        private Address StoreAddress;
        public Address storeAddress
        {
            get { return StoreAddress; }
            set { StoreAddress = value; }
        }
    }
}
