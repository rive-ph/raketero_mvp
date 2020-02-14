using Dapper;
using Management.Core;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Raketero.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raketero.Core.Repositories
{
    public class SearchRepository : RepositoryBase<MySqlConnection> , ISearchRepository
    {
        public SearchRepository(string connection) : base(new MySqlConnection(connection))
        {

        }

        MySqlTransaction _MysqlTransaction;

        public TransactionBase Transaction
        {
            get
            {
                DataConnection.Open();
                _MysqlTransaction = DataConnection.BeginTransaction();
                return new MySqlTransactionBase(_MysqlTransaction);
            }
        }

        public void Dispose()
        {
            DataConnection.Dispose();
        }

        public async Task<IEnumerable<ClientSearchResult>> SearchClients(FindClientsQuery findClientsQuery)
        {
            var requestList = await DataConnection.QueryAsync<DapperSearchClientsModel>(
               $@"SELECT 
    a.`id` AS `RaketeroId`,
    a.`FirstName`,
    a.`MiddleName`,
    a.`LastName`,
    j.`Title`,
    c.`Keywords` as `Tags`,
    c.`description`
FROM
    `account` a
        LEFT JOIN
    `job` j ON j.accountId = a.id
        LEFT JOIN
    `category` c ON c.`id` = j.`categoryId`
WHERE
    a.IsVerified = 1
and c.`Keywords` like '%{findClientsQuery.SearchKey}%'");

            var resultlist = requestList.AsList().Select(item => new ClientSearchResult(
                item.RaketeroId,
                item.FirstName,
                item.LastName,
                item.MiddleName,
                item.Description,
                JsonConvert.DeserializeObject<List<string>>(item.Tags),
                item.PostDate));

            return resultlist;
        }

        public async Task<IEnumerable<ProviderSearchResult>> SearchProviders(FindProvidersQuery findClientsQuery)
        {
            var requestList = await DataConnection.QueryAsync<DapperSearchProvidersModel>(
                $@"SELECT 
    a.`id` AS `RaketeroId`,
    a.`FirstName`,
    a.`MiddleName`,
    a.`LastName`,
    j.`Title`,
    c.`Keywords` as `Tags`,
    c.`description`
FROM
    `account` a
        LEFT JOIN
    `job` j ON j.accountId = a.id
        LEFT JOIN
    `category` c ON c.`id` = j.`categoryId`
WHERE
    a.IsVerified = 1
and c.`Keywords` like '%{findClientsQuery.SearchKey}%'");

            var resultlist = requestList.AsList().Select(item => new ProviderSearchResult(
                item.RaketeroId,
                item.FirstName,
                item.LastName,
                item.MiddleName,
                item.Description,
                JsonConvert.DeserializeObject<List<string>>(item.Tags),
                item.PostDate));

            return resultlist;
        }
    }
}
