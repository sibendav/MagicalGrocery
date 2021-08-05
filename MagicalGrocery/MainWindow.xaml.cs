using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace MagicalGrocery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string url="URL: ";
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "vP5MhoQZmt9ckKDbJSmiHglgR4Bp93venugUpL0x",
            BasePath = "https://primal-catfish-292708-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = url;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                MessageBox.Show("Connection is ON!");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                MessageBox.Show("Connection is ON!");
            }
            stam();
        }
        public async static Task stam()
        {
            var stream = File.Open(@"C:\Users\simha\Desktop\stam1.jpg", FileMode.Open);
            // Construct FirebaseStorage with path to where you want to upload the file and put it there
            var task = new FirebaseStorage("magicalgrocery-fbaa0.appspot.com")
            .Child("stam1.jpg")
            .PutAsync(stream);
            // Track progress of the upload
            task.Progress.ProgressChanged += (s, e) => url=$"Progress:{ e.Percentage} % ";
            // Await the task to wait until upload is completed and get the download url
            var downloadUrl = await task;
            url = "URL: " + downloadUrl;
        }
    }
}
