using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.Services.ResponseDTO
{
    public class AccountLoginResponse
    {
        public int user_id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string middlename { get; set; }
        public string suffix { get; set; }
        public string birthdate { get; set; }
        public string permanent_address { get; set; }
        public string temporary_address { get; set; }
        public string image_url { get; set; }
        public string email { get; set; }
        public string contact_number { get; set; }
        public string last_modified { get; set; }
        public string status { get; set; }
        public string is_verified { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string token { get; set; }

    }
}
