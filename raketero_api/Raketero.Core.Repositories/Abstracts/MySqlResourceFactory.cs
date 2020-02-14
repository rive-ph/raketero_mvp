using Management.Core;
using MySql.Data.MySqlClient;
using Raketero.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raketero.Core.Repositories
{
    public class MySqlResourceFactory<TSearchRepository> : RepositoryResourceFactoryBase<string, MySqlUnitOfWork>
        where TSearchRepository : RepositoryBase<MySqlConnection>, ISearchRepository
    {
        public MySqlResourceFactory(string connection) : base(connection)
        {
            Repositories.Add(typeof(ISearchRepository).Name, typeof(TSearchRepository));
        }
    }
}
