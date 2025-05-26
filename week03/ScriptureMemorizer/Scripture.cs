using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _wordList = new List<Word>();
    private Random _random = new Random();

    public Scripture(Reference reference, string verseText)
    {
        _reference = reference;
        SetWords(verseText);
    }

    private void SetWords(string verseText)
    {
        string[] words = verseText.Split(' ');
        foreach (string word in words)
        {
            AddWord(word);
        }
    }

    private void AddWord(string word)
    {
        _wordList.Add(new Word(word));
    }

    public void HideRandomWords()
    {
        int wordsToHide = 3;
        int count = 0;

        while (count < wordsToHide)
        {
            int index = _random.Next(_wordList.Count);
            if (!_wordList[index].IsHidden())
            {
                _wordList[index].Hide();
                count++;
            }
        }
    }

    public void Display()
    {
        _reference.Display();
        Console.WriteLine();
        foreach (Word word in _wordList)
        {
            word.Display();
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _wordList)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}
