using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.Services.DTO
{
    public class UpdateUserProfileModelDTO
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public string Suffix { get; set; }
        public string Birthdate { get; set; }
        public string Permanent_address { get; set; }
        public string Temporary_address { get; set; }
        public string Image_url { get; set; }
        public string Email { get; set; }
        public string Contact_number { get; set; }
        public string Last_modified { get; set; }
        public string Status { get; set; }
        public string Is_verified { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}
