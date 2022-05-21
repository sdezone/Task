using System.Net;
using System.Windows;
using System.Windows.Controls;

namespace ClientWPF.UserControllers
{
    /// <summary>
    /// AspNetWebMvc.xaml etkileşim mantığı
    /// </summary>
    public partial class AspNetWebMvc : UserControl
    {
        public AspNetWebMvc()
        {
            InitializeComponent();
        }

        private void AspNetWebMvcButton_Click(object sender, RoutedEventArgs e)
        {
          
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/text"); //Content-Type  
                client.Headers.Add("Accept:application/text");
                var result = client.DownloadString("https://localhost:7002/api/Qoniac?currency=" + currencyText.Text.Trim()); //URI  
                Words.Text = result;
            }

        }
    }
}
