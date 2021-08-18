using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLFactory
    {
        private static IBll instance;

        protected BLFactory() { instance = null; }
        public static IBll getBL()
        {
            if (null == instance)
                instance = new imp_bll();
            return instance;
        }
    }

}
