using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.Models
{
    public class LoginModel : NotifyBase
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
