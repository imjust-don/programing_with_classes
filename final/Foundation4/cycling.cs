class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int durationMinutes, double speed)
        : base(date, durationMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return speed > 0 ? 60 / speed : 0;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling - Speed: {speed} kph, Pace: {GetPace()} min per km";
    }
}