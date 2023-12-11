class Activity
{
    private DateTime date;
    protected int durationMinutes;  // Change the access modifier to protected

    public Activity(DateTime date, int durationMinutes)
    {
        this.date = date;
        this.durationMinutes = durationMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Base class has no distance calculation
    }

    public virtual double GetSpeed()
    {
        return 0; // Base class has no speed calculation
    }

    public virtual double GetPace()
    {
        return 0; // Base class has no pace calculation
    }

    public virtual string GetSummary()
    {
        return $"{date.ToShortDateString()} - Unknown Activity ({durationMinutes} min)";
    }
}