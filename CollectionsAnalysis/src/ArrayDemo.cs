namespace CollectionsAnalysis;

public class ArrayDemo
{
    public string[] words;

    public ArrayDemo(int howManyNums, Random rand)
    {
        words = new string[howManyNums];
        
        for(int i = 0; i < howManyNums; i++) 
        {
            words[i] = Globals.randomWords[rand.Next(Globals.randomWords.Length)];
        }

        Console.WriteLine("The first few words in the Array Demo are: ");
        int maxWordsToDisplay = Math.Min(6, words.Length); //Make sure we don't print more words than are in the list
        for (int i = 0; i < maxWordsToDisplay; i++) 
        {
            Console.WriteLine(words[i]);
        }
    }
}