using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Raketero.Core.Services;

namespace Raketero.Core.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    public class SearchController : Controller
    {


        public SearchController(ISearchService searchService)
        {
            SearchService = searchService;
        }

        public ISearchService SearchService { get; }

        [HttpGet("providers")]
        public async Task<IActionResult> FindProviders(FindProvidersQuery findProvidersQuery)
        {
            var providerList = await SearchService.SearchProviders(findProvidersQuery);
            if (providerList.Count() > 0)
            {
                return Ok(providerList);
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("clients")]
        public async Task<IActionResult> FindClients(FindClientsQuery findClients)
        {
            try
            {
                var clientsList = await SearchService.SearchClients(findClients);
                if(clientsList.Count() > 0)
                {
                    return Ok(clientsList);
                }
                else
                {
                    return NoContent();
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}