using Luftreise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Luftreise.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Details(int id)
        {
            return View();
        }

    }
}
