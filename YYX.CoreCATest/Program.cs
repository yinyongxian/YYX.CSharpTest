// See https://aka.ms/new-console-template for more information

using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using YYX.CoreCATest;



Hello("YYX");



Console.ReadKey();

static void Hello(string text) 
{
    if (string.IsNullOrWhiteSpace(text))
    {
        return;
    }

    var index = text.IndexOf("Y", StringComparison.Ordinal);
    var length = text.Length;

    Console.WriteLine(index);
    Console.WriteLine(length);
}