// See https://aka.ms/new-console-template for more information

using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;
using YYX.CoreCATest;

Console.WriteLine("Hello, World!");


DataTable dataTable = new DataTable();
dataTable.Columns.Add("A", typeof(DateTime));
//dataTable.Columns.Add("B", typeof(decimal));
//dataTable.Columns.Add("C", typeof(decimal));
for (int i = 0; i < 5; i++)
{
    DataRow dataRow = dataTable.NewRow();
    dataRow["A"] = null;
    //dataRow["B"] = 2 * i;
    //dataRow["C"] = 3 * i;
    dataTable.Rows.Add(dataRow);
}


var filterExpression = string.Format("A >= '{0}'", DateTime.Now);
DataRow[] dataRows = dataTable.Select(filterExpression);

Console.ReadKey();