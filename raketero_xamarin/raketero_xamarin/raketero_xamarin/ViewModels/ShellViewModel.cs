using Caliburn.Micro;
using raketero_xamarin.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace raketero_xamarin.ViewModels
{
    public class ShellViewModel : Conductor<IViewModel>.Collection.OneActive,
        IHandle<Func<ILoginViewModel, string>>
    {

        public ShellViewModel(IEnumerable<IViewModel> viewModels, IEventAggregator eventAggregator)
        {
            Items.AddRange(viewModels);
            ActiveItem = Items.FirstOrDefault(x => x.DisplayName == "Welcome");
            EventAggregator = eventAggregator;
            EventAggregator.Subscribe(this);
        }

        public IEventAggregator EventAggregator { get; }

        public void Handle(Func<ILoginViewModel, string> message)
        {
            ActiveItem = Items.FirstOrDefault(x => x.DisplayName == "Main");
        }
    }
}
