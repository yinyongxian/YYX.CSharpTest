using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace YYX.CoreCATest
{
    public class Person : ISpeak
    {
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
        [Required]
        public int Id { get; init; }
        public string Name { get; set; }

        public void Speak()
        {
            Console.WriteLine("This is YYX. ");
        }
    }
}
 