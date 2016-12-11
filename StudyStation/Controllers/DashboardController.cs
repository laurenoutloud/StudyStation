using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudyStation.Models;

namespace StudyStation.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Dashboard()
        {
            CreateUser();
            return View();
        }

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

            currentUser.Courses = new List<Course>() {
                new Course() {
                    CourseName ="English",
                    Tasks = new List<Task>()
                    {
                        new Task()
                        {
                            Text = "Write Essay",
                            Status = 1

                        },
                        new Task()
                        {
                            Text = "Read Chapter 5",
                            Status = 3
                        }
                    }
                },

                new Course() {
                    CourseName ="Calculus",
                    Tasks = new List<Task>()
                    {
                        new Task()
                        {
                            Text = "Lesson 14 Homework Problems",
                            Status = 2
                        },
                        new Task()
                        {
                            Text = "Memorize formulas",
                            Status = 2
                        }
                    }
                },

                new Course() {
                    CourseName ="Spanish",
                    Tasks = new List<Task>()
                    {
                        new Task()
                        {
                            Text = "Memorize Chapter 6 Vocabulary",
                            Status = 2
                        },
                        new Task()
                        {
                            Text = "Chapter 6 Grammar Homework",
                            Status = 3
                        }
                    }
                }
            };


            ViewBag.CurrentUser = currentUser;

            return;

        }
    }


}