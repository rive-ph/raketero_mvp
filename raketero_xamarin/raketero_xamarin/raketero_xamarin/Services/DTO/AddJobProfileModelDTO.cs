using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.Services.DTO
{
    public class AddJobProfileModelDTO
    {
        public int Id_job { get; set; }
        public string Job_title { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public bool Is_current_job { get; set; }
        public int Id_user { get; set; }
        public string Id_image_url { get; set; }
    }
}
