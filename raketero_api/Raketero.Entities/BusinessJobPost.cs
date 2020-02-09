using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raketero.Entities
{
    public enum BusinessJobPostStatus
    {
        NotSet = 0
    }

    public class BusinessJobPost : EntityBase
    {
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public DateTime PostDate { get; set; }
        public bool IsActive { get; set; }
        public BusinessJobPostStatus Status { get; set; }
    }
}
