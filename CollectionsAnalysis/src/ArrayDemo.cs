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
        for(int i = 0; i < 6; i++){
            Console.WriteLine(words[i]);
        }
        
    }
}