using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_Demo_Prism.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private string _title;

        public string Title { get => _title; set => _title = value; }
        
      
        private INavigationService _navigationService;
        private DelegateCommand _navigationCommand;
        public DelegateCommand NavigationCommand => _navigationCommand ?? (_navigationCommand = new DelegateCommand(ExceptionNavigationCommand));

      
        public MainPageViewModel(INavigationService navigationService)
        {
            Title = "Main Page";
            _navigationService = navigationService;
        }
     public void ExceptionNavigationCommand()
        {
            var p = new NavigationParameters();
            p.Add("title", "Hello from Main Page");
             _navigationService.NavigateAsync("PageA",  useModalNavigation: true);
        }
    }
}
