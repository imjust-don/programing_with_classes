class Math : Assingment
{
    string _TextbookSection;
    string _Problems;

    public Math( string SutdentName, string Topic, string TextbookSection, string Problems) : base(SutdentName, Topic)
    {
        _TextbookSection = TextbookSection;
        _Problems = Problems;
    }

    public string GetHomework()
    {
        return $"Section: {_TextbookSection} Problems: {_Problems} ";
    }
}