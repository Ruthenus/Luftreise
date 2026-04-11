using Microsoft.AspNetCore.Mvc;
using Luftreise_Command_project_.Models;

namespace Luftreise_Command_project_.Controllers
{
    public class FlightsController : Controller
    {
        [HttpPost]
        public IActionResult Search(SearchModels model)
        {
            return View("Flights", model);
        }

        public IActionResult Details(int id)
        {
            return View();
        }
    }
}