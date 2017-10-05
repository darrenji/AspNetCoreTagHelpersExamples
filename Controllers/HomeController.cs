using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreTagHelpersExamples.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreTagHelpersExamples.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;

        public HomeController(IRepository repo)
        {
            repository = repo;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(repository.Cites);
        }

        public ViewResult Edit() {
            ViewBag.Countries = new SelectList(repository.Cites.Select(c => c.Country).Distinct());
           return  View("Create", repository.Cites.First());
        }

        public ViewResult Create()
        {
            ViewBag.Countries = new SelectList(repository.Cites.Select(c => c.Country).Distinct());
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(City city)
        {
            repository.AddCity(city);
            return RedirectToAction("Index");
        }
    }
}
