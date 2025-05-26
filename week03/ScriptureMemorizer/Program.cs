using System;
using System.IO;

Scripture scripture = LoadRandomScriptureFromFile("scriptures.txt");

while (!scripture.IsCompletelyHidden())
{
    Console.Clear();
    scripture.Display();

    Console.WriteLine("\nPress ENTER to hide more words or type 'quit' to end:");
    string input = Console.ReadLine();

    if (input.ToLower() == "quit")
        return;

    scripture.HideRandomWords();
}

Console.Clear();
scripture.Display();
Console.WriteLine("\nAll words are hidden. Program ended.");

Scripture LoadRandomScriptureFromFile(string filePath)
{
    var lines = File.ReadAllLines(filePath);
    var random = new Random();
    var randomLine = lines[random.Next(lines.Length)];

    string[] parts = randomLine.Split('|');
    string book = parts[0];
    int chapter = int.Parse(parts[1]);
    int startVerse = int.Parse(parts[2]);
    int endVerse = int.Parse(parts[3]);
    string text = parts[4];

    Reference reference = new Reference(book, chapter, startVerse, endVerse);
    Scripture scripture = new Scripture(reference, text);
    return scripture;
}
