namespace CollectionsAnalysis;

public class ListDemo
{
    public List<int> nums = new List<int>();

    public ListDemo(int howManyNums, Random rand)
    {
        for(int i = 0; i < howManyNums; i++) 
        {
            nums.Add(rand.Next(howManyNums));
        }

        Console.WriteLine("The first few numbers in the List are: ");
        for(int i = 0; i < 6; i++){
            Console.WriteLine(nums[i]);
        }
        
    }
}