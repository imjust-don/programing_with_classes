class Reference
{
    string _book;
    string _Chapter;
    string _StartVerse;
    string _EndVerse;


    public Reference(string book, string Chapter, string StartVerse, string EndVerse)
    {
        _book = book;
        _Chapter = Chapter;
        _StartVerse = StartVerse;
        _EndVerse = EndVerse;
    }

    public string GetReference()
    {
        if (_StartVerse == _EndVerse)
        {
            return $"{_book} {_Chapter}:{_StartVerse}";
        }
        else
        {
            return $"{_book} {_Chapter}:{_StartVerse}-{_EndVerse}";
        }
    }
}