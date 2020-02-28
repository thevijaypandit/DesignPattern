using DesignPattern.BuilderDesignPattern;
using DesignPattern.FactoryDesignPattern;
using DesignPattern.PrototypeDesignPattern;
using DesignPattern.SingletonDesignPattern;
using SolidPrinciple.DependencyInversionPrinciple_DIP_;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern
{
    class Program
    {

        static void Main(string[] args)
        {
            var evenList = new List<int>();
            var oddList = new List<int>();
            var oddEvenList = new List<int>();
            #region singleton
            //Singleton.GetInstance.Show();
            //Singleton.GetInstance.Show();
            //Singleton.GetInstance.Show();
            #endregion
            #region factory pattern
            //VehicleFactory factory = new ConcreteVehicleFactory();
            //IFactory bike = factory.GetVehicle("Bike");
            //bike.Drive(10);
            //IFactory scooter = factory.GetVehicle("Scooter");
            //scooter.Drive(20);
            #endregion
            #region abstract factory pattern

            #endregion
            #region Builder Pattern
            //var vehicleCreater = new VehicleCreator(new HondaBuilder());
            //vehicleCreater.CreateVehicle();
            //var vehicle = vehicleCreater.GetVehicle();
            //vehicle.ShowInfo();
            //Console.WriteLine("---------------------------------------------");
            //vehicleCreater = new VehicleCreator(new HeroBuilder());
            //vehicleCreater.CreateVehicle();
            //vehicle = vehicleCreater.GetVehicle();
            //vehicle.ShowInfo();
            #endregion
            #region Prototype Pattern

            //Developer developer = new Developer();
            //developer.Name = "Vijay Pandit";
            //developer.Role = "Developer";
            //developer.PreferredLanguage = "C#";
            //Developer devCopy = (Developer)developer.Clone();
            //devCopy.Name = "Subin Manandhar";//Not mention Role and PreferredLanguage, it will copy above
            //Console.WriteLine(developer.GetDetails());
            //Console.WriteLine(devCopy.GetDetails());
            //Console.WriteLine("---------------------------------------------------");
            //Typist typist = new Typist();
            //typist.Name = "Ajuba";
            //typist.WordsPerMinute = 120;
            //typist.Role = "Typist";
            //Typist typistCopy = (Typist)typist.Clone();
            //typistCopy.Name = "Salo";
            //Console.WriteLine(typist.GetDetails());
            //Console.WriteLine(typistCopy.GetDetails());
            #endregion


            #region SOLID Design Principle
            #region DependencyInversionPrinciple
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    oddList.Add(10-i);
                }

                else if (i % 2 != 0)
                {
                    evenList.Add(i);
                }
                //oddEvenList = oddList.Concat(evenList).ToList();
                oddEvenList.Add(i);

            }
            foreach (var n in oddEvenList)
            {
                Console.WriteLine(n);
            }
            IAutomobile automobile = new Jeep();
            AutomobileController automobileController = new AutomobileController(automobile);
            automobile.Ignition();
            automobile.Stop();
            #endregion
            #endregion
            Console.ReadKey();
        }
    }
}
