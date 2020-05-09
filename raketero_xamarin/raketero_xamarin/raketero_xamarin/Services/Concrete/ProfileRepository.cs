using raketero_xamarin.Services.DTO;
using raketero_xamarin.Services.ResponseDTO;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace raketero_xamarin.Services.Concrete
{
    public interface IProfileRepository
    {
        Task<ResponseBase<int>> AddJobProfile(AddJobProfileModelDTO addJobProfileModelDTO);
        Task<ResponseBase<int>> UpdateJobProfile(AddJobProfileModelDTO addJobProfileModelDTO);

    }

    public class ProfileRepository : RestRepositoryBase, IProfileRepository
    {
        public ProfileRepository(IRestConfig config)
          : base(config.BaseUrl, config.ApiKey) { }

        public async Task<ResponseBase<int>> AddJobProfile(AddJobProfileModelDTO addJobProfileModelDTO)
        {
            var request = CreateRequest("job-profile", "add");
            request.AddParameter("id_job", addJobProfileModelDTO.Id_job);
            request.AddParameter("job_title", addJobProfileModelDTO.Job_title);
            request.AddParameter("start_date", addJobProfileModelDTO.Start_date);
            request.AddParameter("end_date", addJobProfileModelDTO.End_date);
            request.AddParameter("is_current_job", addJobProfileModelDTO.Is_current_job);
            request.AddParameter("id_user", addJobProfileModelDTO.Id_user);
            request.AddParameter("id_image_url", addJobProfileModelDTO.Id_image_url);


            var response = await Client.GetAsync<ResponseBase<int>>(request);


            return response;
        }

        public Task<ResponseBase<int>> UpdateJobProfile(AddJobProfileModelDTO addJobProfileModelDTO)
        {
            throw new NotImplementedException();
        }
    }
}
