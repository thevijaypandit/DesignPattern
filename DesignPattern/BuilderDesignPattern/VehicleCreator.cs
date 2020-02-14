using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderDesignPattern
{
    public class VehicleCreator
    {
        private readonly IVehicleBuilder _vehicleBuilder;
        public VehicleCreator(IVehicleBuilder vehicleBuilder)
        {
            _vehicleBuilder = vehicleBuilder;
        }
        public void CreateVehicle()
        {
            _vehicleBuilder.SetModel();
            _vehicleBuilder.SetEngine();
            _vehicleBuilder.SetBody();
            _vehicleBuilder.SetTransmission();
            _vehicleBuilder.SetAccessories();
        }
        public Vehicle GetVehicle()
        {
            return _vehicleBuilder.GetVehicle();
        }
    }
}
