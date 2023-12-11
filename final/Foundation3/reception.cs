class Reception : Event
{
    private string rsvpEmail;

    public Reception(string eventTitle, string eventDescription, DateTime eventDate, TimeSpan eventTime, Address eventAddress, string rsvpEmail)
        : base("Reception", eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nRSVP Email: {rsvpEmail}";
    }
}