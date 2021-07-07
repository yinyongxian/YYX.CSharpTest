using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YYX.CATest
{
    class TestsRethrow
    {
        public static void Main2200()
        {
            //TestsRethrow testRethrow = new TestsRethrow();
            TestsRethrow.CatchException();
        }

        static void CatchException()
        {
            try
            {
                CatchAndRethrowExplicitly();
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Explicitly specified:{0}{1}",
                    Environment.NewLine, e.StackTrace);
            }

            try
            {
                CatchAndRethrowImplicitly();
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("{0}Implicitly specified:{0}{1}",
                    Environment.NewLine, e.StackTrace);
            }
        }

        static void CatchAndRethrowExplicitly()
        {
            try
            {
                ThrowException();
            }
            catch (ArithmeticException e)
            {
                // Violates the rule.
                throw e;
            }
        }

        static void CatchAndRethrowImplicitly()
        {
            try
            {
                ThrowException();
            }
            catch (ArithmeticException)
            {
                // Satisfies the rule.
                throw;
            }
        }

        static void ThrowException()
        {
            throw new ArithmeticException("illegal expression");
        }
    }
}
