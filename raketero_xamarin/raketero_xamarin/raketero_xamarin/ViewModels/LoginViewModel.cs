using raketero_xamarin.Helpers;
using raketero_xamarin.Models;
using raketero_xamarin.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace raketero_xamarin.ViewModels
{
    public interface ILoginViewModel
    {
        LoginModel LoginModel { get; set; }

        bool IsBusy { get; set; }
        string LoadingMessage { get; set; }

        void Login();
        void GotoRegister();

    }
    public class LoginViewModel : ViewModelBase , ILoginViewModel
    {
        public override string ScreenName { get; set; } = "Login";
        public bool IsBusy { get; set; } = false;
        public string LoadingMessage { get; set; }
        public LoginModel LoginModel { get; set; }
        public IViewModelNavigator ViewModelNavigator { get; }
        public IAccountsRepository AccountsRepository { get; }

        public LoginViewModel(IViewModelNavigator viewModelNavigator, IAccountsRepository accountsRepository)
        {
            ViewModelNavigator = viewModelNavigator;
            AccountsRepository = accountsRepository;
            LoginModel = new LoginModel();
        }


        public async void Login()
        {
            IsBusy = true;
            LoadingMessage = "Authenticating, please wait.";
            await Task.Delay(2000);
            await AccountsRepository.Login(LoginModel.UserName, LoginModel.Password)
                 .ContinueWith(task =>
                 {
                     if (task.Status == TaskStatus.RanToCompletion)
                     {
                         IsBusy = false;
                         var data = task.Result;

                         LoadingMessage = data.responsemsg;

                         if(data.responsecode == 1)
                         {
                             ViewModelNavigator.NavigateToView("Main");
                         }


                     }
                 });
        }

        public void GotoRegister()
        {
            ViewModelNavigator.NavigateToView("Register");
        }

       
    }
}
