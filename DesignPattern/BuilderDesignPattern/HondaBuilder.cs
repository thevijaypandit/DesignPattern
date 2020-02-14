﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderDesignPattern
{
    public class HondaBuilder : IVehicleBuilder
    {

        Vehicle objVehicle = new Vehicle();
        public void SetAccessories()
        {
            objVehicle.Accessories.Add("Seat Cover");
            objVehicle.Accessories.Add("Rear Mirror");
            objVehicle.Accessories.Add("Helmet");
        }

        public void SetBody()
        {
            objVehicle.Body = "Plastic";
        }

        public void SetEngine()
        {
            objVehicle.Engine = "4 Stroke";
        }

        public void SetModel()
        {
            objVehicle.Model = "Honda";
        }

        public void SetTransmission()
        {
            objVehicle.Transmission = "125 Km/hr";
        }
        public Vehicle GetVehicle()
        {
            return objVehicle;
        }
        
    }
}
