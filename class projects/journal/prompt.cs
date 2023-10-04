using System;
using System.Collections.Generic;
using System.IO;
public class Prompt
{
    private List<string> _promptlist = new List<string>();
    public string _prompt = "";


    public string PromptChooser()
    {
        string[] lines = System.IO.File.ReadAllLines("prompts.txt");

        foreach (string line in lines)
        {
            _promptlist.Add(line);
        }

        Random random = new Random();
            
        int choice = random.Next(0, _promptlist.Count);

        string prompt = _promptlist[choice];

        _prompt = prompt;

        return prompt;

    }

    public void Display()
    {
        Console.WriteLine(_prompt);
    }

}