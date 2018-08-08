using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {


        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie { Name = "Shrek" },
                new Movie { Name = "Wall-e" },
                new Movie { Name = "Godzilla" },
                new Movie { Name = "Inception" },
                new Movie { Name = "Black Hawk Down" }
            };
            var viewModel = new RandomMoviesViewModel
            {
                movies = movies
            };

            return View(viewModel);
        }

    }
}
