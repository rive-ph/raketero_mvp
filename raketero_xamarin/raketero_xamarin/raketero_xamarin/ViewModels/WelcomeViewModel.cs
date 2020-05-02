using Caliburn.Micro;
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

    }
    public class WelcomeViewModel :  ViewModelBase , IWelcomeViewModel
    {
        public override string DisplayName { get; set; } = "Welcome";
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Caption { get; set; }
        public IEventAggregator EventAggregator { get; }

        public WelcomeViewModel(IEventAggregator eventAggregator)
        {
            Title = "Raketero App";
            SubTitle = "Your local freelancer platform";
            Caption = "A web & mobile application aims to create a centralized network that will connect the businesses, LGUs to the pool of freelancers, job seekers and students looking for a part-time job.";
            EventAggregator = eventAggregator;
        }

        public void Proceed()
        {
            Func<ILoginViewModel, string> payload = x => null;
            EventAggregator.PublishOnUIThread(payload);
        }
    }
}
