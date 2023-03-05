using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit \nWhat would you like to do?");
        Console.Write("Create a file name: ");

        FileHandling journalEntry = new FileHandling();
        journalEntry._userFileNameInput = Console.ReadLine();
        journalEntry._userJournalEntry = Console.ReadLine();
        journalEntry.WriteOnFile();

        string[] lines = System.IO.File.ReadAllLines(journalEntry._userFileNameInput);

        foreach (string line in lines)
        {
            string[] entry = line.Split("~|");;
            foreach(string i in entry)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}