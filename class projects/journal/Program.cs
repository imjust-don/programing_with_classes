// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

int x = 0;
Journal Journal = new Journal();

Console.WriteLine("Welcome to your Journal!");
do
{
    Console.WriteLine($@"----------------------------------
Please select an option from below
1. Write
2. Display
3. Load
4. Save
5. Quit
----------------------------------");

x = int.Parse(Console.ReadLine());

if (x == 1)
{
Prompt Prompt = new Prompt();
string ChosenPrompt = Prompt.PromptChooser();

Console.WriteLine(ChosenPrompt);
string entry = Console.ReadLine();

Entry NewEntry = new Entry(ChosenPrompt, entry);
Journal.AddEntry(NewEntry.ReturnedEntry());
}

else if (x == 2)
{
    Journal.Display();
}

else if (x == 3)
{
    Console.WriteLine("Please enter the desired file you'd like to load");
    Journal.LoadJournal(Console.ReadLine());
}

else if (x == 4)
{
    Console.WriteLine("Please enter your desired filename");
    Journal.SaveJournal(Console.ReadLine());
}

else if (x == 5)
{
    Console.WriteLine("Goodbye");
}

else
{
    x = 0;
}

}
while (x != 5);
