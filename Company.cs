using System;
using System.Collections.Generic;

public class Company
{

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a public property for holding a list of current employees
    public List<Employee> CurrentEmployees = new List<Employee>();

    // Create an instance of a company. Name it whatever you like.
    public Company (string name, string yearEst)
    {
        Name = name;
        CreatedOn = DateTime.Parse(yearEst);
    }

    public void HireEmployee(Employee employee)
    {
        CurrentEmployees.Add(employee);

    }

    /*
        Iterate the company's employee list and generate the
        simple report shown above
    */
    public void ListEmployees()
    {
        foreach (Employee employee in CurrentEmployees)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {Name} as {employee.Title} since {employee.StartDate}");
        }
    }
    }