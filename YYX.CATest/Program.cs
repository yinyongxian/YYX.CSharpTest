using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            List<Person> peoples = new List<Person>();

            List<int> list = Enumerable.Range(1, 100000000).ToList();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //Person person;
            foreach (int i in list)
            {
                //person = new Person();
                Person person = new Person();
                person.Name = i.ToString();
                peoples.Add(person);
            }
            stopwatch.Stop();

            Console.WriteLine(stopwatch.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }

}
