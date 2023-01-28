/* Author: Anthony Perez
 * Course: COMP-003A
 * Purpose: Replicate Output
 */

using System;
using static System.Collections.Specialized.BitVector32;

namespace COMP003A.Assignment2;

class Program
{
    static void Main(string[] args)
    {
        // Console Section

        Console.Title = "COMP-003A - Assignment 2 ";
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;

        // String Section
        Console.WriteLine("**************************************************");
        Console.WriteLine("String Section");
        Console.WriteLine("**************************************************");

        string? firstName;
        Console.WriteLine("Enter First Name: "); firstName = Console.ReadLine();

        string? middleName;
        Console.WriteLine("Enter Middle Name "); middleName = Console.ReadLine();

        string? lastName;
        Console.WriteLine("Enter Last Name? "); lastName = Console.ReadLine();

        string? inputAge;
        Console.WriteLine("Enter age in 2023? "); inputAge = Console.ReadLine();

        int yearBorn = 2023 - Convert.ToInt32(inputAge);

        Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");

        // Math Section
        Console.WriteLine("**************************************************");
        Console.WriteLine("Math Section");
        Console.WriteLine("**************************************************");


        int integer1;

        Console.WriteLine("Enter an integer for integer 1: "); var input = Console.ReadLine();
        
        integer1 = Convert.ToInt32(input);

        int integer2;

        Console.WriteLine("Enter an integer for integer 2: "); var input2 = Console.ReadLine();

        integer2 = Convert.ToInt32(input2);
        

        Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");

        Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");

        Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");

        Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");

        Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");


        // Circle Area and Circumference Calculator Section
        Console.WriteLine("**************************************************");
        Console.WriteLine("Circle Area and Circumference Calculator Section");
        Console.WriteLine("**************************************************");

        Console.Write("Enter Radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double Area = Math.PI * radius * radius;
        double circumference = 2 * Math.PI * radius;
        Console.WriteLine("The area is: " + Area);
        Console.WriteLine("The circumference is: " + circumference);
        Console.ReadKey();


    }
}

