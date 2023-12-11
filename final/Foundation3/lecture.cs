class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string eventTitle, string eventDescription, DateTime eventDate, TimeSpan eventTime, Address eventAddress, string speaker, int capacity)
        : base("Lecture", eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}
