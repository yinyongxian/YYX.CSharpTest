// See https://aka.ms/new-console-template for more information

using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using YYX.CoreCATest;



Hello();



Console.ReadKey();

static void Hello()
{
    dynamic person = new Person(18, "YYX");
    Console.WriteLine(person.Name);
    Console.WriteLine(person.Sex);
} 