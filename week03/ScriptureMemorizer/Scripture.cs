using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words;
    private readonly Random _rng;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(word => new Word(word))
            .ToList();
        _rng = new Random();
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        if (visibleWords.Count == 0)
        {
            return;
        }

        int countToHide = Math.Min(numberToHide, visibleWords.Count);
        for (int i = 0; i < countToHide; i++)
        {
            int index = _rng.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string text = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {text}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
