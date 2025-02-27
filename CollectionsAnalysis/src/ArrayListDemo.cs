using System.Collections;

namespace CollectionsAnalysis;

public class ArrayListDemo
{
    public ArrayList arrayList = new ArrayList();

    public ArrayListDemo(int howManyNums, Random rand)
    {
        for(int i = 0; i < howManyNums; i++) 
        {
            arrayList.Add(Globals.randomWords[rand.Next(Globals.randomWords.Length)]);
        }

        Console.WriteLine("The first few words in the Array List are: ");
        for(int i = 0; i < 6; i++){
            Console.WriteLine(arrayList[i]);
        }
        
    }
}