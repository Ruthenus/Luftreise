using Luftreise_Command_project_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Luftreise_Command_project_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Search(SearchModels model)
        {
            return Content($"From: {model.From}, To {model.To}, Date: {model.FlightDate}");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
