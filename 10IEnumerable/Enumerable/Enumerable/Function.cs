using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    public class MyAwsomeMath  //super basic
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }

    public class MyAwsomeMathWithLog  //with private keywords, and logging.  this is a bit better.
    {
        public int Add(int a, int b)
        {
            Console.WriteLine("Operation started");
            var result = AddExecute(a, b);
            Console.WriteLine("Operation finish");
            return result;
        }

        public int Sub(int a, int b)
        {
            Console.WriteLine("Operation started");
            var result = SubExecute(a, b);
            Console.WriteLine("Operation finish");
            return result;
        }


        private int AddExecute(int a, int b)
        {
            return a + b;
        }

        private int SubExecute(int a, int b)
        {
            return a - b;
        }
    }

    public class MyAwsomeMathWithLogNoDuplication  //closer, but not quite.
    {
        public int Add(int a, int b)
        {
            return Log(AddExecute, a, b);
        }

        public int Sub(int a, int b)
        {
            return Log(SubExecute, a, b);
        }

        private int Log(Func<int, int, int> operation, int a, int b) //the log method has new stuff!
        //Func is a pointer to the method.  In this case, the first two are the input, the last one is the return type.
        //The last one is always the return type.
        //Using Func removes the copy and paste code
        {
            Console.WriteLine("Operation started");
            var result = operation(a, b);
            Console.WriteLine("Operation finish");
            return result;
        }

        private int AddExecute(int a, int b)
        {
            return a + b;
        }

        private int SubExecute(int a, int b)
        {
            return a - b;
        }
    }

    public class MyAwsomeMathWithLogNoDuplicationAndLambda  //that brings us here.  lambdas are a shortcut.
    {
        //lambda means "take these things are do this thing with it"
        //lambdas are super-tiny functions that you can pass like variables
        public int Add(int a, int b)
        {
            return Log((i, j) =>
            {
                return i + j;
            }, a, b);
        }

        public int Sub(int a, int b)
        {
            return Log((i, j) => i - j, a, b); //this is the shortcut version of the Add method
            // Func understands how to parse this with what you pass below and knows they line up
            // You don't need parens if you only have one variable
            // You have to pass a, b again because those are part of the Log method call
        }

        private static int Log(Func<int, int, int> operation, int a, int b) //visual studio is smart enough to 
        //Log(Func<lambda>, a, b)
        {
            Console.WriteLine("Operation started");
            var result = operation(a, b);
            Console.WriteLine("Operation finish");
            return result;
        }
    }

    public static class Function
    {

        public static void RunTest()
        {
            new MyAwsomeMath().Add(3, 5);
            new MyAwsomeMathWithLog().Add(3, 5);
            new MyAwsomeMathWithLogNoDuplication().Add(3, 5);
            new MyAwsomeMathWithLogNoDuplicationAndLambda().Add(3, 5);
        }
    }
}
