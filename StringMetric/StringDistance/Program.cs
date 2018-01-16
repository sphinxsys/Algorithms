using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LevenshteinDistance.Calculate("book", "back"));
            Console.WriteLine(LevenshteinDistance.Calculate("abc company", "abc inc"));
            Console.WriteLine(LevenshteinDistance.Calculate("abc company", "abc inc."));

            Console.Read();
        }
    }
}
