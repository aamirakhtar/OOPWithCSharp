using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithCSharp
{
    class Extensions
    {
        public static void Main()
        {
            try
            {
                String str = "faizan";
                Console.WriteLine(str.ToUpper());

                decimal val = 1921312.39m;
                Console.WriteLine(val.ToCurrencyFormat());

                //string currencyVal = ToCurrencyFormat(val);

                //Console.WriteLine(currencyVal);

                Console.WriteLine("1.3432423".IsNumber());

                string ss = null;
                ss.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Line Number: {0}", ex.GetLineNumber());
            }

            Console.ReadLine();
        }
    }

    //for extension methods you have to have a static class
    //1-Original class can be changed without accessing its code to change.
    //2-Object notation preerved in the original objects.
    //3-You can simply add function in all the classes if you can just extend parent class.

    public static class MiscExtensions
    {
        public static string ToCurrencyFormat(this decimal num)
        {
            return String.Format("Order Total: {0:C}", num);
        }

        public static bool IsNumber(this string val)
        {
            double d = 0;
            bool isNum = double.TryParse(val, out d);

            return isNum;
        }

        public static int GetLineNumber(this Exception ex)
        {
            StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
            return trace.GetFrame(0).GetFileLineNumber();
        }
    }

    //public class UserException : Exception
    //{
    //    public int GetLineNumber()
    //    {
    //        StackTrace trace = new System.Diagnostics.StackTrace(this, true);
    //        return trace.GetFrame(0).GetFileLineNumber();
    //    }
    //}
}






