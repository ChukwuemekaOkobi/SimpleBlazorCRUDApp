﻿using System;

namespace Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoUrl { get; set; }

        public Department Department { get; set; }
    }
}
