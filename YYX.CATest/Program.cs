using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YYX.CATest
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Column1");
            DataRow dataRow = dataTable.NewRow();
            dataRow["Column1"] = 1;
            dataTable.AcceptChanges();



            Console.ReadKey();
        }
    }
}
