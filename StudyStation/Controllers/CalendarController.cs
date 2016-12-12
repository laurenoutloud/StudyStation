using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudyStation.Models; //Include the models to better organize generated data

//Calendar Controller will contain the functionality of the calendar when I incorportate it

namespace StudyStation.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        public ActionResult Calendar()
        {
            return View(); //open calendar view
        }
    }
}

//TODO: figure out how to use JS plugin or other method to incorporate calendar into application