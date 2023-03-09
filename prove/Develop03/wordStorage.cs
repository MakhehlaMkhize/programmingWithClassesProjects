using System;

class wordStorage
{
    private List<string> _selectedWords = new List<string>();
    public String[] ListOfScriptureWords()
    {
        randomScriptureSelect select = new randomScriptureSelect();
        
        string words = select.selectScripture();
        String[] separator = {" "};
        String [] _selectedWords = words.Split(separator, StringSplitOptions.RemoveEmptyEntries);
       return _selectedWords;
    }
}