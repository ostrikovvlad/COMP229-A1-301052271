using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class ViewModel
    {
        public IEnumerable<List<Recipe>> Recipes { get; set; }
        public IEnumerable<List<Review>> Reviews { get; set; }
    }
}
