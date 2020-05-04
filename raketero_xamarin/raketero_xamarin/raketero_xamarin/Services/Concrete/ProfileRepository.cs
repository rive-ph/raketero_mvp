using raketero_xamarin.Services.DTO;
using raketero_xamarin.Services.ResponseDTO;
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

        public Task<ResponseBase<int>> AddJobProfile(AddJobProfileModelDTO addJobProfileModelDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseBase<int>> UpdateJobProfile(AddJobProfileModelDTO addJobProfileModelDTO)
        {
            throw new NotImplementedException();
        }
    }
}
