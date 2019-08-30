using SameSystemDiffrentWeather.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SameSystemDiffrentWeather.Controllers
{
    public class ConcertController : Controller
    {
        Concert concert = new Concert {
            Name = "testData concert",
            Price = 1.00,
            Tickets = 10,
            City = "Someville",
            ConcertDate = DateTime.UtcNow
        };
        // GET: Concert
        public ActionResult Index()
        {
            return View(concert);
        }
        public ActionResult Edit()
        {
            return View(concert);
        }
    }
}