// See https://aka.ms/new-console-template for more information

using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using YYX.CoreCATest;



 string text = "22/11/2009";

DateTime date = DateTime.ParseExact(text, "dd/MM/yyyy", null);

Console.ReadLine();