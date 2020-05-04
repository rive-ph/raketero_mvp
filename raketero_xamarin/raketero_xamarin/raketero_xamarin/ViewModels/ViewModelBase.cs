using Caliburn.Micro;
using raketero_xamarin.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace raketero_xamarin.ViewModels
{
    public abstract class ViewModelBase : Screen,  IViewModel
    {
        public virtual  string ScreenName { get; set; } = "Add Name";

     
    }
}
