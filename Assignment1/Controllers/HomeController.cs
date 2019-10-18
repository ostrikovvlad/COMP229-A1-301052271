using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment1.Models;

namespace Assignment1.Controllers
{
    public class HomeController: Controller
    {
        public ViewResult Index()
        {
            ViewBag.Title = "Tasty Recipes";
            return View();
        }
        [HttpGet]
        public ViewResult AddRecipe()
        {
            ViewBag.Title = "Add Recipe";
            return View();
        }
        [HttpPost]
        public ViewResult AddRecipe(Recipe recipe)
        {
            Repository.AddRecipe(recipe);
            return View("RecipeList", Repository.Recipes);
        }
        [HttpGet]
        public ViewResult LeaveReview()
        {
            ViewBag.Title = "Leave a Review";
            return View();
        }
        [HttpPost]
        public ViewResult LeaveReview(Recipe recipe)
        {
            Repository.AddReview(recipe.Username, recipe.Comment);
            return View("ViewRecipe", Repository.Recipes);
        }

        public ViewResult RecipeList()
        {
            ViewBag.Title = "Recipe List";
            return View("RecipeList", Repository.Recipes);
        }
        public ViewResult ViewRecipe()
        {
            ViewBag.Title = "Potato perogies";
            return View("ViewRecipe", Repository.Recipes.Where(r => r.Title == ViewBag.Title));
        }
    }
}
