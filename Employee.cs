using System;

namespace Classes
{
    public class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }


    }

    class Employees
    {
        Employee joey = new Employee()
        {
            FirstName = "Joey",
            LastName = "Tribbiani",
            Title = "Chief Medical Officer",
            StartDate = 4 / 23 / 18
        };

    }

}