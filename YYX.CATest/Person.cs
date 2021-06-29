using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YYX.CATest
{
    public class Person
    {
        private int age;
        public string Name { get; set; }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public DateTime? ShippingDate { get; set; }
    }
}
