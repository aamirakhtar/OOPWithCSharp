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
            OrthopediacSurgeon obj = new OrthopediacSurgeon();

            Human human = new Human();

            CricketerA cricketerA = new CricketerA(); // Inheritance
            cricketerA.Batting();

            CricketerB cricketerB = new CricketerB(); //Containment
            cricketerB.Batting();

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
}
