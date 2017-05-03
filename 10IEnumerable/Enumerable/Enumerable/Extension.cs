using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    public interface IAdder
    {
        int Add(int a, int b);
    }

    public class MyMath : IAdder
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    public static class AdderExtension  //the AdderExtension basically allows you to get these methods with IntelliSense
        //Extension methods allow you to add stuff to currently existing classes that you don't necessarily have access to the code for
    {
        public static int Subtraction(this IAdder adder, int a, int b) //in this case, "this" indicates an extension method
        {
            return adder.Add(a, -b);
        }
    }

    public static class Extension
    {
        public static void RunTest()
        {
            var math = new MyMath();

            //notice that the calls to the method and the extension methods are the same
            System.Console.WriteLine(math.Add(4, 2));
            System.Console.WriteLine(math.Subtraction(4, 2));
        }
    }
}
