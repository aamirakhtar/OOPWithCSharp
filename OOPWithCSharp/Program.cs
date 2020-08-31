using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            OrthopediacSurgeon obj = new OrthopediacSurgeon();

            Human human = new Human();            

            Console.ReadLine();
        }
    }

    class Human
    {
        protected string Legs { get; set; }
        protected string hands { get; set; }
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

    class Sergeon : Human
    {
        public string MedicalDegree { get; set; }

        public void PerformSurgery()
        {
        }
    }

    class Teacher : Human
    {
        public string Qualification { get; set; }

        public void Teach()
        {
        }
    }

    class OrthopediacSurgeon : Sergeon
    {
        public void PerformOrthopadiacSurgery()
        {

        }
    }

    class MathematicsTeacher : Teacher
    {
        public string MathematicsDegree { get; set; }

        public void TeachMaths()
        {

        }
    }

    class Sofa
    {
        public string Foam { get; set; }

        public void Sit()
        {
        }
    }

    class Bed
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
    //class SofaCumBed: Sofa, Bed
    //{

    //}
}
