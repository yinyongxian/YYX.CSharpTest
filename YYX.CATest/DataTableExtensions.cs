using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YYX.CATest
{
    public static class DataTableExtensions
    {
        public static DataRow[] Select(this DataTable dataTable, Dictionary<string, object> filterDictionary, bool trimEnd = true)
        {
            if (dataTable == null ||
                dataTable.Rows.Count <= 0)
            {
                return new DataRow[0];
            }

            if (filterDictionary == null || filterDictionary.Count <= 0)
            {
                return dataTable.Rows.Cast<DataRow>().ToArray();
            }

            foreach (string columnName in filterDictionary.Keys)
            {
                if (!dataTable.Columns.Contains(columnName))
                {
                    string message = string.Format("DataTable not contains column {0}.", columnName);
                    throw new Exception(message);
                }
            }

            List<DataRow> dataRows = new List<DataRow>();
            foreach (DataRow row in dataTable.Rows)
            {
                bool allSame = true;
                foreach (KeyValuePair<string, object> keyValuePair in filterDictionary)
                {
                    string columnName = keyValuePair.Key;
                    object columnValue = keyValuePair.Value;
                    if (!ValueEquals(row[columnName], columnValue, trimEnd))
                    {
                        allSame = false;
                        break;
                    }
                }

                if (allSame)
                {
                    dataRows.Add(row);
                }
            }

            return dataRows.ToArray();
        }

        public static bool ValueEquals(object obj1, object obj2, bool trimEnd)
        {
            if (obj1 == obj2)
            {
                return true;
            }
            if (IsEmpty(obj1) && IsEmpty(obj2)) return true;

            if ((IsEmpty(obj1) && !IsEmpty(obj2)) ||
                (!IsEmpty(obj1) && IsEmpty(obj2)))
            {
                return false;
            }

            if (trimEnd)
            {
                if (obj1 is string)
                {
                    obj1 = ((string)obj1).TrimEnd();
                }
                if (obj2 is string)
                {
                    obj2 = ((string)obj2).TrimEnd();
                }
            }
            if (obj1.GetType() == obj2.GetType())
            {
                return obj1.Equals(obj2);
            }
            //simple type
            else if (IsNumeric(obj1.GetType()) && IsNumeric(obj2.GetType()))
            {
                try
                {
                    Decimal obj1Decimal = System.Convert.ToDecimal(obj1);
                    Decimal obj2Decimal = System.Convert.ToDecimal(obj2);
                    return obj1Decimal.Equals(obj2Decimal);
                }
                catch
                {
                    Double obj1Double = System.Convert.ToDouble(obj1);
                    Double obj2Double = System.Convert.ToDouble(obj2);
                    return obj1Double.Equals(obj2Double);
                }
            }
            else
            {
                return false;
            }
        }

        public static bool IsNumeric(Type type)
        {
            Type innateType = GetInnateValueType(type);
            return (innateType == typeof(Int16) || innateType == typeof(Int32) || innateType == typeof(Int64) ||
                    innateType == typeof(UInt16) || innateType == typeof(UInt32) || innateType == typeof(UInt64) ||
                    innateType == typeof(Decimal) || innateType == typeof(Single) || innateType == typeof(Double));
        }

        public static bool IsEmpty(object value)
        {
            if (value == null || value is DBNull)
            {
                return true;
            }
            string str = value as string;
            if (str != null)
            {
                return str.Trim() == string.Empty;
            }

            return value.Equals(null);
        }

        public static Type GetInnateValueType(Type type)
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                return type.GetGenericArguments()[0];
            }
            return type;
        }
    }
}
