using System.Runtime.InteropServices;
using System.Xml.XPath;

class Scripture
{
    List<string> _Versus = new List<string>();
    Reference _reference;

    public Scripture(List<string> Versus, Reference reference)
    {
        _Versus = Versus;
        _reference = reference;
    }

    public void AddVerse(string verse)
    {
        _Versus.Add(verse);
    }

    public string GetVersus()
    {
        return string.Join(Environment.NewLine, _Versus);
    }

    public List<string> ReturnList()
    {
        return _Versus;
    }
    public void Display()
    {
        Console.WriteLine($"{_reference.GetReference()} {GetVersus()}");
    }
}