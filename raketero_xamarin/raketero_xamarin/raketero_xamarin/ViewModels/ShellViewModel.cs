using Caliburn.Micro;
using raketero_xamarin.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace raketero_xamarin.ViewModels
{
    public class ShellViewModel : Conductor<IViewModel>.Collection.OneActive
    {
        public string Test { get; set; } = "Nigga";
        public ShellViewModel(IEnumerable<IViewModel> viewModels)
        {
            Items.AddRange(viewModels);
            ActiveItem = Items.FirstOrDefault();
        }
    }
}
