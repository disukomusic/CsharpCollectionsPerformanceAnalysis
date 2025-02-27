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
        for(int i = 0; i < 6; i++){
            Console.WriteLine(words[i]);
        }
        
    }
}