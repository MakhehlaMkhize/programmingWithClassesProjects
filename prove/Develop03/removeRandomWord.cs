using System;

class removeRandomWord
{
    private List<string>_removedWords = new List<string>();
    public void removeWords()
    {
        wordStorage words = new wordStorage();

        string[] scriptureWords = words.ListOfScriptureWords();

        for (int i = 0 ; i< scriptureWords.Length ; i++)
            {
                Console.Write($"{scriptureWords[i]} ");
            }

        Random randomSelect = new Random();

        string userInput = "";

        bool remove = true;

        while(remove)
        {
            Console.WriteLine("\n\nPress Enter to remove a word\nor\nType in 'quit' to exit.");
            
            userInput = Console.ReadLine();
            
            if (userInput =="")
            {   
                bool NotBlank = true;
                
                while(NotBlank)
                {
                    int randomIndex = randomSelect.Next(scriptureWords.Length);
                    
                    if (scriptureWords[randomIndex] != "___")
                    {
                        if (randomIndex>1)
                        {
                            _removedWords.Add(scriptureWords[randomIndex]);

                            scriptureWords[randomIndex] ="___";

                            if (_removedWords.Count+2 == scriptureWords.Length)
                            {
                                remove = false;
                            }
                            
                            NotBlank = false;
                        } 
                    }

                    else
                    {
                        NotBlank = true;
                    }

                }

                for (int i = 0 ; i< scriptureWords.Length ; i++)
                {   
                    Console.Write($"{scriptureWords[i]} ");
                }  
            }

            else if (userInput == "quit")
            {   
                remove = false;
            }

        }
    }
}