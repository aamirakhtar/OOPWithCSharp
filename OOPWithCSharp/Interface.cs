using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithCSharp
{
    //Entry Point
    class Interface
    {
        public static void Main()
        {
            MDDScanner mddScanner = new MDDScanner(new JsonLogger());
            mddScanner.ScanBarcode();

            Console.ReadLine();
        }
    }

    //Why Interface is a contract, bcz all childs have to implement all the members of the interface
    interface ISmartPhone
    {
        int ScreenSize { get; }
        string Dimension { get; }
        string Camera { get; }
        string Weight { get; }
        string Price { get; }
        string OS { get; }
        string RAM { get; }
        string Processor { get; }

        void VideoRecording();
        void Messaging();
    }


    //Multiple inheritance in interfaces
    public interface ISofa
    {
        string Foam { get; }

        void Sit();
    }

    public interface IBed
    {
        string Foam { get; }

        void Sit();

        void Lay();
    }

    //Mulitple inheritance is allowed in interfaces
    public class SofaCumBed : ISofa, IBed
    {
        public string Foam { get => "Moltifoam"; }

        public void Lay()
        {
            throw new NotImplementedException();
        }

        public void Sit()
        {
            throw new NotImplementedException();
        }
    }

    //Applications of interfaces:-
    //1- Enforcement of implementation to child classes.
    //2- Dependency Injection

    #region Dependency Injection
    public interface ILogger
    {
        void Error(string msg);
        void Info(string msg);
    }

    //This is independent class, which is called service in dependency injection
    public class ConsoleLogger : ILogger
    {
        public void Error(string msg)
        {
            Console.WriteLine("Error: {0} added to console.", msg);
        }

        public void Info(string msg)
        {
            Console.WriteLine("Info: {0} added to console.", msg);
        }
    }

    //This is independent class, which is called service in dependency injection
    public class TextFileLogger : ILogger
    {
        public void Error(string msg)
        {
            Console.WriteLine("Error: {0} added to text file.", msg);
        }

        public void Info(string msg)
        {
            Console.WriteLine("Info: {0} added to text file.", msg);
        }
    }

    //This is independent class, which is called service in dependency injection
    public class XmlLogger : ILogger
    {
        public void Error(string msg)
        {
            Console.WriteLine("Error: {0} added to xml file.", msg);
        }

        public void Info(string msg)
        {
            Console.WriteLine("Info: {0} added to xml file.", msg);
        }
    }

    //This is independent class, which is called service in dependency injection
    public class JsonLogger : ILogger
    {
        public void Error(string msg)
        {
            Console.WriteLine("Error: {0} added to json file.", msg);
        }

        public void Info(string msg)
        {
            Console.WriteLine("Info: {0} added to json file.", msg);
        }
    }

    //Dependent class, which is called client in dependency injection
    public class MDDScanner
    {
        public ILogger logger { get; set; }

        public MDDScanner(ILogger userlogger)
        {
            logger = userlogger;
        }

        public void ScanBarcode()
        {
            //Lets assume barcode reading functionaily is there

            logger.Error("Barcode successfully scanned.");
        }
    }

    #endregion
}
