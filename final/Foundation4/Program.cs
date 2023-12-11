using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
       var runningActivity = new Running(DateTime.Now.AddDays(-3), 30, 3.0);
        var cyclingActivity = new Cycling(DateTime.Now.AddDays(-2), 45, 20);
        var swimmingActivity = new Swimming(DateTime.Now.AddDays(-1), 60, 40);

        // Put activities in the same list
        var activities = new List<Activity> { runningActivity, cyclingActivity, swimmingActivity };

        // Display summaries for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}