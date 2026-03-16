using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What are you grateful for this morning?",
        "What hopes do you have for the day?",
        "How did you exercise today? How did that make you feel mentally and physically?",
        "How did you stay hydrated today? How did that affect your day?",
        "What emotions did you experience today? How did those emotions influence your day?",
        "How did you spend your evening? What moment brought you peace or enjoyment?",
        "What made me smile today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}