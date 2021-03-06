﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstLook.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string  Address { get; set; }
        public decimal Salary { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string WebAddress { get; set; }
    }
}