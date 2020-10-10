using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithCSharp
{
    //Single object for the whole application
    static class Configuration
    {

    }

    public class Watsapp
    {
        public List<string> BroadCastList { get; set; }

        //Static member means, single object for the objects of the application
        public static List<string> settings { get; set; }
    }

    public class SamsungNote20
    {
        public static Watsapp watsapp { get; set; }
        public string ScreenSize { get; set; }
        public static string CameraResolution { get; set; }
        public float Price { get; set; }
        public static string MessageType { get; set; }

        //Static method can only access static members
        public static void Messaging()
        {
            MessageType = "Sms";
        }

        //Non-Static methods can access both static and non-static members
        public void VideoRecording()
        {
            this.Price = 100;
            CameraResolution = "16mp";
        }
    }

    public static class Utility
    {
        public static float Calculatetax(float price)
        {
            return price + 10;
        }

        public static void GetPaymentFromMerchant(string ccNo, double amount)
        {
            Console.WriteLine("Payment done");
        }
    }

    public class EntryPoint
    {
        public static void Main()
        {
            SamsungNote20 obj1 = new SamsungNote20();
            SamsungNote20 obj2 = new SamsungNote20();
            SamsungNote20 obj3 = new SamsungNote20();

            SamsungNote20.watsapp.BroadCastList = new List<string>();

            Utility.Calculatetax(4324);
            Utility.GetPaymentFromMerchant("432432424", 45);
        }
    }
}
