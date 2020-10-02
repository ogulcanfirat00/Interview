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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                ApplicationDbContext.Products.Add(product);
                ApplicationDbContext.SaveChanges();
                return RedirectToAction("Product");
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult EditProduct(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var product = ApplicationDbContext.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                ApplicationDbContext.Products.Update(product);
                ApplicationDbContext.SaveChanges();
                return RedirectToAction("Product");
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult DeleteProduct(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var product = ApplicationDbContext.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteProductConfirmation(int? id)
        {
            var product = ApplicationDbContext.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            ApplicationDbContext.Products.Remove(product);
            ApplicationDbContext.SaveChanges();
            return RedirectToAction("Product");
        }


        
    }
}
