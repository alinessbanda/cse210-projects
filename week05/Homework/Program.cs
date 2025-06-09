using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Aliness Banda", "Science - Plant Life");

        string summary = myAssignment.GetSummary();
        Console.WriteLine(summary);

        MathAssignment math = new MathAssignment("Aliness Banda", "Fractions", "7.3", "20-21");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment("Aliness Banda", "African History", "The Impact of colonialism in Zambia");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());

    }
}