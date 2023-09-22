// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using YYX.CoreCATest;


//using (var streamWriter = new StreamWriter(@"D:\tcm\v103_data1\dc\dcptrx.tst"))
//{
//    Console.WriteLine("YYX");
//}

using (var fileStream = File.Open(@"D:\tcm\v103_data1\dc\dcptrx.tst", FileMode.Open))
{
    Console.WriteLine("YYX");
}


Console.ReadKey();



