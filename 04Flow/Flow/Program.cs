using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////
            // if
            {
                int a = 3;
                if (a == 3)
                    Console.WriteLine("What a suprise");
                else
                    Console.WriteLine("Dead code");
            }
            ///////////////////////////////////////////////////////////////
            // if and some logic
            {
                int b = 3;
                int a = 3;
                if (b >= 3 || (a >= 2 && a < 4))
                {
                    Console.WriteLine("What a suprise");
                }
                else
                {
                    Console.WriteLine("Dead code");
                }
            }

            ///////////////////////////////////////////////////////////////
            // inline if
            {
                var b = 3;
                var result = b > 2 ? "bigger then two" : "smaller or equal to two";  //if : else
                Console.WriteLine(result);
            }


            ///////////////////////////////////////////////////////////////
            // lot of ifs
            {
                int c = 2;
                string result = string.Empty;
                if (c == 1)
                {
                    result = "one";
                }
                else if (c == 2)
                {
                    result = "two";
                }
                else if (c == 3)
                {
                    result = "three";
                }
                else
                {
                    result = "I don't know";
                }
                Console.WriteLine(result);
            }

            ///////////////////////////////////////////////////////////////
            // switch
            {
                int d = 2;
                string result = string.Empty;
                switch (d)
                {
                    case 1:
                        result = "one";
                        break;
                    case 2:
                        result = "two";
                        break;
                    case 3:
                        result = "three";
                        break;
                    default:
                        result = "I don't know";
                        break;
                }
                Console.WriteLine(result);
            }

            ///////////////////////////////////////////////////////////////
            // for
            {
                var sum = 0;
                int i;
                for (i = 0; i < 5; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
            }

            ///////////////////////////////////////////////////////////////
            // while
            {
                var counter = 5;
                while (counter > 0)
                {
                    Console.WriteLine($"Counter = {counter}");
                    counter--;
                }
            }

            ///////////////////////////////////////////////////////////////
            // do while
            {
                var counter = 5;
                do
                {
                    Console.WriteLine($"Counter = {counter}");
                    counter--;
                } while (counter > 0);
            }

            ///////////////////////////////////////////////////////////////
            // break out
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"i = {i}");
                    if (i == 2)
                    {
                        break;
                    }
                }
            }

            ///////////////////////////////////////////////////////////////
            // continue
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i == 2)
                    {
                       continue;  //don't do anything else, just go back to the start of the loop for the next iteration
                    }
                    Console.WriteLine($"I hate when {i} == 2");
                }
            }
        }
    }
}
