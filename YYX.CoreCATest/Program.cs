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
    Person person = new Person(18, "YYX")
    {
        Id = 1,
        Name = "YYX"
    };

    var dog = new Dog("");
    DateTime startTime = new DateTime();
    DateTime endTime = new DateTime().AddDays(1);

    Dog.GetDog(new DateRange(startTime, endTime));

    Console.WriteLine(person.Name);

}

