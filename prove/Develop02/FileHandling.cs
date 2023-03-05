using System;
using System.IO;

class FileHandling
{
    public string _fileName = "fileName.txt";
    public string _fileNameNew = "";

    public void WriteOnFile()
    {
        using (StreamWriter firstFileEntry = new StreamWriter(_fileName))
        {   
            string Entry = "My Journal\n";
            firstFileEntry.WriteLine(Entry);
        }
    }
    public void NewEntry(){
        using ( StreamWriter fileEntry = File.AppendText(_fileName)){
            DateTime currentDateTime = DateTime.Now;
            string currentDate = currentDateTime .ToShortDateString();
            randomQuestion question = new randomQuestion();
            string quest = question.callQuestion();
            Console.WriteLine(quest);
            string newEntry = Console.ReadLine();
            fileEntry.WriteLine($"{currentDate}\n{quest}\n{newEntry}\n");
        }
    }
    public void ReadFile(){
        
        string[] entriesCall = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in entriesCall)
        {
            Console.WriteLine(line);
        }
    }
    public void RenameFileName(){
        Console.WriteLine("what would you like to save your Journal as?");
        _fileNameNew = Console.ReadLine();
        System.IO.File.Move(_fileName, $"{_fileNameNew}.txt");
    }
    public void LoadFile(){
        Console.WriteLine("What is the name of the file you would like to load?");
        string fileNameToLoad = Console.ReadLine();
        string[] entriesCall = System.IO.File.ReadAllLines($"{fileNameToLoad}.txt");
        foreach (string line in entriesCall)
        {
            Console.WriteLine(line);
        }
    }
    
}