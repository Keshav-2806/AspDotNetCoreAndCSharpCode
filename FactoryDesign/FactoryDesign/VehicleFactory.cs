using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    internal class VehicleFactory
    {
        public static IVehicle GetVehicle(string objType)
        {
            IVehicle objectType=null;
            if (objType.ToLower().Equals("bike"))
            {
                objectType = new Bike();
            }
            else if (objType.ToLower().Equals("car"))
            {
                objectType = new Car();
            }
            return objectType;
        }
    }
}
