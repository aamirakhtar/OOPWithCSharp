using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithCSharp
{
    public class Constructors
    {
        public static void Main()
        {
            SamsungGalaxy objDefault = new SamsungGalaxy();//Default non-static constructor
            
            SamsungGalaxy samsungGalaxy = new SamsungGalaxy("12mp", "6inches");//Overloaded constructor

            SamsungGalaxy obj = samsungGalaxy;//Its not a copy of a object but the copy of a reference.

            SamsungGalaxy obj1 = new SamsungGalaxy(samsungGalaxy);//copy constructor, means to get the copy of a passed object.

            Console.ReadLine();
        }
    }

    public class SamsungSmartPhone
    {
        public string screenSize { get; set; }
        public string cameraResolution { get; set; }

        public SamsungSmartPhone()
        {
            this.cameraResolution = "";
            this.screenSize = "";

            Console.WriteLine("Default parent non-static Constructor");
        }

        //Overloaded Constructor: when you want to create object with pre-defined custom values.
        public SamsungSmartPhone(string cameraResolution, string screenSize)
        {
            this.cameraResolution = cameraResolution;
            this.screenSize = screenSize;

            Console.WriteLine("Overloaded parent Constructor");
        }

        //Copy Constructor
        public SamsungSmartPhone(SamsungGalaxy obj)
        {
            this.screenSize = obj.screenSize;
            this.cameraResolution = obj.cameraResolution;

            Console.WriteLine("Copy parent Constructor");
        }
    }

    public class SamsungGalaxy : SamsungSmartPhone
    {
        //public string screenSize { get; set; }
        //public string cameraResolution { get; set; }

        public SamsungNote20Ultra smartPhone { get; set; }

        public static float price { get; set; }

        //Default static constructor
        static SamsungGalaxy()
        {
            price = 0;
            Console.WriteLine("Default Static child Constructor");
        }

        //Default Non-Static Constructor: without parameters
        public SamsungGalaxy()
        {
            this.cameraResolution = "";
            this.screenSize = "";
            this.smartPhone = new SamsungNote20Ultra();
            Console.WriteLine("Default non-static child Constructor");
        }

        //Overloaded Constructor: when you want to create object with pre-defined custom values.
        public SamsungGalaxy(string cameraResolution, string screenSize) : base(cameraResolution, screenSize)
        {
            this.cameraResolution = cameraResolution;
            this.screenSize = screenSize;
            this.smartPhone = new SamsungNote20Ultra();

            Console.WriteLine("Overloaded child Constructor");
        }

        //Copy Constructor
        public SamsungGalaxy(SamsungGalaxy obj)
        {
            this.screenSize = obj.screenSize;
            this.cameraResolution = obj.cameraResolution;
            this.smartPhone = obj.smartPhone;

            Console.WriteLine("Copy child Constructor");
        }

        public void VideoRecording()
        {
        }
    }
}
