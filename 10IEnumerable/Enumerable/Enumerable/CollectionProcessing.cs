using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    public class CollectionProcessing
    {
        public static void RunTest()
        {
            var list = new List<int> { 3, 1, 10, -39, 0, 12, 43, -3 };

            {
                // select
                var myNewList = list.Select(p => $"({p})");  //for every element select it and convert it to String and put it in parens
                //These all get fed into a new List of Strings
                //The $ is for String formatting - a literal with a variable
                Print(myNewList);
            }

            {
                // where
                var myNewList = list.Where(p => p > 0); //where the element fills the condition, put it in the list
                Print(myNewList);
            }

            {
                // Take, Skip
                var myNewList = list.Take(5).Skip(2); //chaining methods
                //take the first 5 elements, and from the result of that, skip the first 2
                Print(myNewList);
            }

            {
                // TakeWhile
                var myNewList = list.TakeWhile(p => p > 0); //get the things while the condition is true
                Print(myNewList);
            }

            {
                // SkipWhile
                var myNewList = list.SkipWhile(p => p > 0); //skip things while the condition is true, then take everything else
                Print(myNewList);
            }

            {
                // Max
                var max = list.Max();  //return the max element
                Console.WriteLine(max);
            }

            {
                // Max
                var min = list.Min();
                Console.WriteLine(min);
            }


            {
                // Count
                var count = list.Count();  
                Console.WriteLine(count);
            }

            {
                // Any
                var anyEq = list.Any(p => p == -100); //if any element of the list makes it true; acts like a boolean
                Console.WriteLine(anyEq);
            }

            {
                // Group
                var groups = list.GroupBy(p => p >= 0);  //GroupBy 
                foreach (var group in groups)
                {
                    Console.Write("We  are here" + group.Key + " ");
                    Print(group); 
                }
                Console.ReadLine();
            }

            {
                // Group 
                var groups = list
                    .Select(Math.Abs) //convert to absolute value
                    .Select(p => new { tens = p / 10, rest = p % 10 }) //get the
                    //new without a type is an anonymous type
                    //anonymous types cannot be returned as a result of the method
                    .GroupBy(p => p.tens);
                //0 0 1 3 0 1 4 0
                //3 1 0 9 0 2 3 3 
                //BECOMES
                //0 {0,3}{0,1}{0,0}{0,3}
                //1 {1,0}{1,2}
                //3 {3,9}
                //4 {4,3}

                foreach (var group in groups)
                {
                    Console.Write(group.Key + " and rests "); //key is tens
                    Print(group.Select(p => p.rest));
                    //prints: 0 and rests 3 1 0 3
                    //con't: 1 and rests 0 2
                    //con't: 3 and rests 9
                    //con't: 4 and rests 3
                }
            }

            {
                // Aggregation : JUST FYI
                var factorion = System.Linq.Enumerable.Range(1, 10).Aggregate((p, q) => p*q);
                //Range returns, in this case, the sequence of numbers from 1 - 10
                //Aggregate is basically perform multiplication in aggregate 
                Console.Write(factorion);

            }
            {
                // Aggregation : JUST FYI
                var maxAndMin = list.Aggregate(
                    new
                    {
                        max = Int32.MinValue,
                        min = Int32.MaxValue
                    },
                    (p, q) => new
                    {
                        max = Math.Max(p.max, q),
                        min = Math.Min(p.min, q),
                    });
                Console.Write(maxAndMin.min);
                Console.Write(maxAndMin.max);
            }
        }

        public static void Print<T>(IEnumerable<T> toPrint)
        {
            foreach (var elem in toPrint)
            {
                Console.Write($"{elem} ");
            }
            Console.WriteLine();
        }
    }
}
