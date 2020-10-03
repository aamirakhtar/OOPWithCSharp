using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithCSharp
{
    class ValueTypesRefTypes
    {
        //Entry Point
        public static void Main()
        {
            //Copy By Reference and Value

            //Reference     //Actual Object
            Corolla car1 = new Corolla() { Price = 200 }; //Reference Type

            Corolla car2 = car1;
            car2.Price = 300;

            Corolla car3 = car2;
            car3.Price = 400;

            Console.WriteLine(car1.Price);
            Console.WriteLine(car2.Price);
            Console.WriteLine(car3.Price);

            //*******************************************************************

            //Value Types
            int a = 100;

            int b = a;
            b = 200;

            int c = b;
            c = 300;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            List<int> list2 = list;
            list2.Remove(2);

            Console.ReadLine();
        }

        public class Corolla : Car
        {

        }
    }
}
