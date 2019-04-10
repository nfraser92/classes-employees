using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {

        /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
        */
        Company NiallCompany = new Company ("Niall LLC", "01/01/2000");

        // Create three employees
        Employee Niall = new Employee("Niall", "01/01/2000")
        {
            FirstName = "Niall",
            LastName = "Fraser",
            Title = "Founder"
        };

        Employee Wyatt = new Employee("Wyatt", "09/05/2017")
        {
            FirstName = "Wyatt",
            LastName = "Fraser",
            Title = "Tea Boy"
        };

        Employee Simon = new Employee("Simon", "10/01/2018")
        {
            FirstName = "Simon",
            LastName = "Wilson",
            Title = "Driver"
        };

        // Assign the employees to the company
        NiallCompany.HireEmployee(Niall);
        NiallCompany.HireEmployee(Wyatt);
        NiallCompany.HireEmployee(Simon);

        // List Employees
        NiallCompany.ListEmployees();

        }
    }
}
