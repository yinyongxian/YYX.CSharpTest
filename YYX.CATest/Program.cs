using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace YYX.CATest
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestsRethrow.Main2200();

            //Hello();

            try
            {
                Hello();
            }
            catch (DivideByZeroException e)
            {
                //Console.WriteLine(e);
                //throw;
            }

            Console.ReadKey();
        }

        private static void Hello()
        {
            try
            {
                var i = 1 / int.Parse("0");

                //NewMethod();
            }
            catch (DivideByZeroException e)
            {
                //Console.WriteLine(e);
                throw;
            }
        }

        private static void NewMethod()
        {
            var i = 1 / int.Parse("0");

            //throw new ArithmeticException("illegal expression");
        }
    }
}
