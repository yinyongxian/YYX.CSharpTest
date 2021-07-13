using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace YYX.CATest
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Parse("7/8/2021 12:00:00 AM");
            DateTime time = dateTime.AddDays(1).AddSeconds(-1);


            Console.ReadKey();
        }

    }
}
