using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace YYX.CATest
{
	class Program
	{
#pragma warning disable IDE0060 // Remove unused parameter
        static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            var person = new Person
            {
                Name = "0123456789",
                Age =18
            };


            for (int i = 1; i <= 3; i++)
            {
                Foo(i, ref person);
            }

            Console.ReadKey();
		}

        private static void Foo(int i, ref Person person)
        {
            var substring = person.Name.Substring(i * 3 - 3, 3);
        }
    }
}
