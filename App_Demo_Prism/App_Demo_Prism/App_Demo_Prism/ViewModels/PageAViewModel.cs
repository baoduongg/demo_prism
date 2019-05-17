using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Demo_Prism.ViewModels
{
    public class PageAViewModel:BindableBase,INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

      //  public string Title { get => _title; set => _title = value; }
        private string temp;
        private INavigationService _navigationService;
        private DelegateCommand _navigationCommand;
        public DelegateCommand NavigationCommand => _navigationCommand ?? (_navigationCommand = new DelegateCommand(ExceptionNavigationCommand));

     

        public PageAViewModel(INavigationService navigationService)
        {
           
            _navigationService = navigationService;
        }
        async void ExceptionNavigationCommand()
        {
            await _navigationService.GoBackAsync();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
          
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
           temp = parameters.GetValue<string>("title");
            Title = temp;
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
           
        }
    }
}
