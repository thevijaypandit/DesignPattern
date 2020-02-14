using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderDesignPattern
{
    public class HeroBuilder : IVehicleBuilder
    {
        Vehicle vehicle = new Vehicle();
      

        public void SetAccessories()
        {
            vehicle.Accessories.Add("Seat Cover");
            vehicle.Accessories.Add("Rear Mirror");
        }

        public void SetBody()
        {
            vehicle.Body = "Plastic";
           // throw new NotImplementedException();
        }

        public void SetEngine()
        {
            vehicle.Engine = "4 Strok";
            //throw new NotImplementedException();
        }

        public void SetModel()
        {
            vehicle.Model= "Hero";
            //throw new NotImplementedException();
        }

        public void SetTransmission()
        {
            vehicle.Transmission= "120 km/hr"; 
            //throw new NotImplementedException();
        }
        public Vehicle GetVehicle()
        {
            return vehicle;
            //throw new NotImplementedException();
        }
    }
}
