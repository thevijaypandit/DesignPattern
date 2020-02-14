using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryDesignPattern
{
    public class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("drive in Miles by Bike :" + miles +"km");
        }
    }
}
