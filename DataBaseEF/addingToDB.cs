using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseEF
{
    public class addingToDB
    {


        public static bool addFamily(Family var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var fam = new Family() { familyName = "cohen", password = "1234", registrationDate = DateTime.Now };
                    //var fam = new Family() { familyName = var.familyName, password = var.password, registrationDate = DateTime.Now };
                    ctx.Familys.Add(fam);
                    ctx.SaveChanges();
                    return true;

                }
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
