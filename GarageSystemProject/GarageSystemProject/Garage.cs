using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageSystemProject
{
    public class Garage
    {
        static int count = 0;
        private List<Floor> floorsList;
        private List<VehicleEnterOutDetails> VehicleEnterOutDetailsList;
        public int ID { get; }
        public string Name { get; set; }
        public int numOfParkedVehicles { get; private set; }
        public IEnumerable<Floor> floors { get { return floorsList; } }
        public int NumOfFloors { get { return floorsList.Count; } }
        public IEnumerable<VehicleEnterOutDetails> VehicleEnterOutDetails { get { return VehicleEnterOutDetailsList; } }

        public int countOfVehicleEnterOutDetails
        {
            get
            {
                return VehicleEnterOutDetailsList.Count;
            }
        }

        public Garage(string name)
        {
            count++;
            ID = count;
            Name = name;
            numOfParkedVehicles = 0;
            floorsList = new List<Floor>();
            VehicleEnterOutDetailsList = new List<VehicleEnterOutDetails>();
        }

        public void AssignFloors(int numOfFloors)
        {
            if (numOfFloors <= 0)
                numOfFloors = 1;

            floorsList.Clear();
            for (int i = 0; i < numOfFloors; i++)
            {
                Floor newFloor = new Floor($"Floor-{i+1}");
                floorsList.Add(newFloor);
            }
        }
        public void EnterVehicle(Vehicle vehicle, DateTime enteredDate, Floor selectedFloor)
        {
            VehicleEnterOutDetails vehicleEnterOutDetails = new VehicleEnterOutDetails(vehicle, enteredDate, selectedFloor);
            VehicleEnterOutDetailsList.Add(vehicleEnterOutDetails);
            selectedFloor.EnterVehicle(vehicleEnterOutDetails);
            numOfParkedVehicles++;

            vehicle.IsParked = true;
            MessageBox.Show("Vehicle Entered Sucessfully");
        }


        public void ExitVehicle(string ExitVehicleNum, DateTime ExitDate)
        {
            bool isFound = false;
            foreach (VehicleEnterOutDetails vehicleEnterOutDetails in VehicleEnterOutDetails)
            {
                if (vehicleEnterOutDetails.Vehicle.Number == ExitVehicleNum && vehicleEnterOutDetails.ExitDate == null)
                {
                    isFound = true;
                    if(ExitDate < vehicleEnterOutDetails.EnterDate)
                    {
                        MessageBox.Show("Can't exit vehicle with this date");
                        return;
                    }
                    vehicleEnterOutDetails.ExitDate = ExitDate;
                    vehicleEnterOutDetails.Floor.ExitVehicle();
                    computeCost(vehicleEnterOutDetails);
                    vehicleEnterOutDetails.Vehicle.IsParked = false;
                    numOfParkedVehicles--;
                    MessageBox.Show("Vehicle Exit Successfully");
                    return;
                }
            }
            if (isFound == false)
                MessageBox.Show("This Vehicle Not Parked in This Garage ");
        }

        private void computeCost(VehicleEnterOutDetails vehicleEnterOutDetails)
        {
            int costPerHour = vehicleEnterOutDetails.Vehicle.Type.CostPerHour;
            TimeSpan diffTime = (TimeSpan)(vehicleEnterOutDetails.ExitDate - vehicleEnterOutDetails.EnterDate);
            double totHours = diffTime.TotalHours;
            double totCost = Math.Ceiling(totHours * costPerHour);
            MessageBox.Show($"Total Cost = {totCost}");
        }

        public void EmptyGarage()
        {
            foreach (VehicleEnterOutDetails vehicleEnterOutDetails in VehicleEnterOutDetails)
            {
                if (vehicleEnterOutDetails.Vehicle.IsParked)
                {
                    vehicleEnterOutDetails.ExitDate = DateTime.Now;
                    vehicleEnterOutDetails.Vehicle.IsParked = false;
                }
            }
            foreach (Floor floor in floorsList)
            {
                floor.EmptyFloor();
            }
            numOfParkedVehicles = 0;
        }

    }
}
