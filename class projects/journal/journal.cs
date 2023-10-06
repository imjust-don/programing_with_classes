public class Journal
{
    List<string> _entries = new List<string>();


    public void AddEntry(string EntryToAdd)
    {
        _entries.Add(EntryToAdd);
    }

    public void SaveJournal(string FileName)
    {
        foreach (string line in _entries)
        {
        File.AppendAllText(FileName, line);
        }
        Console.WriteLine($"{FileName} was saved Successfully");
    }

     public void Display()
    {
        foreach (string line in _entries)
        {
        Console.WriteLine(line);
        }
    }

    public void LoadJournal(string FileName)
    {
        string[] lines = System.IO.File.ReadAllLines(FileName);
        foreach (string line in lines)
        {
            _entries.Add(line);
        }
        Console.WriteLine($"{FileName} imported correctly");
    }

}

