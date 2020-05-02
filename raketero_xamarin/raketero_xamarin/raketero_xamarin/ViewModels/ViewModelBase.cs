using raketero_xamarin.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.ViewModels
{
    public abstract class ViewModelBase : IViewModel
    {
        public virtual  string DisplayName { get; set; } = "Add Name";
    }
}
