using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Physician phy = new Physician();
            phy.PrescribeMedicine();

            Gestroentrologist gastro = new Gestroentrologist();
            gastro.PrescribeMedicine();

            EntSpecialist ent = new EntSpecialist();
            ent.PrescribeMedicine();

            Console.WriteLine("Honda Acord 1970 features:-");
            HondaAccord1970 hondaAccord1970 = new HondaAccord1970();
            Console.WriteLine(hondaAccord1970.Transmission);
            Console.WriteLine(hondaAccord1970.Engine);
            Console.WriteLine(hondaAccord1970.TireSize);

            hondaAccord1970.Braking();
            hondaAccord1970.AirConditioning();

            Console.WriteLine("Honda Acord 1972 features:-");
            HondaAccord1972 hondaAccord1972 = new HondaAccord1972();
            Console.WriteLine(hondaAccord1972.Transmission);
            Console.WriteLine(hondaAccord1972.Engine);
            Console.WriteLine(hondaAccord1972.TireSize);

            hondaAccord1972.Braking();
            hondaAccord1972.AirConditioning();

            Console.WriteLine("Honda Acord 1990 features:-");
            HondaAccord1970 hondaAccord1990 = new HondaAccord1970();
            Console.WriteLine(hondaAccord1990.Transmission);
            Console.WriteLine(hondaAccord1990.Engine);
            Console.WriteLine(hondaAccord1990.TireSize);

            hondaAccord1990.Braking();
            hondaAccord1990.AirConditioning();

            Calculator calculator = new Calculator();
            calculator.Add(1, 2);
            calculator.Add(1, 2, 3);
            calculator.Add(2.5f, 1, 4.5);
            calculator.Add(2, 1.4f, 4.5);


            //OrthopediacSurgeon ortho = new OrthopediacSurgeon();
            //ortho.PerformSurgery();

            //CardiacSurgeon card = new CardiacSurgeon();
            //card.PerformSurgery();

            //Human human = new Human();

            //CricketerA cricketerA = new CricketerA(); // Inheritance
            //cricketerA.Batting();

            //CricketerB cricketerB = new CricketerB(); // Containment
            //cricketerB.Batting();

            //SmartPhone obj = new SmartPhone(); //Cannot create object bcz of the abstract class

            IPhone8 obj = new IPhone8();

            Console.ReadLine();
        }
    }

    #region Inheritance
    public class Human
    {
        protected string Legs { get; set; }
        public string hands { get; set; }
        protected string brain { get; set; }

        public string name { get; set; }
        public string nationality { get; set; }
        public string gender { get; set; }

        public void Sleep()
        {
        }

        public void Eat()
        {
        }

        public void Walk()
        {
        }

        public void Think()
        {
        }
    }

    public class Sergeon : Human
    {
        public string MedicalDegree { get; set; }

        public void PerformSurgery()
        {
        }
    }

    public class Teacher : Human
    {
        public string Qualification { get; set; }

        public void Teach()
        {
        }
    }

    public class OrthopediacSurgeon : Sergeon
    {
        public void PerformOrthopadiacSurgery()
        {

        }
    }

    public class CardiacSurgeon : Sergeon
    {
        public void PerformCardiacSurgery()
        {

        }
    }

    public class MathematicsTeacher : Teacher
    {
        public string MathematicsDegree { get; set; }

        public void TeachMaths()
        {

        }
    }

    public class Sofa
    {
        public string Foam { get; set; }

        public void Sit()
        {
        }
    }

    public class Bed
    {
        public string Foam { get; set; }

        public void Sit()
        {
        }

        public void Lay()
        {
        }
    }

    //It cannot be implimented because of multiple inheritance scenario
    //public class SofaCumBed: Sofa, Bed
    //{

    //}
    #endregion

    #region Containment

    //Inheritance is a tightly coupled design
    public class CricketerA : Human
    {

        public void Batting()
        {
            hands = "hands";
            Console.WriteLine("Using Human: {0} via inheritance", this.hands);
        }
    }

    //Containment is a loosely coupled design and can be alternative to inheritance
    public class CricketerB
    {
        public Human human = new Human();

        public void Batting()
        {
            human.hands = "hands";
            Console.WriteLine("Using Human: {0} via containment", human.hands);
        }
    }

    public class Car
    {
        public Engine engine { get; set; }
        public CarAC ac { get; set; }
        public Generator generator { get; set; }
        public Tire tire { get; set; }
    }

    public class RotaryObject
    {
        public void Rotation()
        {

        }
    }

    public class Generator : RotaryObject
    {
    }

    public class CarAC : RotaryObject
    {
    }

    public class Engine : RotaryObject
    {
    }

    public class Tire
    {
        public int radius { get; set; }
        public int thickness { get; set; }
        public int wallHeight { get; set; }
        public string material { get; set; }
    }

    #region Composition and Aggregation
    public class House
    {
        //Composition: House is strongy dependent upon rooms 
        public string BedRoom { get; set; }
        public string DrawingRoom { get; set; }
        public string LivingRoom { get; set; }

        //Aggregation: House is weekly dependent upon lamp and sofa
        public string Lamp { get; set; }
        public Sofa sofa { get; set; }
    }
    #endregion

    #endregion

    #region Polymorphism/Specialization

    #region 1-Dynamic Polymorphism/Overriding

    public class Physician : Human
    {
        public virtual void PrescribeMedicine()
        {
            Console.WriteLine("Prescribe Medicine");
        }
    }

    public class Gestroentrologist : Physician
    {
        public override void PrescribeMedicine()
        {
            Console.WriteLine("Prescribe Gestro Medicine");
        }
    }

    public class EntSpecialist : Physician
    {
        public override void PrescribeMedicine()
        {
            Console.WriteLine("Prescribe Ent Medicine");
        }
    }

    public class MrNadeem : Human
    {
        public virtual void Hobby()
        {
            Console.WriteLine("Listening to old classic songs");
        }
    }

    public class Faizan : MrNadeem
    {
        //This is the secialized copy of Faizan's Hobby Functionality
        public override void Hobby()
        {
            Console.WriteLine("Painting");
        }
    }

    public class HondaAccord1970
    {
        public virtual string Transmission => "Manual";
        public virtual string Engine => "1.5cc non efi";
        public virtual string TireSize => "15";

        public virtual void Braking()
        {
            Console.WriteLine("Drum Braking");
        }

        public virtual void AirConditioning()
        {
            Console.WriteLine("Manual Climate Control");
        }
    }

    public class HondaAccord1972 : HondaAccord1970
    {

    }

    public class HondaAccord1990 : HondaAccord1972
    {
        public override string Transmission => "Auto";
        public override string Engine => "2.0cc vti";

        public override void Braking()
        {
            Console.WriteLine("Disc Braking");
        }

        public override void AirConditioning()
        {
            Console.WriteLine("Automatic Cliamte Control");
        }
    }
    #endregion

    #region 2-Static Polymorphism/Method Overloading

    public class Bike
    {
    }

    public class Servant
    {
        public void GetGrocery(int money, Bike bike)
        {
            Console.WriteLine("Get 5kg onions");
        }

        public void GetGrocery(int money, Car car)
        {
            Console.WriteLine("Get 5kg onions, 20kg Wheat, 50kg Oil...");
        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        //1-Overloaded copy which has different number of parameters:-
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        //2-Overloaded copy which has different type of the parameters:-
        public double Add(float a, int b, double c)
        {
            return a + b + c;
        }

        //2-Overloaded copy which has different order of the type of the parameters:-
        public double Add(int a, float b, double c)
        {
            return a + b + c;
        }
    }

    #endregion

    #endregion

    #region Abstraction

    public abstract class SmartPhone //Concept
    {
        public abstract int ScreenSize { get; }
        public abstract string Dimension { get; }
        public abstract string Camera { get; }
        public abstract string Weight { get; }
        public abstract string Price { get; }
        public abstract string OS { get; }
        public abstract string RAM { get; }
        public abstract string Processor { get; }

        public abstract void VideoRecording();
        public abstract void Messaging();
    }

    public abstract class IPhone/*Concept*/ : SmartPhone
    {
        public override string OS => "IOS";

        public override void Messaging()
        {
            Console.WriteLine("IMessaging");
        }
    }

    public abstract class AndroidPhone : SmartPhone
    {
        public override string OS => "Android OS";
    }

    public class IPhone8 : IPhone
    {
        public override int ScreenSize => 6;

        public override string Dimension => "3x2x12";

        public override string Camera => "12 mp";

        public override string Weight => "10 ounce";

        public override string Price => "600$";

        public override string RAM => throw new NotImplementedException();

        public override string Processor => throw new NotImplementedException();

        public override void VideoRecording()
        {
            Console.WriteLine("1080p Video Recording");
        }
    }

    public class SamsungNote20Ultra : AndroidPhone
    {
        public override int ScreenSize => 6;

        public override string Dimension => "3x2x20";

        public override string Camera => "48mp";

        public override string Weight => "10 ounce";

        public override string Price => "1500$";

        public override string RAM => "16gb";

        public override string Processor => "P10";

        public override void Messaging()
        {
            Console.WriteLine("SMS, Watsapp");
        }

        public override void VideoRecording()
        {
            Console.WriteLine("4k VideoRecording");
        }
    }

    #endregion
}