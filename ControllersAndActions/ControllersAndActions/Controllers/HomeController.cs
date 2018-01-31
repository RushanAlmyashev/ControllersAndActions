using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("SimpleForm");
        }

        public ViewResult ReceiveForm(string name, string city)
        {
            return View("Result", $"{name} lives in {city}");
        }
    }
}