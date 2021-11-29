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
            DateTime now = DateTime.Now;
            string v = now.ToString("MM/dd/yyyy");
            string v1 = now.ToString("hh:mm:ss tt");

            Console.ReadKey();
        }
    }

}
