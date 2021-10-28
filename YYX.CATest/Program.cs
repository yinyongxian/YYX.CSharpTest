using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
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
            DateTime dateTime = DateTime.Parse("2020-08-21 08:26:51.723");
            string v = dateTime.ToString("MM:dd:yyyy HH:mm:ss tt");

            Console.ReadKey();
        }
    }
}
