public class Journal
{
  public List<JournalEntry> _entries = new List<JournalEntry>();
  public string _filename;

  public void AddEntry(string entry)
  {
    JournalEntry newEntry = new JournalEntry
    {
      _entryText = entry,
      _date = DateTime.Now,
      _promptText = "What did you learn today?"
    };
    _entries.Add(newEntry);
    Console.WriteLine("Entry added successfully.");
  }

  public void DisplayEntries()
  {
    Console.WriteLine("Journal Entries:");
    foreach (var entry in _entries)
    {
      entry.Display();
    }
  }

  public void LoadEntries(string filename)
  {
    _filename = filename;
    Console.WriteLine($"Loading entries from {filename}");
    string[] lines = File.ReadAllLines(filename);
    foreach (var line in lines)
    {
      string[] parts = line.Split('|');
      if (parts.Length == 3)
      {
        JournalEntry entry = new JournalEntry
        {
          _date = DateTime.Parse(parts[0]),
          _promptText = parts[1],
          _entryText = parts[2]
        };
        _entries.Add(entry);
      }
    }
  }

  public void SaveEntries(string filename)
  {
    _filename = filename;
    Console.WriteLine($"Saving entries to {filename}");
    using (StreamWriter writer = new StreamWriter(filename))
    {
      foreach (var entry in _entries)
      {
        writer.WriteLine($"{entry._date.ToShortDateString()}|{entry._promptText}|{entry._entryText}");
      }
    }
    Console.WriteLine("Entries saved successfully.");
  }

  public void Quit()
  {
    Console.WriteLine("Exiting the Journal application.");
  }
}