using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class Hide
{
    List<string> _HiddenWords = new List<string>();
    int _count;

    int _runtime = 0;

    string _choice;

    Random _random = new Random();

    bool _going = true;


    public Hide(string words, string reference)
    {
       string[] wordstoadd = words.Split(" ");

       foreach(string word in wordstoadd)
       {
            _HiddenWords.Add(word);
            _count+=1;
       }

        do
        {

            Console.WriteLine(reference);
            // Console.WriteLine(string.Join(Environment.NewLine, _HiddenWords));
            foreach (var word in _HiddenWords)
            {
             Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type quit to quit");
            string quit = Console.ReadLine();
            if (quit.ToLower() == "quit")
            {
                goto Stop;
            }
            else
            {
                // Start:
                bool AllLetters = true;
                 int _RandomNumber = _random.Next(0, _HiddenWords.Count());

                AllLetters = true;

                

                foreach(char letter in _HiddenWords[_RandomNumber])
                {
                    if (!char.IsLetter(letter) && !char.IsPunctuation(letter))
                    {
                        AllLetters = false;
                        break;
                    }

                }

                if (AllLetters)
                {
                    string _ = new string('_', _HiddenWords[_RandomNumber].Length);
                    _HiddenWords[_RandomNumber] = _;
                    Console.Clear();
                    _runtime += 1; 
                }

                else
                {
                    _runtime = _runtime - 1;
                    // goto Start;
                }
            }
foreach (string verse in _HiddenWords)
{
    bool containsAlphaNumeric = false;

    foreach (char letter in verse)
    {
        if (char.IsLetterOrDigit(letter) || char.IsPunctuation(letter))
        {
            containsAlphaNumeric = true;
            break;
        }
    }

    if (!containsAlphaNumeric)
    {
        _going = false;
        break;
    }
}


        } 
        while(_HiddenWords.Any(word => word.Any(char.IsLetter)));

        Stop:

        Console.WriteLine("You have now exited");

    }



}