using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryDesignPattern
{
    public class RegularBike : IBike
    {
        public string Name()
        {
            return "Regular Bike- Name";
        }
    }
}
