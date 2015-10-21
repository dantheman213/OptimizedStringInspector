using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OptimizedStringInspector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Welcome to the string inspector demo!");
            Console.WriteLine("Enter 'q' or CTRL+C to quit console application.\n");

            while (true) 
            {
                Console.WriteLine("\n\nPlease enter a phrase: ");
                input = Console.ReadLine();

                if(String.IsNullOrEmpty(input)) 
                {
                    Console.WriteLine("Please enter a valid phrase.\n");
                    continue;
                }
                else if (input == "q")
                {
                    System.Environment.Exit(0);
                }
                else 
                {
                    Stopwatch stopWatch = new Stopwatch();
                    stopWatch.Start(); // start the timer

                    List<char> results = StringInspector.FindMostOccurredChar(input);

                    stopWatch.Stop();
                    long duration = stopWatch.ElapsedMilliseconds + 1;

                    if(results.Count == 1) {
                        Console.WriteLine(String.Format("The most occurring character is: {0}", results[0]));
                    }
                    else 
                    {
                        Console.WriteLine(String.Format("There are multiple characters that occur the most. They are: {0}", String.Join(", ", results.ToArray())));
                    }

                    Console.WriteLine(String.Format("Search query took {0} milliseconds to perform.", duration));
                }


            }


            var result =  StringInspector.FindMostOccurredChar("aaawwwwrrrrqqqqq.");
            Console.WriteLine("done");
        }
    }
}
