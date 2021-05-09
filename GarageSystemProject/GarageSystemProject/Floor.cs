using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GarageSystemProject
{
    public class Floor
    {
        public int ID { get; }
        public string Name { get; }
        public int MyProperty { get; set; }
        public int numOfParkedVehicles { get; private set; }

        List<VehicleType> AcceptedTypesList;
        List<VehicleEnterOutDetails> VehicleEnterOutDetailsList;

        public IEnumerable<VehicleType> AcceptedTypes { get { return AcceptedTypesList; } }
        public IEnumerable<VehicleEnterOutDetails> VehicleEnterOutDetails { get { return VehicleEnterOutDetailsList; } }
        public int AcceptedTypesCount { get { return AcceptedTypesList.Count; } }


        static int count = 0;
        public Floor(string name)
        {
            count++;
            ID = count;
            Name = name;
            numOfParkedVehicles = 0;
            AcceptedTypesList = new List<VehicleType>();
            VehicleEnterOutDetailsList = new List<VehicleEnterOutDetails>();
        }

        public void AssignType( VehicleType vehicleType )
        {
            AcceptedTypesList.Add(vehicleType);
        }

        public void ClearAcceptedTypesList()
        {
            AcceptedTypesList.Clear();
        }

        public void EnterVehicle(VehicleEnterOutDetails vehicleEnterOutDetails)
        {
            numOfParkedVehicles++;
            VehicleEnterOutDetailsList.Add(vehicleEnterOutDetails);
        }
        public void ExitVehicle()
        {
            numOfParkedVehicles--;
        }

        public bool IsFloorAcceptThisType(VehicleType SearchedVehicletype)
        {
           VehicleType result = AcceptedTypesList.Find(vehicleType => vehicleType == SearchedVehicletype);
            return (result == null) ? false : true;
        }

        public void EmptyFloor()
        {
            numOfParkedVehicles = 0;
        }

        public void RemoveType(string typeName)
        {
            VehicleType removedType = AcceptedTypesList.Find(type => type.Name == typeName);
            if(removedType != null)
                AcceptedTypesList.Remove(removedType);
        }
    }
}
