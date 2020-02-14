using DesignPattern.BuilderDesignPattern;
using DesignPattern.FactoryDesignPattern;
using DesignPattern.PrototypeDesignPattern;
using DesignPattern.SingletonDesignPattern;
using System;

namespace DesignPattern
{
    class Program
    {

        static void Main(string[] args)
        {
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
            #region abstract factory pattern

            #endregion
            Console.ReadKey();
        }
    }
}
