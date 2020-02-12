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

        [HttpGet("providers")]
        public async Task<IActionResult> FindProviders(FindProvidersQuery findProvidersQuery)
        {
            await Task.Delay(1000);
            return Ok("Nig");
        }

        [HttpGet("clients")]
        public async Task<IActionResult> FindProviders(FindClientsQuery findClients)
        {
            await Task.Delay(1000);
            return Ok("Nig");
        }
    }
}