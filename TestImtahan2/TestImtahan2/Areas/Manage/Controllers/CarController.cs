using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using TestImtahan2.DAL;
using TestImtahan2.Models;

namespace TestImtahan2.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class CarController : Controller
    {
        private AppDbContext _context { get; }
        public IWebHostEnvironment _env { get;}
        public CarController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Car car)
        {
            if (!ModelState.IsValid) return View();
            if(car == null) return View("Error");
            string fileName = Guid.NewGuid().ToString() + car.Image.FileName;
            using(FileStream fs = new FileStream(Path.Combine(_env.WebRootPath("assets/image" + fileName))))
            return RedirectToAction("Index");
        }
    }
}
