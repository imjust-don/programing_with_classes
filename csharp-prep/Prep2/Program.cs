using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade.");
        string gradeinput = Console.ReadLine();
        int grade = int.Parse(gradeinput);

        if (grade >= 90)
        {
            Console.WriteLine("You have an A");
        }
        else if (grade < 90 && grade >= 80)
        {
            Console.WriteLine("You have a B");
        }
        else if (grade < 80 && grade >= 70)
        {
            Console.WriteLine("You have a C");
        }
        else if (grade < 70 && grade >= 60)
        {
            Console.WriteLine("You have a D");
        }
        else if (grade < 60)
        {
            Console.WriteLine("You have an F");
        }


    }
}