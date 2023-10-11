public class Book
{
    private string _author;
    private string _name;
    private int _TimesRead;
    private bool _Available = true;
public Book(string name, string author)
{
    _name = name;
    _author = author;
    _TimesRead = 0;
}

public void Display()
{
    Console.WriteLine($"Name: {_name} Author: {_author} Available: {_Available}");
}

public int TimesRead()
{
    return _TimesRead;
}

public void Checkout()
{
    _TimesRead += 1;
    _Available = false;
}

public void Checkin()
{
    _Available = false;
}

public bool HasAuthor(string author)
{
    return _author.Contains(author);
}

}

