using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YYX.CATest
{
    public  static class StringExtensions
    {
        public static bool IsNull(this string text)
        {
            bool empty = string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text);
            return empty;
        }
    }
}
