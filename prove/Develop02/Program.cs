using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {   
        

        bool displayOptions = true;
         while(displayOptions){
            Console.WriteLine("1. Write\n2. Display\n3. Save\n4. Load\n5. Quit");
            Console.WriteLine("Choose action required");
            string actionRequired = Console.ReadLine();

            FileHandling write = new FileHandling();
            {
                if(actionRequired == "1")
                {            
                    write.NewEntry();
                }
                else if ( actionRequired == "2")
                {
                    write.ReadFile();
                }
                else if ( actionRequired == "3")
                {   
                   write.RenameFileName();
                }
                else if ( actionRequired == "4")
                {
                    write.LoadFile();
                }
                else if(actionRequired == "5"){
                    displayOptions = false;
                }
                else
                {
                    Console.WriteLine("Incorrect input! Please type a number between 1-5");
                }
            }
         }
         
         
         
        

       
    }
}