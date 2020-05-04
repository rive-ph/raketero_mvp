using Caliburn.Micro;
using raketero_xamarin.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace raketero_xamarin.ViewModels
{
    public class ShellViewModel : Conductor<IViewModel>.Collection.OneActive,
        IHandle<Func<IViewModel, string>>
    {
        public IEventAggregator EventAggregator { get; }

        public ShellViewModel(IEnumerable<IViewModel> viewModels, IEventAggregator eventAggregator)
        {
            EventAggregator = eventAggregator;
            EventAggregator.Subscribe(this);

            Items.AddRange(viewModels);
            ActiveItem = Items.FirstOrDefault(x => x.ScreenName == "Welcome");
        }


        public void Handle(Func<IViewModel, string> message)
        {
            var data = message(null);
            ActiveItem = Items.FirstOrDefault(x => x.ScreenName == data);
        }

      
    }
}
