using System.Windows;
using System.Windows.Controls;


namespace ClientWPF.UserControllers
{
    /// <summary>
    /// AspNetGrpc.xaml etkileşim mantığı
    /// </summary>
    public partial class AspNetGrpc : UserControl
    {
        public AspNetGrpc()
        {
            InitializeComponent();
        }

        private void AspNetWebGrpcButton_Click(object sender, RoutedEventArgs e)
        {

            QoniacBussinesLayer.QonaicGrpcClient qonaicGrpcClient = new QoniacBussinesLayer.QonaicGrpcClient();
            Words.Text = qonaicGrpcClient.GetCurrencyToWordsFromGrpc(currencyText.Text, "http://localhost:5027");
        }
    }
}
