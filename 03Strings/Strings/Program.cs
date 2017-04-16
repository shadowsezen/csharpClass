using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////
            // string
            string text = "This is some text";

            Console.WriteLine(text);

            ///////////////////////////////////////////////////////////////
            // string
            var text2 = "This is some text too";

            Console.WriteLine(text2);

            ///////////////////////////////////////////////////////////////
            // concatenation
            var text3 = "This is "
                        + "some text too";

            Console.WriteLine(text3);

            ///////////////////////////////////////////////////////////////
            // casting
            var text4_1 = "This is text with " + 5 + " in";
            var text4_2 = string.Concat("This is text with ", 5, " in");
            Console.WriteLine(text4_1);
            Console.WriteLine(text4_2);

            ///////////////////////////////////////////////////////////////
            // formatting
            var text5_1 = string.Format("This is text with {0} in", 5);  //{0} says 'put the next value in where this is

            Console.WriteLine(text5_1);

            ///////////////////////////////////////////////////////////////
            // formatting
            var message = "This is text with {0} in";
            var text5_2 = string.Format(message, 5);

            Console.WriteLine(text5_2);

            ///////////////////////////////////////////////////////////////
            // formating new
            var text6_1 = $"This is text with {5} in";  

            Console.WriteLine(text6_1);

            ///////////////////////////////////////////////////////////////
            // new line
            var text7_1 = "Line \n new line";

            Console.WriteLine(text7_1);

            ///////////////////////////////////////////////////////////////
            // new line 
            var text7_2 = "Line " + Environment.NewLine + "new line";  //this is the best practice, because you don't know what the environment will be
            //var text7_2 = $"Line " { Environment.NewLine} "new line";
            Console.WriteLine(text7_2);

            ///////////////////////////////////////////////////////////////
            // escape chars
            var text8_1 = "c:\\this\\is\\path";

            Console.WriteLine(text8_1);


            ///////////////////////////////////////////////////////////////
            // string literal
            var text8_2 = @"c:\this\is\path";

            Console.WriteLine(text8_2);
            
            ///////////////////////////////////////////////////////////////
            // some operations
            var text9 = "this is string";

            Console.WriteLine(text9.Length);
            Console.WriteLine(text9.Substring(5, 2));
            Console.WriteLine(text9.Replace("is", "IS"));
            Console.WriteLine(text9.Contains("is"));
            Console.WriteLine(text9.IndexOf("is"));

            Console.WriteLine("this, is other text,".Replace(",",string.Empty));
            
            ///////////////////////////////////////////////////////////////
            // converting
            var text10 = "" +  10;
            Console.WriteLine(text10);

            var text11 = "10";
            int i = int.Parse(text11);
            Console.WriteLine(i+1);

            var text12 = "10.32";
            var d = double.Parse(text12);
            Console.WriteLine(d);


            ///////////////////////////////////////////////////////////////
            // some operations
            var somethingLong = "This";  // append creates a new object with the contents of both original objects because strings are immutable
            somethingLong += " is";
            somethingLong += " something";
            somethingLong += " very";
            somethingLong += " long";

            Console.WriteLine(somethingLong);

            var sb = new StringBuilder();  //this allows you to make the string mutable and thus save some memory
            sb.Append("This");  
            sb.Append(" is");
            sb.Append(" something");
            sb.Append(" very");
            sb.Append(" long");

            var somethingLonger = sb.ToString();
            Console.WriteLine(somethingLonger);

            ///////////////////////////////////////////////////////////////
            // reading from resources

            var resourceName = "Strings.TextFile.txt";  //where Strings in the name of the project
            using (var reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)))
            //this creates the txt file as part of the assembly so appended into the assembly
            //if you change the text file, you have to recompile the program, but it makes for less to deliver
            {
                string result = reader.ReadToEnd();
            }
        }
    }
}
