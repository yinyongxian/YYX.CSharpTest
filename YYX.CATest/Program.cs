using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
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
            Type type = typeof(bool);

            string s = (string)null;

            //List<Person> person = new List<Person>
            //{
            //    new Person { Name = "B", Age = 30, },
            //    new Person { Name = "A", Age = 30, },
            //    new Person { Name = "A", Age = 10, },
            //    new Person { Name = "C", Age = 20, },

            //};

            //IOrderedQueryable<Person> orderedQueryable = person.AsQueryable().OrderBy(item => 0);
            //orderedQueryable = orderedQueryable.ThenBy(item => item.Name);
            //orderedQueryable = orderedQueryable.ThenBy(item => item.Age);

            //Person[] persons = orderedQueryable.ToArray();
            bool isNullOrEmpty = string.IsNullOrEmpty("");
            DataTable dataTable = MakeTable();

            string filterExpression = "id = 1 and ParentItem = 'ParentItem 1'";
            DataRow[] dataRows = dataTable.Select(filterExpression, "");
            Dictionary<string, object> filterDictionary = new Dictionary<string, object>
            {
                //{ "id", 1 },
                //{ "ParentItem", "ParentItem 1" },
                { "ReadOnly", true }
            };
            DataRow[] rows = dataTable.Select(filterDictionary);

            Console.ReadKey();
        }

        private static DataTable MakeTable()
        {
            // Create a new DataTable.
            System.Data.DataTable table = new DataTable("ParentTable");
            // Declare variables for DataColumn and DataRow objects.
            DataColumn column;
            DataRow row;

            // Create new DataColumn, set DataType,
            // ColumnName and add to DataTable.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "id";
            column.ReadOnly = true;
            column.Unique = true;
            // Add the Column to the DataColumnCollection.
            table.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ParentItem";
            column.AutoIncrement = false;
            column.Caption = "ParentItem";
            column.ReadOnly = false;
            column.Unique = false;
            // Add the column to the table.
            table.Columns.Add(column);

            // Create third column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Boolean");
            column.ColumnName = "ReadOnly";
            column.AutoIncrement = false;
            column.Caption = "ReadOnly";
            column.ReadOnly = false;
            column.Unique = false;
            // Add the column to the table.
            table.Columns.Add(column);

            // Make the ID column the primary key column.
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = table.Columns["id"];
            table.PrimaryKey = PrimaryKeyColumns;

            // Create three new DataRow objects and add
            // them to the DataTable
            for (int i = 0; i <= 2; i++)
            {
                row = table.NewRow();
                row["id"] = i;
                row["ParentItem"] = "ParentItem " + i;
                row["ReadOnly"] = i == 2;
                table.Rows.Add(row);
            }

            return table;
        }
    }
}
