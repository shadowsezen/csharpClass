using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////
            // init variable
            int j;
            j = 3;

            Console.WriteLine(j);

            ///////////////////////////////////////////////////////////////
            // init variable and assign value
            int i = 5;

            Console.WriteLine(i);


            ///////////////////////////////////////////////////////////////
            // some operations
            int sum = i + j;
            j = 5;            

            Console.WriteLine(sum);

            ///////////////////////////////////////////////////////////////
            // floating point operations
            double d = 1.1;
            decimal dec = 1.1M;

            Console.WriteLine(d);
            Console.WriteLine(dec);

            ///////////////////////////////////////////////////////////////
            // +=
            int age = 1;
            age += 3;       // age = age + 3
            age -= 2;       // age = age - 2
            Console.WriteLine(age);

            ///////////////////////////////////////////////////////////////
            // / %
            int people = 11;
            int rooms = 5;

            int peopleByRoom = people/rooms;
            int restOfPeople = people%rooms;

            Console.WriteLine(peopleByRoom);
            Console.WriteLine(restOfPeople);


            ///////////////////////////////////////////////////////////////
            // ++
            int counter = 1;

            int result1 = counter++;  //increment after
            int result2 = ++counter;  //increment before

            Console.WriteLine(result1);  //1
            Console.WriteLine(result2);  //3

            ///////////////////////////////////////////////////////////////
            // casting to more generic
            int dolars = 2383;
            double otherPrice = dolars;

            Console.WriteLine(dolars);
            Console.WriteLine(otherPrice);

            ///////////////////////////////////////////////////////////////
            // casting to less generic - lost of precision
            double somePrice = 48.99;
            int justDolars = (int)somePrice;

            Console.WriteLine(somePrice);
            Console.WriteLine(justDolars);

            ///////////////////////////////////////////////////////////////
            // var 
            var someInt = 3;
            var someDouble = 3.14;

            Console.WriteLine(someInt);
            Console.WriteLine(someDouble);

            ///////////////////////////////////////////////////////////////
            // some math
            var max = Math.Max(1, 3);
            var min = Math.Min(2, 3);
            var money = Math.Round(2.323341, 2);
            var floor = Math.Floor(1.9);        
            
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(money);
            Console.WriteLine(floor);  //round down

            ///////////////////////////////////////////////////////////////
            // scope
            var p = 1;
            {
                var someNumber = 23 + p;
                Console.WriteLine(someNumber);
                var otherNumer = 2;
            }
            {
                var someNumber = 23.4;
                //var p = 323 + otherNumer;                
                Console.WriteLine(someNumber);
            }
        }
    }
}
