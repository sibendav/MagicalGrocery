using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Address
    {
        private int AddressId; 
        public int addressId
        {
            get { return AddressId; }
            set { AddressId = value; }
        }
        private string City;
        public string city
        {
            get { return City; }
            set { City = value; }
        }
        private string Street;
        public string street
        {
            get { return Street; }
            set { Street = value; }
        }
        private int Number;
        public int number
        {
            get { return Number; }
            set { Number = value; }
        }
        private string Entery;
        public string entery
        {
            get { return Entery; }
            set { Entery = value; }
        }
        private int Floor;
        public int floor
        {
            get { return Floor; }
            set { Floor = value; }
        }
    }
}
