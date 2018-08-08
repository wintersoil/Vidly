using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Samantha Juniper" , Id = 1},
                new Customer { Name = "Casper Silanto", Id = 2 },
                new Customer { Name = "Benedict Denito", Id = 3 },
                new Customer { Name = "Eric Goswall", Id = 4 },
                new Customer { Name = "Derrick Jonathan", Id = 5 }
            };
            var viewModel = new RandomCustomersViewModel
            {
                customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {

            var customers = new List<Customer>
            {
                new Customer { Name = "Samantha Juniper" , Id = 1},
                new Customer { Name = "Casper Silanto", Id = 2 },
                new Customer { Name = "Benedict Denito", Id = 3 },
                new Customer { Name = "Eric Goswall", Id = 4 },
                new Customer { Name = "Derrick Jonathan", Id = 5 }
            };
            var viewModel = new RandomCustomersViewModel
            {
                customers = customers
            };
            //return Content(viewModel.customers[id-1].Name);
            return View(viewModel.customers[id-1]);
        }
    }
}
