using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Nest;
using System.ComponentModel.DataAnnotations;
using Google.Apis.YouTube.v3.Data;

namespace BE
{
    public class QRcode
    {
        [Key]
        //private int Qrcode;
        public int qrcode { get; set; }
        //{
        //    get { return Qrcode; }
        //    set { Qrcode = value; }
        //}
        //private GeoCoordinate Location;
        //public GeoPoint location { get; set; }
        //{
        //    get { return Location; }
        //    set { Location = value; }
        //}
        //private DateTime Time;
        public DateTime time { get; set; }
        //{
        //    get { return Time; }
        //    set { Time = value; }
        //}
        //private String qRcodePicDir;
        public String QRcodePicDir { get; set; }
        //{
        //    get { return qRcodePicDir; }
        //    set { qRcodePicDir = value; }
        //}
        public String QRcodeString { get; set; }
    }
}
