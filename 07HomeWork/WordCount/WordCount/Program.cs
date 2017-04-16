using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Most frequently occurring word in SimpleText.txt is?
            //
            // tips:
            //   ignore , . and \n
            //   ignore UPPER and lower characters
            // don't use group by
            //everything that you need to solve this is in the examplesvar resourceName = "Strings.TextFile.txt";  

            //read in the file
            var resourceName = "WordCount.TextFile.txt";
            using (var reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)))
            {
                string result = reader.ReadToEnd();
            }


        }
    }
}
