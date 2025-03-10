using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Motorcycle: Vehicle
    {
        public override List<Vehicle> GetVehicles()
        {
            return base.GetVehicles();
        }
    }
}
