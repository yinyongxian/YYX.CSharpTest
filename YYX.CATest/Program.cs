using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YYX.CATest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Enumerable.Range(1, 20).ToList();
            foreach (var i in list.AsParallel())
            {
                Console.WriteLine(i + " Start");
                Thread.Sleep(100);
                Console.WriteLine(i + " Complete");
            }

            Console.ReadKey();
        }
    }
}
