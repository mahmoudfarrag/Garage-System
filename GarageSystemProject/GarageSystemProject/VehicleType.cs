using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSystemProject
{
    public class VehicleType
    {
        public string Name { get; set; }
        public int CostPerHour { get; set;}

        public VehicleType(string name, int costPerHour)
        {
            Name = name;
            CostPerHour = costPerHour;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
