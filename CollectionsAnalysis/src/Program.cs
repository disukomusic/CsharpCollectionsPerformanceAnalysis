using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using CollectionsAnalysis;

namespace CollectionsDemo
{
    class Program
    {
        public static int HOW_MANY_NUMS = (int)Math.Pow(10, 6);

        public static List<int> ArrayResults = new List<int>();
        public static List<int> ArrayListResults = new List<int>();
        public static List<int> ListResults = new List<int>();
        public static List<int> LinkedListResults = new List<int>();
        
        public static float AvgArrayTime; 
        public static float AvgArrayListTime;
        public static float AvgListTime;
        public static float AvgLinkedListTime;
        
        public static void Main(string[] args)
        {
            Random rand = new Random(1273);
            RunMultipleTests(100, rand);
        }

        public static void RunMultipleTests(int numberOfTests, Random rand)
        {
            for (int i = 0; i < numberOfTests; i++)
            {
                ArrayResults.Add(RunCollectionDemo("Array", rand));
                ArrayListResults.Add(RunCollectionDemo("ArrayList", rand));
                ListResults.Add(RunCollectionDemo("List", rand));
                LinkedListResults.Add(RunCollectionDemo("LinkedList", rand));
            }

            AvgArrayTime = (float)ArrayResults.Average();
            AvgArrayListTime = (float)ArrayListResults.Average();
            AvgListTime = (float)ListResults.Average();
            AvgLinkedListTime = (float)LinkedListResults.Average();
            
            Console.WriteLine($"Avg Array Time: {AvgArrayTime:F2} ms");
            Console.WriteLine($"Avg ArrayList Time: {AvgArrayListTime:F2} ms");
            Console.WriteLine($"Avg List Time: {AvgListTime:F2} ms");
            Console.WriteLine($"Avg LinkedList Time: {AvgLinkedListTime:F2} ms");
        }
        
        public static int RunCollectionDemo(string demoType, Random rand)
        {
            Stopwatch stopwatch = new Stopwatch();

            switch (demoType)
            {
                case "Array":
                    stopwatch.Restart();
                    ArrayDemo arrayDemo = new ArrayDemo(HOW_MANY_NUMS, rand);
                    stopwatch.Stop();
                    return (int)stopwatch.ElapsedMilliseconds;

                case "ArrayList":
                    stopwatch.Restart();
                    ArrayListDemo arrayListDemo = new ArrayListDemo(HOW_MANY_NUMS, rand);
                    stopwatch.Stop();
                    return (int)stopwatch.ElapsedMilliseconds;

                case "List":
                    stopwatch.Restart();
                    ListDemo listDemo = new ListDemo(HOW_MANY_NUMS, rand);
                    stopwatch.Stop();
                    return (int)stopwatch.ElapsedMilliseconds;

                case "LinkedList":
                    stopwatch.Restart();
                    LinkedListDemo linkedListDemo = new LinkedListDemo(HOW_MANY_NUMS, rand);
                    stopwatch.Stop();
                    return (int)stopwatch.ElapsedMilliseconds;

                default:
                    return 0;
            }
        }
    }
}
