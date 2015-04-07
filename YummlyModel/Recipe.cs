using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YummlyModel
{
    public class Recipe
    {
        public List<List<string>> Attributes { get; set; }
        public Dictionary<string, double> Flavors { get; set; }
        public double Rating { get; set; }
        public string Id { get; set; }
        public List<string> SmallImageUrls { get; set; }
        public int TotalTimeInSeconds { get; set; }
        public string SourceDisplayName { get; set; }
        public string List<string> Ingredients { get; set; }
        public string RecipeName { get; set; }
    }
}
