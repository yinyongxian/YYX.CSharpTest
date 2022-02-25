using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace YYX.CoreCATest
{
    public class Info
    {
        public void WriteLocation()
        {
            Assembly entryAssembly = Assembly.GetEntryAssembly().Location;
            if (entryAssembly != null)
            {
                Console.WriteLine(entryAssembly.Location);
            }
        }
    }
}
