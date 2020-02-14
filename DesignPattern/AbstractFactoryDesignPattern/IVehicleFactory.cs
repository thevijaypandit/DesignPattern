using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryDesignPattern
{
    /// <summary>
    /// abstract factory interface
    /// </summary>
    public interface IVehicleFactory
    {
        IBike GetBike(string Bike);
        IScooter GetScooter(string Scooter);
    }
}
