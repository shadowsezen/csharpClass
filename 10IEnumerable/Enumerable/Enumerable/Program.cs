using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Extension.RunTest();
            Function.RunTest();
            CollectionProcessing.RunTest();
        }
    }
}
