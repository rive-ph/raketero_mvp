using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raketero.Core.Services
{
    public class ProviderSearchResult
    {
      
        public int RaketeroId { get; private set; }
        public string FirstName { get; private set; }
        public string LastNameName { get; private set; }
        public string MiddleNameName { get; private set; }
        public string Description { get; private set; }
        public List<string> Tags { get; private set; }
        public DateTime PostDate { get; set; }
        public ProviderSearchResult(int raketeroId, string firstName, string lastNameName, string middleNameName, string description, List<string> tags, DateTime postDate)
        {
            RaketeroId = raketeroId;
            FirstName = firstName;
            LastNameName = lastNameName;
            MiddleNameName = middleNameName;
            Description = description;
            Tags = tags;
            PostDate = postDate;
        }

    }
}
