using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raketero.Entities
{
    public enum BusinessJobPostStatus
    {
        Active = 1, 
        Inactive = 2
    }

    public class BusinessJobPost
    {
        public string Description { get; set; }
        public DateTime PostDate { get; set; }
        public BusinessJobPostStatus BusinessJobPostStatus { get; set; }
    }
}
