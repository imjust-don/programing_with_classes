// See https://aka.ms/new-console-template for more informati
using System;
using System.Threading;

// Base class for all activities
public abstract class MindfulnessActivity
{
    protected int Duration;

    public MindfulnessActivity(int duration)
    {
        Duration = duration;
    }

    // Common starting message for all activities
    protected void StartActivity(string activityName, string description)
    {
        Console.WriteLine($"{activityName} - {description}");
        Console.WriteLine($"Set the duration for {Duration} seconds.");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    // Common ending message for all activities
    protected void EndActivity(string activityName)
    {
        Console.WriteLine($"Good job! You have completed the {activityName} activity for {Duration} seconds.");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    // Abstract method to be implemented by derived classes
    public abstract void DoActivity();
}

// Breathing activity
public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration) { }

    public override void DoActivity()
    {
        StartActivity("Breathing Activity", "Helps you relax by guiding you through deep breathing.");

        for (int i = 0; i < Duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000); // Pause for 1 second
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000); // Pause for 1 second
        }

        EndActivity("Breathing Activity");
    }
}

// Reflection activity
public class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int duration) : base(duration) { }

    public override void DoActivity()
    {
        StartActivity("Reflection Activity", "Helps you reflect on times when you've shown strength and resilience.");

        Random random = new Random();

        for (int i = 0; i < Duration; i++)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);

            foreach (var question in reflectionQuestions)
            {
                Console.WriteLine(question);
                Thread.Sleep(2000); // Pause for 2 seconds
            }

            Thread.Sleep(3000); // Pause for 3 seconds
        }

        EndActivity("Reflection Activity");
    }
}

// Listing activity
public class ListingActivity : MindfulnessActivity
{
    private string[] listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration) { }

    public override void DoActivity()
    {
        StartActivity("Listing Activity", "Helps you reflect on the good things in your life by listing items.");

        Random random = new Random();
        string prompt = listingPrompts[random.Next(listingPrompts.Length)];

        Console.WriteLine(prompt);
        Thread.Sleep(3000); // Pause for 3 seconds

        Console.WriteLine("Start listing items...");

        for (int i = 1; i <= Duration; i++)
        {
            Console.WriteLine($"Item {i}");
            Thread.Sleep(1000); // Pause for 1 second
        }

        Console.WriteLine($"Number of items listed: {Duration}");

        EndActivity("Listing Activity");
    }
}

class Program
{
    static void Main()
    {
        // Example usage
        MindfulnessActivity breathingActivity = new BreathingActivity(5);
        breathingActivity.DoActivity();

        MindfulnessActivity reflectionActivity = new ReflectionActivity(3);
        reflectionActivity.DoActivity();

        MindfulnessActivity listingActivity = new ListingActivity(4);
        listingActivity.DoActivity();
    }
}

