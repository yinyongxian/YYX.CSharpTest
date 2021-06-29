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
            Hello();

            Console.ReadKey();
        }

        private static void Hello()
        {
            Person person = new Person
            {
                Age = 18,
                Name = "YYX",
                ShippingDate = null,
            };

            var jsonSerializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore

            };
            string serializeObject = JsonConvert.SerializeObject(person, jsonSerializerSettings);
        }
    }
}
