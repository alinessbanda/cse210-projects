using System;
using System.Collections.Generic;
public class RandomPromptGenerator
{
    private List<string> _prompts;
    private Random _random;
    public RandomPromptGenerator()
    {
        _random = new Random();
        _prompts = new List<string>
        {
            "What is something i learned today?",
            "What made me smile today?",
            "What challenge did I face and how did I deal with it?",
            "What is one thing I'm grateful for today?",
            "What would I like to remember about today?"
        };
    }
    public string GetPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

}