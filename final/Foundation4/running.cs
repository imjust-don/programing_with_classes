using System;
using System.Collections.Generic;

class Running : Activity
{
    private double distance;

    public Running(DateTime date, int durationMinutes, double distance)
        : base(date, durationMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance > 0 ? (distance / durationMinutes) * 60 : 0;
    }

    public override double GetPace()
    {
        return distance > 0 ? durationMinutes / distance : 0;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running - Distance: {distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}