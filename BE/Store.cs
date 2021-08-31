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
        //private int StoreId;
        public int storeId { get; set; }
        //{
        //    get { return StoreId; }
        //    set { StoreId = value; }
        //}
        //private string StoreName;
        public string storeName { get; set; }
        //{
        //    get { return StoreName; }
        //    set { StoreName = value; }
        //}
        [ForeignKey("address")]
        //private int StoreAddressId;
        public int storeAddressId { get; set; }
        public virtual Address address { get; set; }
        //{
        //    get { return StoreAddressId; }
        //    set { StoreAddressId = value; }
        //}
    }
}
