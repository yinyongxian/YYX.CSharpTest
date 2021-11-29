using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace YYX.CATest
{
    public static class DataTableExtension
    {
        public static IList<T> ToCollection<T>(this DataTable dataTable)
        {
            IList<T> result = new List<T>();
            Type classType = typeof(T);
            PropertyInfo[] classProps = classType.GetProperties();
            List<DataColumn> dataColumn = dataTable.Columns.Cast<DataColumn>().ToList();
            T data;
            foreach (DataRow row in dataTable.Rows)
            {
                data = (T)Activator.CreateInstance(classType);
                foreach (PropertyInfo pc in classProps)
                {
                    try
                    {
                        DataColumn dc = dataColumn.Find(s => s.ColumnName == pc.Name);
                        if (dc != null)
                            pc.SetValue(data, row[pc.Name], null);
                    }
                    catch (Exception)
                    {
                        //pc.SetValue(data, "null", null);
                    }
                }
                result.Add(data);
            }
            return result;
        }
    }
}


