using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace App.Journal {
    class Journal {
        public List<Entry> journalEntries = new List<Entry>();
        public void addEntry(Entry newEntry) {
            journalEntries.Add(newEntry);
        }
        public void displayAll() {
            foreach (Entry entry in journalEntries) {
                entry.Display();
            }
        }
        public void saveToFile(string fileName)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (!fileName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
            {
                fileName += ".json";
            }
            string fullPath = Path.Combine(currentDirectory, fileName);
            string json = JsonSerializer.Serialize(journalEntries, new JsonSerializerOptions
            {
                WriteIndented = true
            });    
            File.WriteAllText(fullPath, json);
        }
        public Boolean loadFromFile(string fileName)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (!fileName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
            {
                fileName += ".json";
            }
            string fullPath = Path.Combine(currentDirectory, fileName);

            if (File.Exists(fullPath))
            {
                string json = File.ReadAllText(fullPath);
                journalEntries = JsonSerializer.Deserialize<List<Entry>>(json);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
