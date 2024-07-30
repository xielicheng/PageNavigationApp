using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageNavigationDemo.Models
{
    public partial class NavigationVM : ViewModelBase
    {
        [ObservableProperty]
        private ViewModelBase? _currentView;

        public NavigationVM()
        {
            NavigateTo<HomeVM>();
        }

        public void NavigateTo<VM>() where VM : ViewModelBase
        {
            CurrentView = App.Current.ServiceProvider.GetService<VM>();
        }
    }
}
