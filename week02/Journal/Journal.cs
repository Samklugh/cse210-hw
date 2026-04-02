using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    // the entries list is a private field that holds all the journal entries. It is initialized as an empty list of Entry objects. this list will be used to store and manage the journal entries created by the user. Each entry in the list will contain the date, prompt, and response for a specific journal entry.

    public void AddEntry(Entry entry)
    // this method takes an Entry object as a parameter and adds it to the _entries list. This allows us to store new journal entries created by the user. When a new entry is created, it will be passed to this method, which will then add it to the list of entries for later retrieval and display.
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter output = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                output.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();

            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
        }
    }
}