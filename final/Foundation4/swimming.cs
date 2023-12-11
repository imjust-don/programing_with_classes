using System;
using System.Collections.Generic;

class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000; // Convert meters to kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() > 0 ? (GetDistance() / durationMinutes) * 60 : 0;
    }

    public override double GetPace()
    {
        return GetDistance() > 0 ? durationMinutes / GetDistance() : 0;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}