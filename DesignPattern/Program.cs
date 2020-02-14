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
            VehicleFactory factory = new ConcreteVehicleFactory();
            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(10);
            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(20);
            #endregion
            Console.ReadKey();
        }
    }
}
