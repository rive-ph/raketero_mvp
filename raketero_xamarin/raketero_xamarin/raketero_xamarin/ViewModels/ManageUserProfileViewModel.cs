using raketero_xamarin.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.ViewModels
{
    public interface IManageUserProfileViewModel
    {

    }
    public class ManageUserProfileViewModel : ViewModelBase , IManageUserProfileViewModel
    {
        public override string ScreenName { get; set; } = "ManageUserProfile";
        public IViewModelNavigator ViewModelNavigator { get; }

        public ManageUserProfileViewModel(IViewModelNavigator viewModelNavigator)
        {
            ViewModelNavigator = viewModelNavigator;
        }

    }
}
