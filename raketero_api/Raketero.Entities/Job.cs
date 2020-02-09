using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raketero.Entities
{
    public enum JobStatus
    {
        NotSet = 0
    }

    public class Job : EntityBase
    {
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCurrentJob { get; set; }
        public bool IsActive { get; set; }
        public JobStatus Status { get; set; }
       

    }
}
