using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyStation.Models
{
    public class Task //the task model serves as a template for all of the tasks
    {
        public int Status { get; set; } //each task will be assigned a number based on its status: 1= To Do, 2= Doing, 3=Done
        public string Text { get; set; } //the text allows users to write the task details that will be displayed
        //public string DateCreated { get; set; } //date created will be utilized when calendar functionality is implemented
        //public string DateCompleted { get; set; } //date completed will be utilized once calendar functionality is implemented

    }
}