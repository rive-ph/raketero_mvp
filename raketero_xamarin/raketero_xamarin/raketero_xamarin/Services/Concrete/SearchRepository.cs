using raketero_xamarin.Services.DTO;
using raketero_xamarin.Services.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace raketero_xamarin.Services.Concrete
{
    public interface ISearchRepository
    {
        Task<ResponseBase<List<string>>> View(SearchRaketeroModelDTO searchRaketeroModel);

    }
    public class SearchRepository : RestRepositoryBase, ISearchRepository
    {
        public SearchRepository(IRestConfig config)
       : base(config.BaseUrl, config.ApiKey) { }

        public Task<ResponseBase<List<string>>> View(SearchRaketeroModelDTO searchRaketeroModel)
        {
            throw new NotImplementedException();
        }
    }
}
