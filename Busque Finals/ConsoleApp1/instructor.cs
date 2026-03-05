using System;

public class Instructor : Person
{
    public string Department { get; set; }
    public double Salary { get; set; }

    public Instructor(int id, string name, int age, string department, double salary)
        : base(id, name, age)
    {
        Department = department;
        Salary = salary;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"[INSTRUCTOR] ID:{Id} Name:{Name} Age:{Age} Department:{Department} Salary:{Salary}");
    }
}