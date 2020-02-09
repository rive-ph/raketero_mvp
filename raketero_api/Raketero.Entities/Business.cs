using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raketero.Entities
{
    public enum BusinessStatus
    {
        NotSet = 0
    }

    public class Business : EntityBase
    {
        public string LegalName { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Owner { get; set; }
        public string Website { get; set; }
        public BusinessStatus Status { get; set; }
        public bool IsVerified { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<BusinessCredentials> Credentials { get; set; }
    }
}
