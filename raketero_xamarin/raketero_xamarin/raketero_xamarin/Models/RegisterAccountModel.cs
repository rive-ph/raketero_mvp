using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.Models
{
    public class RegisterAccountModel : NotifyBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        
    }
}
