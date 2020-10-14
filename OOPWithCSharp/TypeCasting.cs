using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithCSharp
{
    class TypeCasting
    {
        public static void Main()
        {
            int i = (int)2.9; //explicit type casting, float convert to int by force

            float f = 3; //implicit type casting, int convert to float by default

            object obj = "pakistan"; //implict type casting, string is converted to object which is a parent of all the classes by default

            string str = (string)obj; //a: explicit conversion, object to string means parent to child conversion is possible only for dot net primitive types not in user defined types

            string str1 = obj.ToString(); //a: explicit conversion, object to string

            double d = 5.69;
            float c = (float)d; //explicit conversion, bcz we go from bigger length variable to smaller one

            d = c; //implicit conversion, bcz we go smaller to bigger

            A a = new B(); //implict conversion

            //B b = (B)new A(); //this is not possible in custom classes case, bcz parent doesnt know what member does the child has

            int enumIntEquivalent = (int)WeekDays.fri;
            string enumStringEquivalent = WeekDays.fri.ToString();


            Console.ReadLine();

        }

        public class A
        {
            public int price { get; set; }
        }

        public class B : A
        {
            public string name { get; set; }
        }

        public enum WeekDays
        {
            sun,
            mon,
            tue,
            wed,
            thu,
            fri,
            sat
        }
    }


}
