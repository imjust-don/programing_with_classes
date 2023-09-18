using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the number guesser");
        Console.WriteLine("Im thinking a number guess what I'm thinking 1-10");

        string guess = "0";

        do
        {
            Console.Write("What is your Guess? ");
            guess = Console.ReadLine();
            
        }while (guess != "7");

        Console.WriteLine($"Congrats! The number was {guess}!");
    }
}