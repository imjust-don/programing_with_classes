using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        int x = 0;
        float average = 0;
        int count = 0;
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

        foreach (int i in user_number)
        {
            x = x + i;
            count = count + 1;

        }

        Console.WriteLine($"The sume of all your numbers is: {x}");
        Console.WriteLine($"The average is: {x/(count-1)}");
    }
}