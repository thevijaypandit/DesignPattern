using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciple.DependencyInversionPrinciple_DIP_
{
    public class Jeep : IAutomobile
    {
        public void Ignition()
        {
            Console.WriteLine("jeep start");
        }

        public void Stop()
        {
            Console.WriteLine("jip stop");
        }
    }
}
