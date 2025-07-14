public class JournalEntry
{
  public string _entryText;
  public DateTime _date;
  public string _promptText;

  public void Display()
  {
    Console.WriteLine($"Date: {_date.ToShortDateString()}");
    Console.WriteLine($"Prompt: {_promptText}");
    Console.WriteLine($"Entry: {_entryText}");
    Console.WriteLine();
  }
}