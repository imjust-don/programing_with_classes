class Assingment 
{
    string _StudentName;
    string _Topic;

    public Assingment(string SutdentName, string Topic)
    {
        _StudentName = SutdentName;
        _Topic = Topic;

    }

    string GetSummary(string _StudentName, string _Topic)
    {
        return $"{_StudentName}, {_Topic}";
    }
}