﻿using Management.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raketero.Core.Services.Concrete
{
    public class SearchService<TDataConnection, TUnitOfWork> : ServiceBase<TDataConnection, TUnitOfWork>, ISearchService
        where TUnitOfWork : IUnitOfWork
    {
        public SearchService(IRepositoryResourceFactory<TDataConnection, TUnitOfWork> repositoryResourceFactory, 
            IHelperResourceFactory helperResourceFactory = null)
            : base(repositoryResourceFactory, helperResourceFactory)
        {
        }

        public Task<IEnumerable<ClientSearchResult>> SearchClients(FindClientsQuery findClientsQuery)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FindProvidersQuery>> SearchProviders(FindProvidersQuery findClientsQuery)
        {
            throw new NotImplementedException();
        }
    }
}
