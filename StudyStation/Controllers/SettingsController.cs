using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudyStation.Models;

namespace StudyStation.Controllers
{
    public class SettingsController : Controller
    {
        // GET: Settings
        public ActionResult Settings()
        {
            CreateUser();
            return View();
        }

        //CreateUser will create static user data for testing
        public void CreateUser()
        {
            User currentUser = new User();
            currentUser.ID = 123456;
            currentUser.FirstName = "Selena";
            currentUser.LastName = "Gomez";
            currentUser.Birthday = "01/01/1990";
            currentUser.PhoneNumber = "555-555-5555";
            currentUser.Email = "sgomez@internet.com";
            currentUser.Password = "password";
            ViewBag.CurrentUser = currentUser;

            return;

        }



    }
}