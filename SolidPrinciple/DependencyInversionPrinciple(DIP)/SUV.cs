using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciple.DependencyInversionPrinciple_DIP_
{
    public class SUV : IAutomobile
    {
        public void Ignition()
        {
            Console.WriteLine("suv start");
        }

        public void Stop()
        {
            Console.WriteLine("suv stop");
        }
    }
}
