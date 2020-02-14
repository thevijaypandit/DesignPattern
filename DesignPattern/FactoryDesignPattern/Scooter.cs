using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryDesignPattern
{
   public class Scooter:IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("drive in Miles by Scooter :" + miles + "km");
        }

    }
}
