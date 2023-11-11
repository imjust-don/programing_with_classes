using System;

public class Hide
{
    List<string> _HiddenWords = new List<string>();
    int _count;

    int _runtime = 0;

    string _choice;

    Random _random = new Random();


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
            Console.WriteLine(string.Join(Environment.NewLine, _HiddenWords));
            Console.WriteLine("Press enter to continue or type quit to quit");
            string quit = Console.ReadLine();
            if (quit.ToLower() == "quit")
            {
                _runtime = _count;
            }
            else
            {
                int _RandomNumber = _random.Next(0, _HiddenWords.Count());

                bool AllLetters = true;

                foreach(char letter in _HiddenWords[_RandomNumber])
                {
                    if (!char.IsLetter(letter))
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
                }

                else
                {
                    
                }

                _runtime += 1;
            }

            
        } 
        while ( _runtime != _count);

    }



}