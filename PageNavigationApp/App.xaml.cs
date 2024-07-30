using Microsoft.Extensions.DependencyInjection;
using PageNavigationDemo.Models;
using PageNavigationDemo.Views;
using System.Configuration;
using System.Data;
using System.Windows;

namespace PageNavigationDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static new App Current => (App)Application.Current;
        public ServiceProvider ServiceProvider { get; set; }

        public App()
        {
            var container = new ServiceCollection();

            container.AddSingleton<MainWindow>();
            container.AddSingleton<NavigationVM>();

            container.AddSingleton<HomeVM>();
            container.AddSingleton<CustomerVM>();
            container.AddSingleton<ProductVM>();
            container.AddSingleton<OrderVM>();
            container.AddSingleton<TransactionVM>();
            container.AddSingleton<ShipmentVM>();
            container.AddSingleton<SettingVM>();

            ServiceProvider = container.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            MainWindow.Show();
        }
    }
}
