using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} Activity ---\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("Enter the duration in seconds: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int time) && time > 0)
        {
            _duration = time;
        }
        else
        {
            Console.WriteLine("Invalid input. Using default duration of 30 seconds.");
            _duration = 30;
        }

        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nGreat job! You completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
            i++;
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }
        Console.Write("\r   \r"); // Clear countdown
    }
}
