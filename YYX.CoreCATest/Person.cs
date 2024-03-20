using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YYX.CoreCATest
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
