using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Enum
    {
        public enum Categories
        {
            Sale, Food, Drink, Clean, Pharma, Clothing, Electronics
        }

        public static Categories Parse(Type type, string v, bool v1)
        {
            return (Categories)Enum.Parse(typeof(Categories), v, true);
        }

        public enum Month
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
    }
}
