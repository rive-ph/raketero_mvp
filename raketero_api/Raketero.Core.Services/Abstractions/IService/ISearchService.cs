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
        Task<IEnumerable<ClientSearchResult>> SearchClients(FindClientsQuery findClientsQuery);
        Task<IEnumerable<ProviderSearchResult>> SearchProviders(FindProvidersQuery findClientsQuery);
    }
}
