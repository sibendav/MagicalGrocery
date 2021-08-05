using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Family
    {
        private int FamilyId;
        public int familyId
        {
            get { return FamilyId; }
            set { FamilyId = value; }
        }
        private string FamilyName;
        public string familyName
        {
            get { return FamilyName; }
            set { FamilyName = value; }
        }
        private Address AddressOfFamily;
        public Address addressOfFamily
        {
            get { return AddressOfFamily; }
            set { AddressOfFamily = value; }
        }
        private DateTime RegistrationDate;
        public DateTime registrationDate
        {
            get { return RegistrationDate; }
            set { RegistrationDate = value; }
        }
        private List<Cart> Carts;
        public List<Cart> carts
        {
            get { return Carts; }
            set { Carts = value; }
        }
        private string Password;
        public string password
        {
            get { return Password; }
            set { Password = value; }
        }

    }
}
