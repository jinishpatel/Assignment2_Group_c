using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]

        public IActionResult Index()
        {
            ViewBag.BmiValue = 0;

            return View();
        }
        [HttpPost]

        public IActionResult Index(Jinish_Assignement1 model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.BMI_236 = model.CalculateBMI();
            }
            else
            {
                ViewBag.BmiValue = 0;
            }
            return View(model);
        }

    }
}