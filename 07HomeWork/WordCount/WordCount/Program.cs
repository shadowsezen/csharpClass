using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//current problems: dealing with /n
//need to iterate over the dictionary to find the highest value and output that pair

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Most frequently occurring word in SimpleText.txt is?
 

            //declarations
            string[] words;
            var uniqueWords = new Dictionary<string, int>();


            //read in the file
            var resourceName = "WordCount.SimpleText.txt";
            using (var reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)))
            {
                string result = reader.ReadToEnd();

                //cleaning up per instructions to ignore , .
                //also putting everything in lowercase so it's an even comparison
                result = result.Replace(",", "");
                result = result.Replace(".", "");

                //attempt to replace /n
                result = result.Replace(Environment.NewLine, "");

                result = result.ToLower();

                //create the array to iterate over, since the space is the delimitor for individual words
                words = result.Split(' ');
            }

            //foreach is more useful here than for, fight me
            //for each word in words...
            foreach (string word in words)
            {
                //Console.WriteLine(word); checking to make sure everything is ok so far - seems so

                //...check to see if it's already in our list of unique words and if so...
                if (uniqueWords.ContainsKey(word))
                {
                    //increment the counter for the key
                    uniqueWords[word] = ++uniqueWords[word];
                }
                //if not, add it and set key to 1
                else
                {
                    uniqueWords.Add(word, 1);
                }

                Console.WriteLine("the word " + word + " is in the dictionary " + uniqueWords[word] + " times.");
                //then need to look over the values to see which key has the highest value
                //foreach (KeyValuePair<string, int> pair in dictionary) //loop through the dictionary
                //Response.Write(string.Format("Key: {0}, Pair: {1}<br />", pair.Key, pair.Value));

                //then output that
            }

            Console.ReadLine();
        }
    }
}
