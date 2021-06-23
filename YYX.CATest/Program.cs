using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YYX.CATest
{
    class Program
    {
        static void Main(string[] args)
        {
            var joinString = string.Join("abcd", "abcdefg");
            Console.WriteLine(joinString);

            Console.ReadKey();
        }
    }
}
