using System;

class Program
{
    static void Main(string[] args)
    {
        Assingment a1 = new Assingment("Jake", "Math");
        Console.WriteLine(a1.GetSummary());
        
        Math m1 = new Math("James", "Math", "9.1", "12 - 29");

        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomework());

        Writing w1 = new Writing("Jacob", "History", "The meaning behind war? Idk");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInfo());
    }


}