using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YYX.CATest
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime sqlStartDate = DateTime.Parse(@"1/1/1753 12:00:00 AM");
            DateTime sqlEndDate = DateTime.Parse(@"12/31/9999 11:59:59 PM");

            DateTime dateTime = new DateTime(1753, 13, 1);

            DateTime minValue = DateTime.MinValue;
            DateTime maxValue = DateTime.MaxValue;

            Console.WriteLine("YYX");

            Console.ReadKey();
        }
    }
}
