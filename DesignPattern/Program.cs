using DesignPattern.BuilderDesignPattern;
using DesignPattern.FactoryDesignPattern;
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
            var vehicleCreater = new VehicleCreator(new HondaBuilder());
            vehicleCreater.CreateVehicle();
            var vehicle = vehicleCreater.GetVehicle();
            vehicle.ShowInfo();
            Console.WriteLine("---------------------------------------------");
            vehicleCreater = new VehicleCreator(new HeroBuilder());
            vehicleCreater.CreateVehicle();
            vehicle = vehicleCreater.GetVehicle();
            vehicle.ShowInfo();
            #endregion
            Console.ReadKey();
        }
    }
}
