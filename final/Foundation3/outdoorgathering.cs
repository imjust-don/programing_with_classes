class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string eventTitle, string eventDescription, DateTime eventDate, TimeSpan eventTime, Address eventAddress, string weatherForecast)
        : base("Outdoor Gathering", eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nWeather Forecast: {weatherForecast}";
    }
}