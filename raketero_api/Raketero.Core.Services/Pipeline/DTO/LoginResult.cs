using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raketero.Core.Services
{
    public class LoginResult
    {
        public string ResponseMessage { get; set; }
        public bool Allowed { get; set; }
        public string Token { get; set; }
    }
}
