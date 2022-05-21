using System;
using System.Collections.Generic;
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

namespace ClientWPF.UserControllers
{
    /// <summary>
    /// AspNetWcf.xaml etkileşim mantığı
    /// </summary>
    public partial class AspNetWcf : UserControl
    {
        public AspNetWcf()
        {
            InitializeComponent();
        }

        private void AspNetWcfButton_Click(object sender, RoutedEventArgs e)
        {
            using (ServiceReferenceQoniac.ServiceQoniacClient serviceQoniacClient = new())
            {
                var response = serviceQoniacClient.GetCurrencyToWordsAsync(currencyText.Text).Result;
                Words.Text = response;
            }
        }
    }
}
