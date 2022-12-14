using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        public Company(string name, string time)
        {
            Name = name;
            CreatedOn = time;
            Employees = new List<Employee>();
        }
        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }

        public int Id { get; set; }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */

        public string CompanyInfo()
        {
            return $"{Name} {CreatedOn}";
        }
    }
}