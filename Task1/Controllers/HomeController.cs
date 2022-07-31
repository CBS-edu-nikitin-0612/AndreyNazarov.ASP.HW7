using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string first, string second, int count)
        {
            Debug.WriteLine($"first: {first}, second: {second}, number: {count}");
            return RedirectToAction("Index", "Home");
        }
    }
}
