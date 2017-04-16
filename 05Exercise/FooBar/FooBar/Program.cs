using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print numbers from 1 to 100
            // For all numbers that are divisible by 3 print "Foo" instead of number
            // For all numbers that are divisible by 5 print "Bar" instead of number
            // For all numbers that are divisible by 3 and 5 print "FooBar" instead of number

            int i;
            for(i=1; i<101; i++)
            {
                int Mod3 = i % 3;
                int Mod5 = i % 5;

                if(Mod3 == 0 && Mod5 == 0 )
                {
                    Console.WriteLine("FooBar");
                }
                else if (Mod3 == 0 && Mod5 != 0)
                {
                    Console.WriteLine("Foo");
                }
                else if (Mod5 == 0 && Mod3 != 0)
                {
                    Console.WriteLine("Bar");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
