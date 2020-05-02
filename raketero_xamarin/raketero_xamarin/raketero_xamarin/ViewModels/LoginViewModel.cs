using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace raketero_xamarin.ViewModels
{
    public interface ILoginViewModel
    {
        bool isBusy { get; set; }
        void Login(string username, string password);
        string LoadingMessage { get; set; }
    }
    public class LoginViewModel : ViewModelBase , ILoginViewModel
    {
        public override string DisplayName { get; set; } = "Login";
        public bool isBusy { get; set; } = false;
        public string LoadingMessage { get; set; }


        public async void Login(string username, string password)
        {
            isBusy = true;
            await Task.Delay(5000);
            isBusy = false;

        }
    }
}
