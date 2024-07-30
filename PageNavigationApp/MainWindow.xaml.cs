using PageNavigationDemo.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PageNavigationDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly NavigationVM _model;
        public MainWindow(NavigationVM model)
        {
            InitializeComponent();
            DataContext = model;
            _model = model;
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            var s = (RadioButton)e.OriginalSource;
            switch (s.Name)
            {
                case "Home":
                    _model.NavigateTo<HomeVM>();
                    break;
                case "Customer":
                    _model.NavigateTo<CustomerVM>();
                    break;
                case "Products":
                    _model.NavigateTo<ProductVM>();
                    break;
                case "Orders":
                    _model.NavigateTo<OrderVM>();
                    break;
                case "Transactions":
                    _model.NavigateTo<TransactionVM>();
                    break;
                case "Shipments":
                    _model.NavigateTo<ShipmentVM>();
                    break;
                case "Settings":
                    _model.NavigateTo<SettingVM>();
                    break;
                default:
                    break;
            }
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}