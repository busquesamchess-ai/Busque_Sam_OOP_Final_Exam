using System;
using System.Collections.Generic;

public abstract class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public abstract void DisplayInfo();
}

public class DisplayAll
{
    public static void Show(List<Person> people)
    {
        Console.Clear();
        Console.WriteLine("===== LIST OF PEOPLE =====\n");

        if (people.Count == 0)
        {
            Console.WriteLine("No records found.");
            return;
        }

        foreach (Person p in people)
        {
            p.DisplayInfo(); // polymorphism
        }
    }
}