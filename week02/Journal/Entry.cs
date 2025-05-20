public class Entry
{
    private string _prompt;
    private string _entryText;
    private string _date;

    public string Prompt => _prompt;
    public string EntryText => _entryText;
    public string Date => _date;

    public Entry(string date, string prompt, string entryText)
    {
        _prompt = prompt;
        _entryText = entryText;
        _date = date;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entryText}\n");
    }

    public string ToFileFormat()
    {
        return $"{_date}|{_prompt}|{_entryText}";
    }

    public static Entry FromFileFormat(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length == 3)
        {
            return new Entry(parts[0], parts[1], parts[2]);
        }
        else
        {
            return null;
        }
    }
}
