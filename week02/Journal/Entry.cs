using System;

namespace App.Journal
{
    public class Entry {
        public string _date { get; set; }
        public string _promptText { get; set; }
        public string _entryText { get; set; }

        public void Display()
        {
            Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
            Console.WriteLine(_entryText);
        }
    }
}