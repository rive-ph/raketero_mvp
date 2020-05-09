using Android.Content.Res;
using raketero_xamarin.Helpers;
using raketero_xamarin.Models;
using raketero_xamarin.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace raketero_xamarin.ViewModels
{
    public interface IRegisterViewModel
    {
        bool IsBusy { get; set; }
        string LoadingMessage { get; set; }

        RegisterAccountModel RegisterModel { get; set; }
        void Register();
        void GotoLogin();
    }

    public class RegisterViewModel : ViewModelBase, IRegisterViewModel
    {
        public override string ScreenName { get; set; } = "Register";

        public RegisterAccountModel RegisterModel { get; set; }
        public IViewModelNavigator ViewModelNavigator { get; }
        public IAccountsRepository AccountsRepository { get; }
        public bool IsBusy { get; set; }
        public string LoadingMessage { get; set; }

        public RegisterViewModel(IViewModelNavigator viewModelNavigator, IAccountsRepository accountsRepository)
        {
            RegisterModel = new RegisterAccountModel();
            ViewModelNavigator = viewModelNavigator;
            AccountsRepository = accountsRepository;
        }

        public void Register()
        {
            IsBusy = true;
            LoadingMessage = "Please wait";

            AccountsRepository.SignUp(
                    new Services.DTO.RegisterAccountModelDTO()
                    {
                        UserName = RegisterModel.UserName,
                        Password = RegisterModel.Password,
                        FirstName = RegisterModel.FirstName,
                        LastName = RegisterModel.LastName,
                        Address = RegisterModel.Address,
                        ContactNumber = RegisterModel.ContactNumber,
                        Email = RegisterModel.Email
                    }).ContinueWith(async task =>
                    {
                        if (task.Status == TaskStatus.RanToCompletion)
                        {
                            var data = task.Result;


                            if (data.responsecode == 1)
                            {
                                IsBusy = false;
                                LoadingMessage = "Account Created!";
                                await Task.Delay(3000);
                                ViewModelNavigator.NavigateToView("AddJobProfile");
                            }
                            else
                            {
                                IsBusy = false;
                                LoadingMessage = data.responsemsg;
                            }


                        }
                    });
        }

        public void GotoLogin()
        {
            ViewModelNavigator.NavigateToView("Login");
        }
    }
}
