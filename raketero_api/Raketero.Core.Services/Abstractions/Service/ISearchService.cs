using Management.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raketero.Core.Services
{
    public interface ISearchService : IService
    {
         Task<List<ClientSearchResult>> FindClients(FindClientsQuery search);
         Task<List<ProviderSearchResult>> FindProviders(FindProvidersQuery search);
    }
}
