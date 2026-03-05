using System;

public class Student : Person
{
    public string Course { get; set; }
    public double Tuition { get; set; }

    public Student(int id, string name, int age, string course, double tuition)
        : base(id, name, age)
    {
        Course = course;
        Tuition = tuition;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"[STUDENT] ID:{Id} Name:{Name} Age:{Age} Course:{Course} Tuition:{Tuition}");
    }
}