using raketero_xamarin.Services.Abstractions;
using raketero_xamarin.Services.ResponseDTO;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace raketero_xamarin.Services.Concrete
{
    public interface IAccountsRepository
    {
        Task<ResponseBase<List<AccountLoginResponse>>> Login(string userName, string password);
        Task<ResponseBase<int>> SignUp(string firstname, string lastname, string address, string email, string contact_number, string username, string password);

    }
    public class AccountsRepository : RestRepositoryBase , IAccountsRepository
    {
        public AccountsRepository(IRestConfig config) 
            : base (config.BaseUrl,config.ApiKey) { }


        public async Task<ResponseBase<List<AccountLoginResponse>>> Login(string userName, string password)
        {
            var request = CreateRequest();
            request.AddQueryParameter("type", "login");
            request.AddQueryParameter("email", userName);
            request.AddQueryParameter("password", password);

            var response = await Client.GetAsync<ResponseBase<List<AccountLoginResponse>>> (request);


            return response;
        }

        public async Task<ResponseBase<int>> SignUp(string firstname, string lastname, string address, string email, string contact_number, string username, string password)
        {
            var request = CreateRequest();
            request.AddQueryParameter("type", "sign-up");
            request.AddQueryParameter("firstname", firstname);
            request.AddQueryParameter("lastname", lastname);
            request.AddQueryParameter("address", address);
            request.AddQueryParameter("email", email);
            request.AddQueryParameter("contact_number", contact_number);
            request.AddQueryParameter("username", username);
            request.AddQueryParameter("password", password);

            var response = await Client.GetAsync<ResponseBase<int>>(request);
            return response;
        }
    }
}
