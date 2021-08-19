using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Family
    {
        private int FamilyId;
        [Key]
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
        private int AddressOfFamily;
        [ForeignKey("Address")]
        public int addressOfFamily
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
        //private List<Cart> Carts;
        //public List<Cart> carts
        //{
        //    get { return Carts; }
        //    set { Carts = value; }
        //}
        private string Password;
        public string password
        {
            get { return Password; }
            set { Password = value; }
        }

    }
}
