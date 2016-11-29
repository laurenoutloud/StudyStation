using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyStation.Models
{
    public class User
    {
        public int ID { get; set; }
        public Settings UserSettings { get; set; }
        public List<Course> CourseList { get; set; }
    }

}