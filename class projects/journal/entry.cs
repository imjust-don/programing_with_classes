using System;
public class Entry
{
    private string _date;
    private string _prompt;
    private string _entry;

    public Entry( string prompt, string entry)
    {
        
        _date = DateTime.Now.ToString();
        _prompt = prompt;
        _entry = entry;

    }

    public string ReturnedEntry()
    {
        string CompletedEntry = $@"
{_date}
Prompt: {_prompt}
Entry: {_entry}";

        return CompletedEntry;
    }

}