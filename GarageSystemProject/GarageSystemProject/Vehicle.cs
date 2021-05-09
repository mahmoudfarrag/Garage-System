using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSystemProject
{
    public class Vehicle
    {
        public int ID { get; }
        public string Number { get; private set; }
        public string Name { get; private set; }
        public string Color { get; private set; }
        public VehicleType Type { get; private set; }
        public bool IsParked { get; set; }

        public VehicleOwner vehicleOwner { get; }

        static int count = 0;
        public Vehicle(string vehicleNumber, string name, string color, VehicleType type, string ownerName, string ownerNID, string ownerAddress)
        {
            count++;
            ID = count;
            Number = vehicleNumber;
            Name = name;
            Color = color;
            Type = type;
            IsParked = false;


            vehicleOwner = new VehicleOwner(ownerName, ownerNID, ownerAddress);
        }

        public void update(string name, string number, string color, VehicleType type, string ownerName, string ownerNid, string ownerAddress)
        {
            Name = name;
            Number = number;
            Color = color;
            Type = type;
            vehicleOwner.update(ownerName, ownerNid, ownerAddress);
        }
    }
}
