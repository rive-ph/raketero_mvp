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
        public string LastName { get; private set; }
        public string MiddleName { get; private set; }
        public string Description { get; private set; }
        public List<string> Tags { get; private set; }
        public DateTime PostDate { get; set; }
        public ProviderSearchResult(int raketeroId, string firstName, string lastName, string middleName, string description, List<string> tags, DateTime postDate)
        {
            RaketeroId = raketeroId;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Description = description;
            Tags = tags;
            PostDate = postDate;
        }

    }
}
