using System;
using System.Collections.Generic;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public DateTime StartDate;
    public Employee (string name, string date)
    {
        StartDate = DateTime.Parse(date);
    }
}