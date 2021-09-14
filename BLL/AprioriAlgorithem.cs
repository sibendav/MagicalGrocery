using Accord.IO;
using Accord.MachineLearning.Rules;
using BE;
using CefSharp.DevTools.Browser;
using com.sun.org.apache.bcel.@internal.generic;
using com.sun.xml.@internal.txw2;
using org.omg.CORBA;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Advanced;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Controls;
using Bounds = CefSharp.DevTools.Browser.Bounds;

namespace BLL
{
    public class AprioriAlgorithm
    {
        IBll bl = BLFactory.getBL();
        public SortedSet<int>[] dataset;

        public AprioriAlgorithm()
        {
            var Result = bl.returnAllCart().
                GroupBy(item => new { item.paymentDate, item.storeId }).
                Select(item => record(item.Key.paymentDate, item.Key.storeId)).ToArray();
            dataset = Result;
        }

        public SortedSet<int> record(DateTime date, int store)
        {
            SortedSet<int> Result = new SortedSet<int>();
            foreach (var item in bl.returnAllProductInCart())
            {
                if (bl.returnCart(item.cartId).paymentDate == date)
                {
                    //Product qr = bl.returnProduct(item.productId);
                    if (bl.returnCart(item.cartId).storeId == store)
                        Result.Add(item.productId);
                }
            }
            return Result;
        }

        public AssociationRule<int>[] AprioriAlgo()
        {
            Apriori apriori = new Apriori(threshold: 1, confidence: 0);

            AssociationRuleMatcher<int> classifier = apriori.Learn(dataset);
            AssociationRule<int>[] rules = classifier.Rules;
            return rules;
        }
        public static string format(object obj, int len = 30)
        {
            string str = obj.ToString();
            return str + string.Concat(Enumerable.Repeat(" ", len - str.Length));
        }
        public static void CreatePDF(List<Product> items, Family fam)
        {
            //ObservableCollection<Product> products = 
            PdfDocument pdf = new PdfDocument();
            PdfPage pdfPage = pdf.AddPage();
            
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("David", 10, XFontStyle.Regular);
            XFont fontBold = new XFont("David", 10, XFontStyle.Bold);
            XFont fontHeader = new XFont("David", 18, XFontStyle.Bold);
            
            List<string> productsAsString = items.Select(x => $"{format(x.productName, 30)}{format(x.productPrice)}{format(x.productAmount + "$")}{(x.productPrice * x.productAmount + "$")}").ToList();

            graph.DrawString("רשימת הקניות המומלצת למשפחת " + fam.familyName, fontHeader, XBrushes.Purple, 30, 70, XStringFormats.TopRight);
            //BeginBox(graph, 7, "DrawImage (PNG)");
            //XImage image = XImage.FromFile(pngSamplePath);
            //const double dx = 250, dy = 140;
            //double width = image.PixelWidth * 72 / image.HorizontalResolution;
            //double height = image.PixelHeight * 72 / image.HorizontalResolution;
            //gfx.DrawImage(image, (dx - width) / 2, (dy - height) / 2, width, height);
            //EndBox(gfx);
            graph.DrawString($"{format("שם המוצר", 25)}{format("מחיר ליחידת מכירה", 25)}{format("כמות", 25)}{format("סך הכל", 25)}", fontBold, XBrushes.Black, 40, 150, XStringFormats.TopRight);

            int i = 1;
            graph.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Purple)), 0, 100 + 40 * i + 20, 1000, 100 + 40 * i + 20);

            foreach (var item in productsAsString)
            {
                i += 1;
                graph.DrawString(item, font, XBrushes.Black, 30, 100 + 40 * i);
                graph.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Purple)), 0, 100 + 40 * i + 20, 900, 100 + 40 * i + 20);
            }
            //IBL bl = new BL.BL();
            graph.DrawLine(new XPen(XColor.FromKnownColor(XKnownColor.Purple)), 0, 100 + 40 * i + 20, 1000, 100 + 40 * i + 20);
            //graph.DrawString($"Total: {totalPrice}$", fontBold, XBrushes.Black, 500, 100 + 40 * i + 50);

            string filename = $"{"רשימת הקניות המומלצת למשפחת " + fam.familyName} {DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss")}.pdf";
            pdf.Save(filename);

            Process.Start(filename);
        }
    }
}
