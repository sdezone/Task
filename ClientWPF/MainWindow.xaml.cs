using ClientWPF.UserControllers;
using ClientWPF.Utilities;
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

namespace ClientWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuButton_AspNetWebApi_Click(object sender, RoutedEventArgs e)
        {
            UserControlSwap.Add(gridPanel, new AspNetWebApi());
            var Bc = new BrushConverter();
            MenuButton_AspNetWebApi.Background = Bc.ConvertFrom("#7C95B7") as Brush;
            MenuButton_AspNetMvc.Background = Bc.ConvertFrom("#FF26374E") as Brush;
            MenuButton_Wcf.Background = Bc.ConvertFrom("#FF26374E") as Brush;
            MenuButton_Grpc.Background = Bc.ConvertFrom("#FF26374E") as Brush;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UserControlSwap.Add(gridPanel, new AspNetWebApi());
            var Bc = new BrushConverter();
            MenuButton_AspNetWebApi.Background = Bc.ConvertFrom("#7C95B7") as Brush;
            MenuButton_AspNetMvc.Background = Bc.ConvertFrom("#FF26374E") as Brush;
            MenuButton_Wcf.Background = Bc.ConvertFrom("#FF26374E") as Brush;
            MenuButton_Grpc.Background = Bc.ConvertFrom("#FF26374E") as Brush;
        }

        private void MenuButton_AspNetMvc_Click(object sender, RoutedEventArgs e)
        {
            UserControlSwap.Add(gridPanel, new AspNetWebMvc());
            var Bc = new BrushConverter();
           
            MenuButton_AspNetWebApi.Background = Bc.ConvertFrom("#FF26374E") as Brush;
            MenuButton_AspNetMvc.Background = Bc.ConvertFrom("#7C95B7") as Brush;
            MenuButton_Wcf.Background = Bc.ConvertFrom("#FF26374E") as Brush;
            MenuButton_Grpc.Background = Bc.ConvertFrom("#FF26374E") as Brush;
        }

        private void MenuButton_Wcf_Click(object sender, RoutedEventArgs e)
        {
            UserControlSwap.Add(gridPanel, new AspNetWcf());
            var Bc = new BrushConverter();
            MenuButton_AspNetWebApi.Background = Bc.ConvertFrom("#FF26374E") as Brush;
            MenuButton_AspNetMvc.Background = Bc.ConvertFrom("#FF26374E") as Brush;
            MenuButton_Wcf.Background = Bc.ConvertFrom("#7C95B7") as Brush;
            MenuButton_Grpc.Background = Bc.ConvertFrom("#FF26374E") as Brush;
        }

        private void MenuButton_Grpc_Click(object sender, RoutedEventArgs e)
        {
            UserControlSwap.Add(gridPanel, new AspNetGrpc());
            var Bc = new BrushConverter();
            MenuButton_AspNetWebApi.Background = Bc.ConvertFrom("#FF26374E") as Brush;
            MenuButton_AspNetMvc.Background = Bc.ConvertFrom("#FF26374E") as Brush;
            MenuButton_Wcf.Background = Bc.ConvertFrom("#FF26374E") as Brush;
            MenuButton_Grpc.Background = Bc.ConvertFrom("#7C95B7") as Brush;
        }
    }
}
