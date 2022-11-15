// See https://aka.ms/new-console-template for more information

using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using YYX.CoreCATest;



DataTable dataTable = new DataTable();
dataTable.Columns.Add("Name", typeof(string));
dataTable.Columns.Add("Age", typeof(int));
DataRow dataRow = dataTable.NewRow();
dataRow[0] = "YYX";
dataRow[1] = 18;

dataTable.Rows.Add(dataRow);
dataRow.Delete();

dataRow.AcceptChanges();

Console.ReadLine();