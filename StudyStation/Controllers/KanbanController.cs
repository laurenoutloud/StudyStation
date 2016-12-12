using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudyStation.Models; //Include models to organize generated data

namespace StudyStation.Controllers
{
    public class KanbanController : Controller
    {
        // GET: Kanban
        public ActionResult Kanban()
        {
            CreateUser(); //call CreateUser method to temporarily generate static data
            return View(); //open kanban view
        }

        public void CreateUser() //CreateUser function is a temporary function that creates static data for testing
                                 //TODO: learn how to integrate application with a data base so I no longer need this function
        {
            User currentUser = new User(); //create a User object using the User model
            currentUser.ID = 123456; //assign static fake id for testing
            currentUser.FirstName = "Adam"; //assign static fake first name for testing
            currentUser.LastName = "Clark"; //assign static fake last name for testing
            currentUser.Birthday = "01/01/1990"; //assign static fake birthday for testing
            currentUser.PhoneNumber = "555-555-5555"; //assign static fake phone number for testing
            currentUser.Email = "aclark@internet.com"; //assign static fake email for testing
            currentUser.Password = "password"; //assign static fake password for testing

            currentUser.Courses = new List<Course>() { //create list of Course objects to hold multiple courses
                new Course() { //create a course object using the Course model
                    CourseName ="English", //assign static fake course name for testing
                    Tasks = new List<Task>() //create a list of tasks so that each course can have multiple tasks
                    {
                        new Task() //create a new task object using the Task model
                        {
                            Text = "Write Essay", //assign task text that will be displayed
                            Status = 1 //assign status (1= To Do, 2= Doing, 3= Done)

                        },
                        new Task() //create a new task object using the Task model
                        {
                            Text = "Read Chapter 5", //assign task text that will be displayed
                            Status = 3 //assign status (1= To Do, 2= Doing, 3= Done)
                        }
                    }
                },

                new Course() {
                    CourseName ="Calculus",//assign static fake course name for testing
                    Tasks = new List<Task>()//create a list of tasks so that each course can have multiple tasks
                    {
                        new Task()//create a new task object using the Task model
                        {
                            Text = "Lesson 14 Homework Problems",//assign task text that will be displayed
                            Status = 2
                        },
                        new Task()//create a new task object using the Task model
                        {
                            Text = "Memorize formulas",//assign task text that will be displayed
                            Status = 2 //assign status (1= To Do, 2= Doing, 3= Done)
                        }
                    }
                },

                new Course() {
                    CourseName ="Spanish",//assign static fake course name for testing
                    Tasks = new List<Task>()//create a list of tasks so that each course can have multiple tasks
                    {
                        new Task()//create a new task object using the Task model
                        {
                            Text = "Memorize Chapter 6 Vocabulary",//assign task text that will be displayed
                            Status = 2 //assign status (1= To Do, 2= Doing, 3= Done)
                        },
                        new Task()//create a new task object using the Task model
                        {
                            Text = "Chapter 6 Grammar Homework",//assign task text that will be displayed
                            Status = 3 //assign status (1= To Do, 2= Doing, 3= Done)
                        }
                    }
                }
            };

            ViewBag.CurrentUser = currentUser; //add the temporary fake static data to the viewbag so that it can be accessed from the view

            return;

        }
    }
}