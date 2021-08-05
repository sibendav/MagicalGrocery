using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Nest;

namespace BE
{
    public class QRcode
    {
        private int Qrcode;
        public int qrcode
        {
            get { return Qrcode; }
            set { Qrcode = value; }
        }
        private GeoCoordinate Location;
        public GeoCoordinate location
        {
            get { return Location; }
            set { Location = value; }
        }
        private DateTime Time;
        public DateTime time
        {
            get { return Time; }
            set { Time = value; }
        }
        private String qRcodePicDir;
        public String QRcodePicDir
        {
            get { return qRcodePicDir; }
            set { qRcodePicDir = value; }
        }
    }
}
