using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALFactory
    {
        private static IDal instance;

        protected DALFactory() { instance = null; }
        public static IDal getDal()
        {
            if (null == instance)
                instance = new Dal_imp();
            //instance = new Dal_imp();
            return instance;
        }


    }
}
