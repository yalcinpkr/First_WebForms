﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstWebForm.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName {get;set;}
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }

    }
}