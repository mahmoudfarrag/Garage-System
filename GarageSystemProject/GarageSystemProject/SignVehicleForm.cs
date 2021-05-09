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
    public partial class SignVehicleForm : Form
    {
        public SignVehicleForm()
        {
            InitializeComponent();
        }
        private void AddNewVehicleForm_Load(object sender, EventArgs e)
        {
            fillComboBoxVehicleTypes();
            fillDataGridViewSystemVehicles();
            dataGridViewSystemVehicles.ClearSelection();
        }
        private void buttonAddNewVehicle_Click(object sender, EventArgs e)
        {
            string vehicleNum = textBoxVehicleNum.Text;
            string vehicleName = textBoxVehicleName.Text;
            string vehicleColor = textBoxVehicleColor.Text;
            VehicleType vehicleType = (VehicleType) comboBoxVehicleTypes.SelectedItem;
            string ownerName = textBoxOwnerName.Text;
            string ownerNID = textBoxOwnerNID.Text;
            string ownerAddress = textBoxOwnerAddress.Text;
            if(vehicleType == null)
            {
                MessageBox.Show("There's no vehicle types in system");
                return;
            }
            if (vehicleNum == string.Empty || vehicleName == string.Empty || vehicleColor == string.Empty
               || ownerName == string.Empty || ownerNID == string.Empty || ownerAddress == string.Empty )
            {
                MessageBox.Show("Please Fill Empty Fields");
                return;
            }
            Vehicle existVehicle = SystemData.Vehicles.Find(vehicle => vehicle.Number == vehicleNum);
            if(existVehicle == null)
            {
                Vehicle vehicle = new Vehicle(vehicleNum, vehicleName, vehicleColor, vehicleType, ownerName, ownerNID, ownerAddress);
                SystemData.Vehicles.Add(vehicle);
                MessageBox.Show("Added To System Successfully");
            }
            else
            {
                MessageBox.Show("there's a vehicle with the same number in the system");
            }

            fillDataGridViewSystemVehicles();
            dataGridViewSystemVehicles.ClearSelection();
            resetInputValues();
        }
        private void buttonUpdateVehicle_Click(object sender, EventArgs e)
        {
            if(dataGridViewSystemVehicles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select vehicle from table");
                return;
            }
            string updateVehicleName = textBoxVehicleName.Text;
            string updateVehicleNum = textBoxVehicleNum.Text;
            string updateVehicleColor = textBoxVehicleColor.Text;
            VehicleType updatevehicleType = (VehicleType) comboBoxVehicleTypes.SelectedItem;
            string updateownerName = textBoxOwnerName.Text;
            string updateownerNid = textBoxOwnerNID.Text;
            string updateownerAddress = textBoxOwnerAddress.Text;
            if (updateVehicleNum == string.Empty || updateVehicleName == string.Empty || updateVehicleColor == string.Empty
               || updateownerName == string.Empty || updateownerNid == string.Empty || updateownerAddress == string.Empty)
            {
                MessageBox.Show("Please Fill Empty Fields");
                return;
            }
            string selectedVehicleNum = (string)dataGridViewSystemVehicles.SelectedRows[0].Cells[1].Value;
            Vehicle selectedVehicle = SystemData.Vehicles.Find(vehicle => vehicle.Number == selectedVehicleNum);
            if (selectedVehicle.Number == updateVehicleNum)
            {
                selectedVehicle.update(updateVehicleName, updateVehicleNum, updateVehicleColor,
                    updatevehicleType, updateownerName, updateownerNid, updateownerAddress);
            }
            else if(checkUniqueVehicleNum(updateVehicleNum))
            {
                selectedVehicle.update(updateVehicleName, updateVehicleNum, updateVehicleColor,
                    updatevehicleType, updateownerName, updateownerNid, updateownerAddress);
            }
            else
            {
                MessageBox.Show("This vehicle number already used");
            }
            fillDataGridViewSystemVehicles();
            dataGridViewSystemVehicles.ClearSelection();
            resetInputValues();
        }
        private void buttonDeleteVehicle_Click(object sender, EventArgs e)
        {
            if (dataGridViewSystemVehicles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select vehicle from table");
                return;
            }
            string selectedVehicleNum = (string)dataGridViewSystemVehicles.SelectedRows[0].Cells[1].Value;
            Vehicle selectedVehicle = SystemData.Vehicles.Find(vehicle => vehicle.Number == selectedVehicleNum);
            if (selectedVehicle.IsParked == false)
            {
                SystemData.Vehicles.Remove(selectedVehicle);
                MessageBox.Show("Vehicle Deleted successfully");
            }
            else
            {
                Garage garage = getParkedGarage(selectedVehicle);
                MessageBox.Show($"This vehicle is parked in Garage '{garage.Name}' please exit it first");
            }
            fillDataGridViewSystemVehicles();
            dataGridViewSystemVehicles.ClearSelection();
            resetInputValues();
        }

        private Garage getParkedGarage(Vehicle selectedVehicle)
        {
            foreach (Garage garage in SystemData.Garages)
            {
                foreach (VehicleEnterOutDetails vehicleEnterOutDetails in garage.VehicleEnterOutDetails)
                {
                    if (vehicleEnterOutDetails.Vehicle == selectedVehicle && vehicleEnterOutDetails.ExitDate == null)
                        return garage;
                }
            }
            return null;
        }

        private void dataGridViewSystemVehicles_SelectionChanged(object sender, EventArgs e)
        {
            bool rowIsEmpty = true;
            if (dataGridViewSystemVehicles.SelectedRows.Count != 0)
            {
                if (dataGridViewSystemVehicles.SelectedRows[0].Cells[0].Value != null)
                    rowIsEmpty = false;
            }
            if (!rowIsEmpty)
            {
                string vehicleName = (string)dataGridViewSystemVehicles.SelectedRows[0].Cells[0].Value;
                string vehicleNum = (string)dataGridViewSystemVehicles.SelectedRows[0].Cells[1].Value;
                VehicleType vehicleType = (VehicleType)dataGridViewSystemVehicles.SelectedRows[0].Cells[2].Value;
                string vehicleColor = (string)dataGridViewSystemVehicles.SelectedRows[0].Cells[3].Value;
                string ownerName = (string)dataGridViewSystemVehicles.SelectedRows[0].Cells[4].Value;
                string ownerNid = (string)dataGridViewSystemVehicles.SelectedRows[0].Cells[5].Value;
                string ownerAddress = (string)dataGridViewSystemVehicles.SelectedRows[0].Cells[6].Value;

                textBoxVehicleName.Text = vehicleName;
                textBoxVehicleNum.Text = vehicleNum;
                textBoxVehicleColor.Text = vehicleColor;
                comboBoxVehicleTypes.SelectedItem = vehicleType;
                textBoxOwnerName.Text = ownerName;
                textBoxOwnerNID.Text = ownerNid;
                textBoxOwnerAddress.Text = ownerAddress;
            }
        }

        private void fillComboBoxVehicleTypes()
        {
            comboBoxVehicleTypes.DisplayMember = nameof(VehicleType.Name);
            comboBoxVehicleTypes.DataSource = SystemData.VehicleTypes;
        }
        private void fillDataGridViewSystemVehicles() 
        {
            if (SystemData.Vehicles.Count == 0)
            {
                MsgSystemHaasNoVehicles.Visible = true;
                dataGridViewSystemVehicles.Visible = false;
                labelNumOfVehicles.Visible = false;
            }
            else
            {
                MsgSystemHaasNoVehicles.Visible = false;
                dataGridViewSystemVehicles.Visible = true;
                labelNumOfVehicles.Visible = true;
                labelNumOfVehicles.Text = $"Number of vehicles: {SystemData.Vehicles.Count}";
                int currentRow = 0;
                dataGridViewSystemVehicles.Rows.Clear();
                foreach (Vehicle vehicle in SystemData.Vehicles)
                {
                    dataGridViewSystemVehicles.Rows.Add();
                    dataGridViewSystemVehicles.Rows[currentRow].Cells[0].Value = vehicle.Name;
                    dataGridViewSystemVehicles.Rows[currentRow].Cells[1].Value = vehicle.Number;
                    dataGridViewSystemVehicles.Rows[currentRow].Cells[2].Value = vehicle.Type;
                    dataGridViewSystemVehicles.Rows[currentRow].Cells[3].Value = vehicle.Color;
                    dataGridViewSystemVehicles.Rows[currentRow].Cells[4].Value = vehicle.vehicleOwner.Name;
                    dataGridViewSystemVehicles.Rows[currentRow].Cells[5].Value = vehicle.vehicleOwner.NID;
                    dataGridViewSystemVehicles.Rows[currentRow].Cells[6].Value = vehicle.vehicleOwner.Address;
                    currentRow++;
                }
            }
        }

        private void resetInputValues()
        {
            textBoxVehicleNum.Text = textBoxVehicleName.Text = textBoxVehicleColor.Text = string.Empty;
            textBoxOwnerName.Text = textBoxOwnerNID.Text = textBoxOwnerAddress.Text = string.Empty;
        }

        private bool checkUniqueVehicleNum(string vehicleNum)
        {
            Vehicle existVehicle = SystemData.Vehicles.Find(vehicle => vehicle.Number == vehicleNum);
            return existVehicle == null ? true : false;
        }

        
    }
}
