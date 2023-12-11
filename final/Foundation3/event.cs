class Event
{
    private string eventType;
    private string eventTitle;
    private string eventDescription;
    private DateTime eventDate;
    private TimeSpan eventTime;
    private Address eventAddress;

    public Event(string eventType, string eventTitle, string eventDescription, DateTime eventDate, TimeSpan eventTime, Address eventAddress)
    {
        this.eventType = eventType;
        this.eventTitle = eventTitle;
        this.eventDescription = eventDescription;
        this.eventDate = eventDate;
        this.eventTime = eventTime;
        this.eventAddress = eventAddress;
    }

    public string GetStandardDetails()
    {
        return $"Event Type: {eventType}\nTitle: {eventTitle}\nDescription: {eventDescription}\nDate: {eventDate.ToShortDateString()}\nTime: {eventTime}\nAddress: {eventAddress.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Type: {eventType}\nTitle: {eventTitle}\nDate: {eventDate.ToShortDateString()}";
    }
}
