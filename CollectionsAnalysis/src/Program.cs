using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using CollectionsAnalysis;

namespace CollectionsAnalysis
{
    /// <summary>
    /// Example usage: CollectionsAnalysis.exe --t 10 --w 1000000
    /// </summary>
    class Program
    {
        public static int howManyStrings = 1000000;
        public static int numberOfTests = 10;

        public static List<int> ArrayResults = new List<int>();
        public static List<int> ArrayListResults = new List<int>();
        public static List<int> ListResults = new List<int>();
        public static List<int> LinkedListResults = new List<int>();

        public static float AvgArrayTime; 
        public static float AvgArrayListTime;
        public static float AvgListTime;
        public static float AvgLinkedListTime;

        public static void Main(string[] arguments)
        {
            ParseArguments(arguments);

            Random rand = new Random(420);
            RunMultipleTests(numberOfTests, rand);
        }

        /// <summary>
        /// Parses command-line arguments for test settings.
        /// </summary>
        /// <param name="args"></param>
        private static void ParseArguments(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "--t": //test count
                        if (int.TryParse(args[i + 1], out int tests))
                        {
                            numberOfTests = Math.Max(1, tests); // Ensure at least 1 test
                            i++;
                        }
                        break;

                    case "--w": //words per list
                        if (i + 1 < args.Length && int.TryParse(args[i + 1], out int strings))
                        {
                            howManyStrings = Math.Max(1, strings); // Ensure at least 1 string
                            i++;
                        }
                        break;

                    default:
                        return;
                }
            }

            Console.WriteLine($"Running {numberOfTests} tests with {howManyStrings} strings each.");
        }

        /// <summary>
        /// Runs a specified number of collections tests.
        /// </summary>
        /// <param name="numberOfTests"></param>
        /// <param name="rand"></param>
        public static void RunMultipleTests(int numberOfTests, Random rand)
        {
            for (int i = 0; i < numberOfTests; i++)
            {
                // Add the time results of each demo to a total list.
                ArrayResults.Add(RunCollectionDemo(Globals.TestType.Array, rand));
                ArrayListResults.Add(RunCollectionDemo(Globals.TestType.ArrayList, rand));
                ListResults.Add(RunCollectionDemo(Globals.TestType.List, rand));
                LinkedListResults.Add(RunCollectionDemo(Globals.TestType.LinkedList, rand));
            }

            CalculateDemoAverages();
        }

        /// <summary>
        /// Calculates the average times of each demo, and prints the results to the console.
        /// </summary>
        private static void CalculateDemoAverages()
        {
            // Calculate average time each collection type took
            AvgArrayTime = (float)ArrayResults.Average();
            AvgArrayListTime = (float)ArrayListResults.Average();
            AvgListTime = (float)ListResults.Average();
            AvgLinkedListTime = (float)LinkedListResults.Average();

            Console.WriteLine($"--------------");
            Console.WriteLine($"Ran {numberOfTests} tests with {howManyStrings} strings each.");
            Console.WriteLine($"-----Results-----");
            Console.WriteLine($"Avg Array Time: {AvgArrayTime:F2} ms");
            Console.WriteLine($"Avg ArrayList Time: {AvgArrayListTime:F2} ms");
            Console.WriteLine($"Avg List Time: {AvgListTime:F2} ms");
            Console.WriteLine($"Avg LinkedList Time: {AvgLinkedListTime:F2} ms");
            Console.WriteLine($"--------------");
        }

        /// <summary>
        /// Runs one collections demo with the specified collections type.
        /// </summary>
        /// <param name="demoType"></param>
        /// <param name="rand"></param>
        /// <returns></returns>
        public static int RunCollectionDemo(Globals.TestType demoType, Random rand)
        {
            Stopwatch stopwatch = new Stopwatch();

            switch (demoType)
            {
                case Globals.TestType.Array:
                    stopwatch.Restart();
                    ArrayDemo arrayDemo = new ArrayDemo(howManyStrings, rand);
                    stopwatch.Stop();
                    return (int)stopwatch.ElapsedMilliseconds;

                case Globals.TestType.ArrayList:
                    stopwatch.Restart();
                    ArrayListDemo arrayListDemo = new ArrayListDemo(howManyStrings, rand);
                    stopwatch.Stop();
                    return (int)stopwatch.ElapsedMilliseconds;

                case Globals.TestType.List:
                    stopwatch.Restart();
                    ListDemo listDemo = new ListDemo(howManyStrings, rand);
                    stopwatch.Stop();
                    return (int)stopwatch.ElapsedMilliseconds;

                case Globals.TestType.LinkedList:
                    stopwatch.Restart();
                    LinkedListDemo linkedListDemo = new LinkedListDemo(howManyStrings, rand);
                    stopwatch.Stop();
                    return (int)stopwatch.ElapsedMilliseconds;

                default:
                    return 0;
            }
        }
    }
}
