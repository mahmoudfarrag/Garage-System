using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSystemProject
{
    public class VehicleOwner
    {
        public string Name { get; private set; }
        public string NID { get; private set; }
        public string Address { get; private set; }

        public VehicleOwner(string name, string nid, string address)
        {
            Name = name;
            NID = nid;
            Address = address;
        }

        public void update(string name, string nid, string address)
        {
            Name = name;
            NID = nid;
            Address = address;
        }
    }
}
