using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Review
    {
        public string Name { get; set; }
        public string Comment { get; set; }
    }
    public class Recipe
    {
        private List<Review> review = new List<Review>();
        public List<Review> Review { get { return review; } set { review = value; } }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public string Instruction { get; set; }
        public string Username { get; set; }
        public string Comment{ get; set; }
        

    }
}
