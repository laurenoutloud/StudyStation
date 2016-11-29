using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyStation.Models
{
    public class Task
    {
        public int Status { get; set; }
        public string Text { get; set; }
        public string DateCreated { get; set; }
        public string DateCompleted { get; set; }

    }
}