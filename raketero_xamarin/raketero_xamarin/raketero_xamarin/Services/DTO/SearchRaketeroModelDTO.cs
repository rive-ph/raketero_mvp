using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.Services.DTO
{
    public class SearchRaketeroModelDTO
    {
        public string Keyword { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public bool Is_current_job { get; set; }
        public int Id_user { get; set; }
        public int Id_image_url { get; set; }
    }
}
