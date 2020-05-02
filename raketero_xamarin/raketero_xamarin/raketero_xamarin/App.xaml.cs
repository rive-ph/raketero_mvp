using Caliburn.Micro.Xamarin.Forms;
using raketero_xamarin.ViewModels;

namespace raketero_xamarin
{
    public partial class App : FormsApplication
    {
        public App()
        {
            InitializeComponent();
            DisplayRootViewFor<ShellViewModel>();
        }


    }
}
