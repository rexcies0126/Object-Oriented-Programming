using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Vehicle
    {
        public string Name { get; set; }

        public Vehicle(string name)
        {
            this.Name = name;
        }

        public Vehicle() { }

        public virtual List<Vehicle> GetVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Vehicle("BMW"));
            vehicles.Add(new Vehicle("SUZUKI"));
            vehicles.Add(new Vehicle("HONDA"));
            return vehicles;
        }
    }
}
