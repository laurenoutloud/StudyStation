using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyStation.Models
{
    public class User
    {
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int IntervalLength { get; set; }
        public int ShortBreakLength { get; set; }
        public int LongBreakLength { get; set; }
        public int LongBreakAfter { get; set; }
        public int DailyIntervalGoal { get; set; }

        public List<Course> Courses { get; set; }
    }

}