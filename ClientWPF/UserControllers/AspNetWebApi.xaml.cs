using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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

namespace ClientWPF.UserControllers
{
    /// <summary>
    /// AspNetWebApi.xaml etkileşim mantığı
    /// </summary>
    public partial class AspNetWebApi : UserControl
    {
        public AspNetWebApi()
        {
            InitializeComponent();
        }

        private void AspNetWebApiButton_Click(object sender, RoutedEventArgs e)
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/text"); //Content-Type  
                client.Headers.Add("Accept:application/text");
                var result = client.DownloadString("https://localhost:7268/api/Qoniac?currency=" + currencyText.Text.Trim()); //URI  
                Words.Text = result;
            }
         
        }

    }
}
