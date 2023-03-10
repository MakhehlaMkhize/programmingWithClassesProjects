using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment student = new WritingAssignment("The Causes of World War II", "Mary Waters", "European History");

        Console.WriteLine(student.GetSummary());
        Console.WriteLine(student.GetWritingInformation());
    }
}