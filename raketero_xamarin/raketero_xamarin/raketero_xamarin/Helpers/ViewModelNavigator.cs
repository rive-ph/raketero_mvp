using Caliburn.Micro;
using raketero_xamarin.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.Helpers
{
    public interface IViewModelNavigator
    {
        void NavigateToView(string viewName);
    }

    public class ViewModelNavigator : IViewModelNavigator
    {
        public ViewModelNavigator(IEventAggregator eventAggregator)
        {
            EventAggregator = eventAggregator;
        }

        public IEventAggregator EventAggregator { get; }

        public void NavigateToView(string viewName)
        {
            Func<IViewModel, string> handle = x => viewName;
            EventAggregator.PublishOnBackgroundThread(handle);
        }
    }
}
