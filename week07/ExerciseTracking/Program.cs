using System;
using System.Collections.Generic;
using ExerciseTracking;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            activities.Add(new Running("17 Jun 2025", 30, 4.8));
            activities.Add(new Cycling("17 Jun 2025", 45, 15.0));
            activities.Add(new Swimming("17 Jun 2025", 40, 30));

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
