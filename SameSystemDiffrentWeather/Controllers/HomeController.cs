using SameSystemDiffrentWeather.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SameSystemDiffrentWeather.Controllers
{
    public class HomeController : Controller
    {
        // Home
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [MyLoggingFilter]

        public ActionResult Contact()
        {
            ViewBag.Message = "What do you think?";

            return View();
        }
        [HttpPost]
        public ActionResult  Contact(string message)
        {
            // TODO Save this and act on it
            ViewBag.Message = "Thanks for the feedback";
            return PartialView("_ThanksForFeedback");
        }
        //[Authorize (Users ="Brandon,Andrew")]
        public ActionResult Weather(string secret, string format)
        {
            //if (secret != "brandondoesnotwanttobemyfriendanymore")
            //{
            //    return new HttpStatusCodeResult(403);
            //}
            if (format == "text")
                return Content("You Rock");
            else if (format == "json")
                return Json(new {expires = DateTime.UtcNow.ToShortDateString(), password="youRock" },
                    JsonRequestBehavior.AllowGet );
            else if (format == "clean")
                return PartialView();
            return View();
        }
    }
}