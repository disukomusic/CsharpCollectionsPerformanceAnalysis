namespace CollectionsAnalysis;

public class ListDemo
{
    public List<string> words = new List<string>();

    public ListDemo(int howManyNums, Random rand)
    {
        for(int i = 0; i < howManyNums; i++) 
        {
            words.Add(Globals.randomWords[rand.Next(Globals.randomWords.Length)]);
        }

        Console.WriteLine("The first few words in the List are: ");
        
        int maxWordsToDisplay = Math.Min(6, words.Count); //Make sure we don't print more words than are in the list
        for (int i = 0; i < maxWordsToDisplay; i++) 
        {
            Console.WriteLine(words[i]);
        }
    }
}