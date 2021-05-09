using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSystemProject
{
    public class VehicleEnterOutDetails
    {
        public Vehicle Vehicle { get; }
        public Floor Floor { get; }
        public DateTime EnterDate { get; }
        public DateTime? ExitDate { get; set; }


        public VehicleEnterOutDetails(Vehicle vehicle, DateTime enterDate, Floor floor)
        {
            Vehicle = vehicle;
            Floor = floor;
            EnterDate = enterDate;
            ExitDate = null;
        }
    }
}
