using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudyStation.Models; //Include models to organize generated data

namespace StudyStation.Controllers
{
    public class StudyController : Controller
    {
        // GET: Study
        public ActionResult Study()
        {
            return View(); //open study view
        }
    }
}
