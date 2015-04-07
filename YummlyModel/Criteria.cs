using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YummlyModel
{
    public class Criteria
    {
        public int MaxResults { get; set; }
        public List<string> ExcludedIngredients { get; set; }
        public List<string> ExcludedAttributes { get; set; }
        public List<string> AllowedIngredients { get; set; }
        public List<string> AllowedAttributes { get; set; }
        public List<string> Terms { get; set; }
        public int ResultsToSkip { get; set; }
        public bool RequirePictures { get; set; }
        public List<string> AllowedDiets { get; set; }

    }
}

        
        //"attributeRanges": {
        //    "flavor-piquant": {
        //        "min": 0.3333333333333333,
        //        "max": 1
        //    }
        //},
        //"nutritionRestrictions": {
        //    "FAT": {
        //        "min": 0,
        //        "max": 8
        //    }
        //},
        //"facetFields": [],

