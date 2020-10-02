using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewProject.Data;
using InterviewProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InterviewProject.Controllers
{
    public class CountryController : Controller
    {
        public readonly ApplicationDbContext ApplicationDbContext;

        public CountryController(ApplicationDbContext applicationDbContext)
        {
            ApplicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public IActionResult Country()
        {
            ViewBag.countries = ApplicationDbContext.Countries.ToList();
            return View();
        }

        [HttpGet]
        public JsonResult GetCity(int id)
        {
            List<City> cities = new List<City>();
            cities = ApplicationDbContext.Cities.Where(country => country.City_Id == id).ToList();
            cities.Insert(0, new City { City_Id = 0, City_Name = "Select City" });
            return Json(new SelectList(cities,"City_Id", "Name"));
        }
    }
}
