using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithCSharp
{
    class ParamsInOutRef
    {
        public static void Main()
        {
            int val = Add(1, 2, 3, 4, 5, 6, 7);
            Console.WriteLine();
            //Add(new int[] { 1, 2, 3, 4, 5, 6, 7 });

            //When you suppose to return multiple values from the function, you have 2 methods "out" and "ref"

            User user = new User() { Address = "Pakistan" };

            //out parameter is a "one way", its value cannot be used inside the function you have the change it before any use of the parameter, 
            //its value can only be used to out the parameter from the function, thats why you have to assign some value inside the function.
            bool status1 = IsAuthenticated("aamir", "123", out user);

            //ref is a "two way" parameter, thats why its dangerous to use it, bcz you dont have to change the value inside the function before use like out parameter so, your function may use the value passed inside function which could be wrong.
            //The dangerous thing is, the actual parameter will be changed rather than the different copy is returned.
            bool status2 = IsAuthorized("aamir", "1234567", ref user);
        }

        //public static int Add(int a, int b, int c)
        //{
        //    return a + b + c;
        //}

        //public static int Add(int a, int b, int c, int d)
        //{
        //    return a + b + c;
        //}

        public static int Add(params int[] arr)
        {
            Console.WriteLine("{0},{1},{2}", 1, 2, 3);
            return arr.Sum();
        }

        public static void PrintName(string name)
        {
            Console.WriteLine(name);
        }

        public static bool IsAuthenticated(string userName, string password, out User user)
        {
            user = new User();
            user.Address = "Washington";
            //Get user from db via user name
            Console.WriteLine(user.Address);

            return true;
        }

        public static bool IsAuthorized(string userName, string password, ref User user)
        {
            //Get user from db via user name
            //user = new User();
            //user.Address = "Virginia";

            Console.WriteLine(user.Address);

            return true;
        }
    }

    public class User
    {
        public string UserName { get; set; }
        public string Address { get; set; }
    }
}
