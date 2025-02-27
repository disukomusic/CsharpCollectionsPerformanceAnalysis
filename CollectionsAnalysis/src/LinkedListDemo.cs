namespace CollectionsAnalysis;

public class LinkedListDemo
{
    public LinkedList<string> words = new LinkedList<string>();

    public LinkedListDemo(int howManyWords, Random rand)
    {
        for (int i = 0; i < howManyWords; i++)
        {
            words.AddLast(Globals.randomWords[rand.Next(Globals.randomWords.Length)]);
        }

        Console.WriteLine("The first few words in the Linked List are: ");
        int count = 0;
        foreach (var word in words)
        {
            if (count >= 6) break;
            Console.WriteLine(word);
            count++;
        }
    }
}