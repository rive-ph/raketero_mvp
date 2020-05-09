using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace raketero_xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : TabbedPage
    {
        public MainView()
        {
            var navigationPage = new NavigationPage();
            navigationPage.IconImageSource = "schedule.png";
            navigationPage.Title = "Schedule";

            Children.Add(new ContentPage());
            Children.Add(new ContentPage());
            Children.Add(new ContentPage());
            Children.Add(navigationPage);
        }
    }
}