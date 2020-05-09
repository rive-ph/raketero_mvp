using Caliburn.Micro;
using raketero_xamarin.Abstractions;
using raketero_xamarin.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.ViewModels
{
    public interface IMainViewModel
    {
        void Logout();
    }
    //test
    public class MainViewModel : ViewModelBase , IMainViewModel
    { 
        public IModalView ActiveModal { get; set; }
        public override string ScreenName { get; set; } = "Main";
        public IEventAggregator EventAggregator { get; }
        public IViewModelNavigator ViewModelNavigator { get; }

        


        public MainViewModel(IEventAggregator eventAggregator, IViewModelNavigator viewModelNavigator)
        {
            EventAggregator = eventAggregator;
            ViewModelNavigator = viewModelNavigator;
            EventAggregator.Subscribe(this);
        }

        public void Logout()
        {
            ViewModelNavigator.NavigateToView("Login");
        }
    }
}
