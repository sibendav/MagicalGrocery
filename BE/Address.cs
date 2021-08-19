using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Address
    {
        //private int AddressId;
        [Key]
        public int addressId { get; set; }
        //{
        //    get { return AddressId; }
        //    set { AddressId = value; }
        //}
        //private string City;
        public string city { get; set; }
        //{
        //    get { return City; }
        //    set { City = value; }
        //}
        //private string Street;
        public string street { get; set; }
        //{
        //    get { return Street; }
        //    set { Street = value; }
        //}
        //private int Number;
        public int number { get; set; }
        //{
        //    get { return Number; }
        //    set { Number = value; }
        //}
        //private string Entery;
        public string entery { get; set; }
        //{
        //    get { return Entery; }
        //    set { Entery = value; }
        //}
        //private int Floor;
        public int floor { get; set; }
        //{
        //    get { return Floor; }
        //    set { Floor = value; }
        //}
    }
}
