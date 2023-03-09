using System;

class randomScriptureSelect
{
     public string selectScripture()
    {
        scriptureStorage select = new scriptureStorage();

        List<string> listOfScriptures = select.StoreScriptures();

        Random selectRandomScripture = new Random();

        int scriptureIndex = selectRandomScripture.Next(listOfScriptures.Count);

        string selectedScripture = listOfScriptures[scriptureIndex];

        return selectedScripture;
    }
}