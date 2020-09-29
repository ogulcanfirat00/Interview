using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewProject.Data;
using InterviewProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace InterviewProject.Controllers
{
    public class ProductController : Controller
    {
        public readonly ApplicationDbContext ApplicationDbContext;

        public ProductController(ApplicationDbContext applicationDbContext)
        {
            ApplicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public IActionResult Product()
        {
            IEnumerable<Product> products = ApplicationDbContext.Products;

            return View(products);
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

       


    }
}
