using System;
using System.IO;
using App.Journal;

class Program {
    static void Main(string[] args) {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();
        int userChoice = -1;
        do {
            Console.Clear();
            Console.WriteLine("Please Select from the Following: ");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            try {
                userChoice = int.Parse(Console.ReadLine());
            } catch (FormatException) {
                Console.WriteLine("Invalid choice.");
            }
            if (userChoice == 1) {
                String currentDate = DateTime.Now.ToString("MM/dd/yyyy");
                String randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                String entryText = Console.ReadLine();
                journal.addEntry(new Entry() { _date = currentDate, _promptText = randomPrompt, _entryText = entryText });                
            } else if (userChoice == 2) {
                journal.displayAll();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            } else if (userChoice == 3) {
                Console.Write("Enter a journal name: ");
                String fileName = Console.ReadLine();
                Boolean result = journal.loadFromFile(fileName);
                if(!result) {
                    Console.WriteLine("Journal not found... Press any key to continue...");
                } else {
                    Console.WriteLine("Journal Loaded... Press any key to continue...");
                }
                Console.ReadKey();
            } else if (userChoice == 4) {
                Console.Write("Enter a journal name: ");
                String fileName = Console.ReadLine();
                journal.saveToFile(fileName);
                Console.WriteLine("Journal Saved... Press any key to continue...");
                Console.ReadKey();
            } else if (userChoice == 5) {
                Console.WriteLine("Goodbye!");
            } else {
                Console.WriteLine("Invalid choice.");
            }
        } while (userChoice != 5);
    }
}







