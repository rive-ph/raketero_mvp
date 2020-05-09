using raketero_xamarin.Services.Abstractions;
using raketero_xamarin.Services.DTO;
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
        Task<ResponseBase<List<Account>>> View(ViewUserModelDTO viewUserModel);
        Task<ResponseBase<List<Account>>> Login(LoginModelDTO loginModel);
        Task<ResponseBase<int>> SignUp(RegisterAccountModelDTO registerAccountModel);
        Task<ResponseBase<int>> UpdateAccount(UpdateUserProfileModelDTO updateUserProfileModelDTO);
        Task<ResponseBase<int>> DeleteAccount(DeleteUserProfileModelDTO deleteUserProfileModel);
    }
    public class AccountsRepository : RestRepositoryBase , IAccountsRepository
    {
        public AccountsRepository(IRestConfig config) 
            : base (config.BaseUrl,config.ApiKey) { }



        public async Task<ResponseBase<List<Account>>> Login(LoginModelDTO loginModel)
        {
            var request = CreateRequest("login");
            request.AddQueryParameter("email", loginModel.Username);
            request.AddQueryParameter("password", loginModel.Password);
            var response = await Client.GetAsync<ResponseBase<List<Account>>> (request);

            return response;
        }

        public async Task<ResponseBase<int>> SignUp(RegisterAccountModelDTO registerAccountModel)
        {
            var request = CreateRequest("sign-up");
            request.AddQueryParameter("firstname", registerAccountModel.FirstName);
            request.AddQueryParameter("lastname", registerAccountModel.LastName); 
            request.AddQueryParameter("address", registerAccountModel.Address);
            request.AddQueryParameter("email", registerAccountModel.Email);
            request.AddQueryParameter("contact_number", registerAccountModel.ContactNumber);
            request.AddQueryParameter("username", registerAccountModel.UserName);
            request.AddQueryParameter("password", registerAccountModel.Password);

            var response = await Client.GetAsync<ResponseBase<int>>(request);
            return response;
        }

        public async Task<ResponseBase<List<Account>>> View(ViewUserModelDTO viewUserModel)
        {
            var request = CreateRequest("profile-user", "view");
            request.AddQueryParameter("column", viewUserModel.Column);
            var response = await Client.GetAsync<ResponseBase<List<Account>>> (request);

            return response;
        }
        public async Task<ResponseBase<int>> DeleteAccount(DeleteUserProfileModelDTO deleteUserProfileModel)
        {
            var request = CreateRequest("profile-user", "delete");
            request.AddQueryParameter("user_id", deleteUserProfileModel.User_id.ToString());
            var response = await Client.GetAsync<ResponseBase<int>>(request);
            return response;
        }

        public async Task<ResponseBase<int>> UpdateAccount(UpdateUserProfileModelDTO updateUserProfileModelDTO)
        {
            var request = CreateRequest("profile-user", "update");
            request.AddQueryParameter("firstname", updateUserProfileModelDTO.Firstname);
            request.AddQueryParameter("lastname", updateUserProfileModelDTO.Lastname);
            request.AddQueryParameter("middlename", updateUserProfileModelDTO.Middlename);
            request.AddQueryParameter("suffix", updateUserProfileModelDTO.Suffix);
            request.AddQueryParameter("birthdate", updateUserProfileModelDTO.Birthdate);
            request.AddQueryParameter("permanent_address", updateUserProfileModelDTO.Permanent_address);
            request.AddQueryParameter("temporary_address", updateUserProfileModelDTO.Temporary_address);
            request.AddQueryParameter("image_url", updateUserProfileModelDTO.Image_url);
            request.AddQueryParameter("email", updateUserProfileModelDTO.Email);
            request.AddQueryParameter("contact_number", updateUserProfileModelDTO.Contact_number);
            request.AddQueryParameter("status", updateUserProfileModelDTO.Status);
            request.AddQueryParameter("is_verified", updateUserProfileModelDTO.Is_verified);
            request.AddQueryParameter("username", updateUserProfileModelDTO.Username);
            request.AddQueryParameter("password", updateUserProfileModelDTO.Password);
            var response = await Client.GetAsync<ResponseBase<int>>(request);
            return response;
        }
    }
}
