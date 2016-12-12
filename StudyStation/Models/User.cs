using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyStation.Models
{
    public class User //User model serves as a template for storing are information pertaining to each individual user, to include their desired settings
    {
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //information pertaining to a user's desired study settings
        public int IntervalLength { get; set; } //the length of each study interval
        public int ShortBreakLength { get; set; } //the length of each short break
        public int LongBreakLength { get; set; } //the length of each long break
        public int LongBreakAfter { get; set; } //number of intervals to be completed before a long break is granted
        public int DailyIntervalGoal { get; set; } //the goal number of daily intervals the user would like to achieve

        public List<Course> Courses { get; set; } //a list of Course objects to allow a user to have various number of courses
    }

}