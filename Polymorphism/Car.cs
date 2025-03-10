using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Car: Vehicle
    {

        public override List<Vehicle> GetVehicles()
        {
            return base.GetVehicles();
        }


    }
}
