using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciple.DependencyInversionPrinciple_DIP_
{
   public class AutomobileController
    {
        private IAutomobile _automobile;
       public AutomobileController(IAutomobile automobile)
        {
            _automobile = automobile;
        }
        public void Ignition()
        {
            this._automobile.Ignition();
        }
        public void Stop()
        {
            this._automobile.Stop();
        }
    }
}
