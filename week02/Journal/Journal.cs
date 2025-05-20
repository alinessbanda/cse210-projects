using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
                Console.WriteLine();
            }
        }
    }

    public void WriteToFile()
    {
        Console.Write("Enter filename to save (e.g., journal.csv): ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine("Date,Prompt,Entry"); // CSV header

            foreach (Entry entry in _entries)
            {
                string date = entry.Date.Replace(",", ""); // remove commas from date
                string prompt = EscapeCsv(entry.Prompt);
                string text = EscapeCsv(entry.EntryText);

                writer.WriteLine($"{date},{prompt},{text}");
            }
        }

        Console.WriteLine("Journal saved to CSV.");
    }

    public void ReadFromFile()
    {
        Console.Write("Enter filename to load (e.g., journal.csv): ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(fileName);

        for (int i = 1; i < lines.Length; i++) // skip header
        {
            string[] parts = SplitCsvLine(lines[i]);

            if (parts.Length >= 3)
            {
                string date = parts[0];
                string prompt = parts[1];
                string text = parts[2];

                if (!string.IsNullOrWhiteSpace(date) && !string.IsNullOrWhiteSpace(prompt))
                {
                    Entry entry = new Entry(prompt, text, date);
                    _entries.Add(entry);
                }
            }
        }

        Console.WriteLine("Journal loaded from CSV.");
    }

    // Escapes commas and quotes for CSV format
    private string EscapeCsv(string value)
    {
        if (value.Contains(",") || value.Contains("\""))
        {
            value = value.Replace("\"", "\"\""); // escape quotes
            return $"\"{value}\"";
        }
        return value;
    }

    // Handles splitting a CSV line with quotes
    private string[] SplitCsvLine(string line)
    {
        var result = new List<string>();
        bool inQuotes = false;
        string current = "";

        foreach (char c in line)
        {
            if (c == '"' && !inQuotes)
            {
                inQuotes = true;
            }
            else if (c == '"' && inQuotes)
            {
                inQuotes = false;
            }
            else if (c == ',' && !inQuotes)
            {
                result.Add(current.Trim());
                current = "";
            }
            else
            {
                current += c;
            }
        }
        result.Add(current.Trim());

        return result.ToArray();
    }
}
