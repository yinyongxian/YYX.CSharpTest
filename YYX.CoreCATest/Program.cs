// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using YYX.CoreCATest;


var person = new Person("YYX", 18);
ChangePerson(person);

Console.ReadKey();

void ChangePerson(Person person)
{
    person.Age = 19;
}