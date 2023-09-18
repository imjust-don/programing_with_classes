using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        List<int> user_number;
        user_number = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Please enter a number: ");
            string inpt = Console.ReadLine();
            number = int.Parse(inpt);
            user_number.Add(number);
        }while (number != 0);
    }
}