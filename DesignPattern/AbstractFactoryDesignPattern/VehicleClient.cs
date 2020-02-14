using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryDesignPattern
{
    public class VehicleClient
    {
        IBike bike;
        IScooter scooter;
        public VehicleClient(IVehicleFactory vehicleFactory,string type)
        {
            bike = vehicleFactory.GetBike(type);
            scooter = vehicleFactory.GetScooter(type);
        }
        public string GetBikeName()
        {
            return bike.Name();
        }
        public string GetScooterName()
        {
            return scooter.Name();
        }
    }
}
