using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ParkVac.Models;

namespace ParkVac.Controllers
{
    public class CarparksController : Controller
    {
        // GET: Carparks
        public ActionResult Random()
        {
            var carpark = new Carpark() { Name = "HP" };
            return View(carpark);
        }
    }
}