﻿namespace PracticeMVC.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Desigation { get; set; }
        public int Salary { get; set; }

    }

    public enum Gender { 
        Male, Female,
    }
}
