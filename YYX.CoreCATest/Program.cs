// See https://aka.ms/new-console-template for more information

using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using YYX.CoreCATest;

//var name = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
//Console.WriteLine(name);


List<string> list = new List<string>
{
    "A",
    "B",
    "C",
    "D",
};

string s = string.Join("\r\n", list);

Console.WriteLine(s);

Console.ReadKey();