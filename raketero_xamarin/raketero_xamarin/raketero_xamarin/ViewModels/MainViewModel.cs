using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public override string DisplayName { get; set; } = "Main View";
        public IEventAggregator EventAggregator { get; }

        public MainViewModel(IEventAggregator eventAggregator)
        {
            EventAggregator = eventAggregator;
            EventAggregator.Subscribe(this);
        }
    }
}
