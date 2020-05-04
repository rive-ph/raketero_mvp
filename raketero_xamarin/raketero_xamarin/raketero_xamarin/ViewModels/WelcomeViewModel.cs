using Caliburn.Micro;
using raketero_xamarin.Abstractions;
using raketero_xamarin.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.ViewModels
{
    public interface IWelcomeViewModel
    {
        string Title { get; set; }
        string SubTitle { get; set; }

        string Caption { get; set; }

        void Proceed();
        void MoreInfo();

    }
    public class WelcomeViewModel :  ViewModelBase , IWelcomeViewModel
    {
        public override string ScreenName { get; set; } = "Welcome";
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Caption { get; set; }
        public IEventAggregator EventAggregator { get; }
        public IViewModelNavigator Navigator { get; }

        public WelcomeViewModel(IEventAggregator eventAggregator, IViewModelNavigator navigator)
        {
            SubTitle = "Your local freelancer platform";
            Caption = "A web & mobile application aims to create a centralized network that will connect the businesses, LGUs to the pool of freelancers, job seekers and students looking for a part-time job.";
            EventAggregator = eventAggregator;
            Navigator = navigator;
            EventAggregator.Subscribe(this);
        }

        public void Proceed()
        {
            Navigator.NavigateToView("Login");
        }

        public void MoreInfo()
        {
            Navigator.NavigateToView("MoreInfo");

        }
    }
}
