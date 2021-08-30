using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace BLL
{
    public class QRdecoder
    {
        public static string showDetails(string downloadUrl)
        {
            string imageUrl = downloadUrl;
            // Install-Package ZXing.Net -Version 0.16.5
            var client = new WebClient();
            var stream = client.OpenRead(imageUrl);
            if (stream == null) 
                return null;
            var bitmap = new Bitmap(stream);
            IBarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            return result.Text;
        }
    }
}
