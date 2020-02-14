using System;
using System.Collections.Generic;
using System.Text;

namespace Raketero.Core.Repositories
{
    public class DapperSearchProvidersModel
    {
        public int RaketeroId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string MiddleName { get; private set; }
        public string Description { get; private set; }
        public string Tags { get; private set; }
        public DateTime PostDate { get; set; }
    }
}
