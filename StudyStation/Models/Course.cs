using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyStation.Models
{
    public class Course //the course model serves as a template for course data. Each course will have a course name and a list of tasks
    {
        public string CourseName; //course name that will be used throughout the application
        public List<Task> Tasks; //a list of task objects so each individual course can be assigned multiple tasks
    }
}