using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Input;
using WpfApp1.Utilities;

namespace WpfApp1.ViewModels
{
    class NavigationViewModel : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand SettingsCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeViewModel();
        private void Setting(object obj) => CurrentView = new SettingsViewModel();

        public NavigationViewModel()
        {
            HomeCommand = new RelayCommand(Home);
            SettingsCommand = new RelayCommand(Setting);

            // Startup Page
            CurrentView = new HomeViewModel();
        }
    }
}
