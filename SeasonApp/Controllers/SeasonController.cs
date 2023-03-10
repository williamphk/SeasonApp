using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeasonApp.Models;

namespace SeasonApp.Controllers
{
    public class SeasonController : Controller
    {
        // GET: /Season/Index
        public ActionResult Index()
        {
            return View();
        }

        //POST: /Season/Show
        // Acquire information about the season and send it to Show.cshtml
        [HttpPost]
        public ActionResult Show(int? temperature) 
        {
            if (temperature == null) ViewBag.Temp = "unknown";
            else ViewBag.Temp = temperature;

            //we will to gather the season informatino from the temperature provided
            SeasonAPIController controller = new SeasonAPIController();
            Season SeasonInfo = controller.GetSeason(temperature);

            return View(SeasonInfo);
        }
    }
}