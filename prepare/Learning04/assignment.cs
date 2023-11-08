class Assingment 
{
    string _StudentName;
    string _Topic;

    public Assingment(string SutdentName, string Topic)
    {
        _StudentName = SutdentName;
        _Topic = Topic;

    }

   public string GetSummary()
    {
        return _StudentName + " - " + _Topic;
    }
}