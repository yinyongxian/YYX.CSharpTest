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
            DateTime startDateTime = DateTime.Parse("2021-11-12 01:29:54.000");
            DateTime endDateTime = DateTime.Parse("2021-11-12 05:31:39.000");
            //DateTime.Parse("14505");
            TimeSpan dateTime = endDateTime - startDateTime;

            Console.ReadKey();
        }
    }
}
