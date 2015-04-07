using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YummlyModel
{
    public class SearchResults
    {
        public Attribution Attribution { get; set; }
        public int TotalMatchCount { get; set; }
        public List<Recipe> Matches { get; set; }
        public Criteria Criteria { get; set; }
    }
}
