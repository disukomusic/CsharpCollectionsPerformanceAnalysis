namespace CollectionsAnalysis;

public class LinkedListDemo
{
    public LinkedList<int> nums = new LinkedList<int>();

    public LinkedListDemo(int howManyNums, Random rand)
    {
        for(int i = 0; i < howManyNums; i++) 
        {
            nums.AddLast(rand.Next(howManyNums));
        }

        //Linked lists don't support returning a specific index of a list, so just look through it until it's more than
        //six numbers.
        Console.WriteLine("The first few numbers in the Linked List are: ");
        int count = 0;
        foreach(var num in nums) 
        {
            if(count >= 6) break;
            Console.WriteLine(num);
            count++;
        }
    }
}