using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                ///////////////////////////////////////////////////////////////
                // array
                int[] array = new int[10];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = i;
                }

                Console.WriteLine(array[5]);

            }
            {
                ///////////////////////////////////////////////////////////////
                // List
                List<string> list = new List<string>();

                for (int i = 0; i < 20; i++)
                {
                    list.Add($"this is {0}");
                }

                var isThere10 = list.Contains("this is 10");
                Console.WriteLine(isThere10);

                var secondIs = list[2];
                Console.WriteLine(secondIs);

                list.Insert(0, "this is -1");
                var newSecondIs = list[2];
                Console.WriteLine(newSecondIs);

            }
            {
                ///////////////////////////////////////////////////////////////
                // ForEach
                var list = new List<string>()
                {
                    "this",
                    "is",
                    "initialization"
                };

                foreach (var str in list)
                {
                    Console.WriteLine($"list elem {str}");
                }

            }
            {
                ///////////////////////////////////////////////////////////////
                // Dictionary
                var names = new Dictionary<int, string>();
                names.Add(1, "Wojciech");
                names.Add(2, "Alicja");
                names.Add(3, "Wiktor");

                Console.Write(names[1]);
                Console.WriteLine(names.ContainsKey(5));

                names[3] = "Aleksander";
            }
            {
                ///////////////////////////////////////////////////////////////
                // Dictionary
                var drinks = new Dictionary<string, int> {{"Beer", 6}, {"Wine", 5}, {"Vodka", 4}};

                drinks["Beer"]++; //this changes beer to 7

                int sum = 0;
                foreach (var value in drinks.Values) //it's .Values because it's Key, Value
                {
                    sum += value;
                }                
                if (sum > 15)
                {
                    string allDrinks = string.Join(" ", drinks.Keys.ToArray()); //Join - join an array of string with the specified character between them
                    Console.WriteLine($"KO! tooooo much {allDrinks}");
                }
            }
            {
                ///////////////////////////////////////////////////////////////
                // Back to String

                var text = "this|is|very|cool";
                var elems = text.Split('|'); //feeds the words into an array
                elems[1] = elems[1].ToUpper();
                var fullText = string.Join(" ", elems);

                Console.WriteLine(fullText);

            }
        }
    }
}
