// See https://aka.ms/new-console-template for more information
using System.Security.Claims;


// //Your program must demonstrate the four pillars of OOP

// encapsulation, abstraction, inheritance, and polymorphism.

// logic instructions:
// 1.the menu: create a loop(while or do while) ThreadStaticAttribute allows user to:
// 1add student(Promptfor Id, name age course and tuition)
// 2 add instructor prompt for id name age department and salary
// 3 display all: show all formatted list of everyone in the system
// 4. exit terminate the program clearly

// 2. the output ensure your output is ClaimsIdentity use console.clear()to keep the menu readable


using System;
using System.Collections.Generic;

class Program
{
    static List<Person> people = new List<Person>();

    static void Main()
    {
        int choice;

        do
        {
            Console.Clear();
            Console.WriteLine("===== SCHOOL MANAGEMENT SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Instructor");
            Console.WriteLine("3. Display All");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;

                case 2:
                    AddInstructor();
                    break;

                case 3:
                    DisplayAll.Show(people);
                    break;

                case 4:
                    Console.WriteLine("Program terminated.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

        } while (choice != 4);
    }

    static void AddStudent()
    {
        Console.Clear();
        Console.WriteLine("ADD STUDENT");

        Console.Write("ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Course: ");
        string course = Console.ReadLine();

        Console.Write("Tuition Fee: ");
        double tuition = Convert.ToDouble(Console.ReadLine());

        Student s = new Student(id, name, age, course, tuition);
        people.Add(s);

        Console.WriteLine("Student added successfully.");
    }

    static void AddInstructor()
    {
        Console.Clear();
        Console.WriteLine("ADD INSTRUCTOR");

        Console.Write("ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Department: ");
        string dept = Console.ReadLine();

        Console.Write("Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Instructor i = new Instructor(id, name, age, dept, salary);
        people.Add(i);

        Console.WriteLine("Instructor added successfully.");
    }
}