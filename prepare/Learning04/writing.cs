class Writing : Assingment
{
    string _Title;
    
    public Writing(string SutdentName, string Topic, string Title) : base(SutdentName, Topic)
    {
        _Title = Title;
    }

    public string GetWritingInfo()
    {
        return _Title;
    } 
}