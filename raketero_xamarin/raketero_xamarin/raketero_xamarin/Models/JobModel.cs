using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.Models
{
    public class JobModel : NotifyBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
