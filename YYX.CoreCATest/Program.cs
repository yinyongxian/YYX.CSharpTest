// See https://aka.ms/new-console-template for more information

using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;
using YYX.CoreCATest;

Console.WriteLine("Hello, World!");


string[] groupFunctions = Enum.GetNames(typeof(DayOfWeek));
var query =
    from groupFunction in groupFunctions
    select groupFunction.ToString().ToUpper();

DayOfWeek result;
bool success = Enum.TryParse( "SUNDAY1", true, out result);
if (success)
{
    
}

Console.ReadKey();