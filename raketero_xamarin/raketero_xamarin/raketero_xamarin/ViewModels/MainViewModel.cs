using Caliburn.Micro;
using raketero_xamarin.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.ViewModels
{
    public class MainViewModel : ViewModelBase
    { 
        public override string DisplayName { get; set; } = "Main";
        public IEventAggregator EventAggregator { get; }

        public MainViewModel(IEventAggregator eventAggregator)
        {
            EventAggregator = eventAggregator;
            EventAggregator.Subscribe(this);
        }

        
    }
}
