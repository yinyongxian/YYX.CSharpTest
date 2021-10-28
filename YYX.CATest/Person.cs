using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YYX.CATest
{
    public class Person: IHello
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Name == person.Name &&
                   Age == person.Age;
        }

        public override int GetHashCode()
        {
            int hashCode = -1360180430;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            return hashCode;
        }

        public void Say(string nmae)
        {
            throw new NotImplementedException();
        }
    }
}
