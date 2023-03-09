using System;

class scriptureStorage
{
    private List<string>_scriptureList = new List<string>();

    public List<string> StoreScriptures()
    {
        _scriptureList.Add("Moses 1:39 For behold, this is my work and my glory to bring to pass the immortality and eternal life of man.");
        // _scriptureList.Add("Abraham 3:22 Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones;\n23 And God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and he said unto me: Abraham, thou art one of them; thou wast chosen before thou wast born.");
        _scriptureList.Add("Amos 3:7 Surely the Lord God will do nothing, but he revealeth his secret unto his servants the prophets.");
        // _scriptureList.Add("Matthew 5:14 Ye are the alight of the world. A city that is set on an hill cannot be hid. 15 Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. 16 Let your alight so shine before men, that they may see your good works, and glorify your Father which is in heaven.");
        _scriptureList.Add("Matthew 6:24 No man can serve two masters: for either he will hate the one, and love the other; or else he will hold to the one, and despise the other. Ye cannot serve God and mammon.");

        return _scriptureList;
    }
   
    

}