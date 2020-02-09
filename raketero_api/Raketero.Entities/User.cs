using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raketero.Entities
{
    public class User : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get;set; }
        public string Suffix { get; set; }
        public DateTime BirthDate { get; set; }
        public string PermanentAddress { get; set; }
        public string TemporaryAddress { get; set; }
    }
}
