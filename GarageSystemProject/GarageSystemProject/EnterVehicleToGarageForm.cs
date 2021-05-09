using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageSystemProject
{
    public partial class EnterVehicleToGarageForm : Form
    {
        public event EventHandler btnAddNewVehicleClicked;
        public event EventHandler btnAddTypeToFloorClicked;
        public EnterVehicleToGarageForm()
        {
            InitializeComponent();
        }
        private void GaragesFloors_SelectedGarageChanged(object sender, EventArgs e)
        {
            ErrMsgVehicleNotFound.Visible = false;
            buttonAddNewVehicle.Visible = false;
        }

        private void GaragesFloors_SelectedFloorChanged(object sender, EventArgs e)
        {
            checkSelectedFloorHasAcceptedTypes();
            fillDataGridViewGarageParkedVehicles(GaragesFloors.SelectedFloor);


        }
        private void EnterVehicleToGarageForm_Load(object sender, EventArgs e)
        {
            checkSelectedFloorHasAcceptedTypes();
        }
        private void checkSelectedFloorHasAcceptedTypes()
        {
            if (GaragesFloors.SelectedFloor == null)
                return;
            if (GaragesFloors.SelectedFloor.AcceptedTypesCount == 0)
            {
                ErrMsgNoTypesInFloor.Visible = true;
                buttonAddTypeToFloor.Visible = true;
                buttonEnterVehicleToGarage.Enabled = false;
                labelAcceptedVehicleTypes.Visible = false;
                listBoxAcceptedVehicleTypes.Visible = false;
                buttonAddTypeToFloor.Visible = true;

            }
            else
            {
                ErrMsgNoTypesInFloor.Visible = false;
                buttonAddTypeToFloor.Visible = false;
                buttonEnterVehicleToGarage.Enabled = true;
                labelAcceptedVehicleTypes.Visible = true;
                listBoxAcceptedVehicleTypes.Visible = true;

                listBoxAcceptedVehicleTypes.DataSource = GaragesFloors.SelectedFloor.AcceptedTypes.ToList();
            }
        }


        private void buttonEnterVehicleToGarage_Click(object sender, EventArgs e)
        {
            string vehicleNum = textBoxVehicleNum.Text;
            if (vehicleNum == string.Empty)
            {
                MessageBox.Show("Please Enter Vehicle Number");
                return;
            }

            Vehicle existVehicle = SearchForVehicleInSystemData(vehicleNum);
            

            if(existVehicle == null)
            {
                ErrMsgVehicleNotFound.Visible = true;
                buttonAddNewVehicle.Visible = true;
            }
            else
            {
                EnterVehicleToGarage(existVehicle);
                
            }
        }

        private void buttonAddNewVehicle_Click(object sender, EventArgs e)
        {
            if(btnAddNewVehicleClicked != null)
                btnAddNewVehicleClicked(this, new EventArgs());
        }

        //
        // check functions
        //
        private void EnterVehicleToGarage(Vehicle existVehicle)
        {
            Garage selecetedGarage = GaragesFloors.SelectedGarage;
            Floor selectedFloor = GaragesFloors.SelectedFloor;
            DateTime enteredDate = dateTimePickerEnterDate.Value;
            if (existVehicle.IsParked == false)
            {
                bool typeAccepted = selectedFloor.IsFloorAcceptThisType(existVehicle.Type);
                if (typeAccepted)
                {
                    ErrMsgVehicleNotFound.Visible = false;
                    buttonAddNewVehicle.Visible = false;
                    selecetedGarage.EnterVehicle(existVehicle, enteredDate, selectedFloor);
                }
                else
                {
                    MessageBox.Show($"This Vehicle type is {existVehicle.Type} not match this Floor accepted type");
                }
                fillDataGridViewGarageParkedVehicles(GaragesFloors.SelectedFloor);
            }
            else
            {
                MessageBox.Show("This Vehicle Already Parked in this System");
            }
        }

        Vehicle SearchForVehicleInSystemData(string vehicleNum)
        {
            foreach (Vehicle vehicle in SystemData.Vehicles)
            {
                if (vehicleNum == vehicle.Number)
                {
                    return vehicle;
                }
            }
            return null;
        }
        
        private void fillDataGridViewGarageParkedVehicles(Floor selectedFloor)
        {
            if (selectedFloor.numOfParkedVehicles == 0)
            {
                MsgFloorHasNoVehicles.Visible = true;
                dataGridViewFloorParkedVehicles.Visible = false;
                labelNumOfParkedVehicles.Visible = false;

            }
            else
            {
                MsgFloorHasNoVehicles.Visible = false;
                dataGridViewFloorParkedVehicles.Visible = true;
                labelNumOfParkedVehicles.Visible = true;

                labelNumOfParkedVehicles.Text = $" Vehicles parked in floor: {selectedFloor.numOfParkedVehicles}";
                int currentRow = 0;
                dataGridViewFloorParkedVehicles.Rows.Clear();
                foreach (VehicleEnterOutDetails vehicleEnterOutDetails in selectedFloor.VehicleEnterOutDetails)
                {
                    if (vehicleEnterOutDetails.ExitDate == null)
                    {
                        dataGridViewFloorParkedVehicles.Rows.Add();
                        dataGridViewFloorParkedVehicles.Rows[currentRow].Cells[0].Value = vehicleEnterOutDetails.Vehicle.Name;
                        dataGridViewFloorParkedVehicles.Rows[currentRow].Cells[1].Value = vehicleEnterOutDetails.Vehicle.Number;
                        dataGridViewFloorParkedVehicles.Rows[currentRow].Cells[2].Value = vehicleEnterOutDetails.Vehicle.Type;
                        dataGridViewFloorParkedVehicles.Rows[currentRow].Cells[3].Value = vehicleEnterOutDetails.Vehicle.Color;
                        dataGridViewFloorParkedVehicles.Rows[currentRow].Cells[4].Value = vehicleEnterOutDetails.Vehicle.vehicleOwner.Name;
                        dataGridViewFloorParkedVehicles.Rows[currentRow].Cells[5].Value = vehicleEnterOutDetails.Vehicle.vehicleOwner.NID;
                        dataGridViewFloorParkedVehicles.Rows[currentRow].Cells[6].Value = vehicleEnterOutDetails.Vehicle.vehicleOwner.Address;
                        currentRow++;
                    }
                }

            }
        }

        private void buttonAddTypeToFloor_Click(object sender, EventArgs e)
        {
            if (btnAddTypeToFloorClicked != null)
                btnAddTypeToFloorClicked(this, new EventArgs());
        }
    }
}
