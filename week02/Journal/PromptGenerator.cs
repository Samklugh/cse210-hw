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
        // this will generate a random index between 0 and the number of prompts in the list. The Next method of the Random class is used to generate a random integer, and we pass the count of prompts as the upper limit to ensure we get a valid index. Finally, we return the prompt at the randomly generated index from the _prompts list.

        return _prompts[index];
    }
}