using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryDesignPattern
{
    public class RegularScooter : IScooter
    {
        public string Name()
        {
            return "Regular Scooter- Name";
        }
    }
}
