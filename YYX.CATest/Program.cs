using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace YYX.CATest
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan timeSpan = ConvertToTimeSpan(154913);

            string s = 154913.ToString("00:00:00");

            Console.ReadKey();
        }

        public static TimeSpan ConvertToTimeSpan(int time)
        {
            int hour = time / 10000;
            int min = (time % 10000) / 100;
            int sec = (time % 100);

            return new TimeSpan(hour, min, sec);
        }
    }
}
