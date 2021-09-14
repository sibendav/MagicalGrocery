using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class idGenerator
    {
        
        private static int colorID { get; set; }

        static idGenerator()
        {
           
            colorID = 0;
        }

        

        public static string getColorID()
        {
            if (color.Count > colorID)
                return color[colorID++];
            else
                return color[(colorID = 1)];
        }

        public static List<string> color
        {
            get
            {
                return new List<string>() { "#D990E0", "#CA3BD8", "#CC68E4", "#68BAE4", "#CFEAF8", "#42B7EB" };
            }
            set { }
        }

    }
}
