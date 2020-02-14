using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Raketero.Core.Services;

namespace Raketero.Core.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public AccountController(IAccountService accountService)
        {
            AccountService = accountService;
        }

        public IAccountService AccountService { get; }

        /// <summary>
        /// Log Account
        /// </summary>
        /// <param name="loginQuery"></param>
        /// <returns></returns>
        [HttpGet("login")]
        public async Task<IActionResult> Login([FromBody]LoginQuery loginQuery)
        {
            try
            {
                return Ok(await AccountService.Login(loginQuery));
            }
            catch (Exception ex)
            {
               return BadRequest(ex);
            }
        }

        /// <summary>
        /// Register Account
        /// </summary>
        /// <param name="signUpCommand"></param>
        /// <returns></returns>
        [HttpPost("sign-up")]
        public async Task<IActionResult> SignUp([FromBody]SignUpCommand signUpCommand)
        {
            try
            {
                return Ok(await AccountService.SignUp(signUpCommand));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}