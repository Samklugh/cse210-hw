using System;
using System.Text;

class Word
{
    private readonly string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }

        StringBuilder builder = new StringBuilder(_text.Length);
        foreach (char c in _text)
        {
            builder.Append(char.IsLetter(c) ? '_' : c);
        }

        return builder.ToString();
    }
}
