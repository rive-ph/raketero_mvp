using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raketero.Core.Services
{
    public class ProviderSearchResult
    {

        public int ProviderId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<string> Tags { get; private set; }
        public DateTime PostDate { get; set; }
        public int SearchRatingRatio { get; set; }

        public ProviderSearchResult(int providerId, string name, string description, List<string> tags, DateTime postDate, int searchRatingRatio)
        {
            ProviderId = providerId;
            Name = name;
            Description = description;
            Tags = tags;
            PostDate = postDate;
            SearchRatingRatio = searchRatingRatio;
        }

    }
}
