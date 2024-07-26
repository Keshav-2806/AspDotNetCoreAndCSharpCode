using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    internal class Car : IVehicle
    {
        private readonly int _wheels;

        public Car()
        {
                this._wheels = 4;
        }
        public int NumberOfWheels()
        {
            return this._wheels;
        }

        public string VehicleType()
        {
            return "Car";
        }
    }
}
