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
    public partial class ManageGarageForm : Form
    {
        public ManageGarageForm()
        {
            InitializeComponent();
        }
        private void AddGarageForm_Load(object sender, EventArgs e)
        {
            fillDataGridViewGaragesDetails();
            dataGridViewGaragesDetails.ClearSelection();
        }

        private void buttonAddGarage_Click(object sender, EventArgs e)
        {
            string newGarageName = textBoxGarageName.Text;
            if (newGarageName == string.Empty)
            {
                MessageBox.Show("Enter Name of garage");
                return;
            }
            Garage existGarage = SystemData.Garages.Find(garage => garage.Name == newGarageName);
            if (existGarage != null)
            {
                MessageBox.Show("garage name already used");
                return;
            }
            Garage newGarage = new Garage(newGarageName);
            newGarage.AssignFloors((int) numericUpDownNumOfFloors.Value);
            SystemData.Garages.Add(newGarage);
            MessageBox.Show("garage added successfully");
            resetInputValues();
            fillDataGridViewGaragesDetails();
            dataGridViewGaragesDetails.ClearSelection();
        }



        private void dataGridViewGaragesDetails_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridViewGaragesDetails.SelectedRows.Count == 0)
            {
                MsgSelectGarageToShowDetails.Visible = true;
                dataGridViewGarageParkedVehicles.Visible = false;
                MsgGarageEmpty.Visible = false;
                labelNumOfParkedVehicles.Visible = false;
                buttonEmptyGarage.Visible = false;

                return;
            }
            if (dataGridViewGaragesDetails.SelectedRows[0].Cells[0].Value != null
                && dataGridViewGaragesDetails.SelectedRows[0].Cells[1].Value != null)
            {
                string GarageName = (string)dataGridViewGaragesDetails.SelectedRows[0].Cells[0].Value;
                textBoxGarageName.Text = GarageName;
                int NumOfFloors = (int)dataGridViewGaragesDetails.SelectedRows[0].Cells[1].Value;
                numericUpDownNumOfFloors.Value = Convert.ToDecimal(NumOfFloors);
                Garage selectedGarage = SystemData.Garages.Find(garage => garage.Name == GarageName);
                fillDataGridViewGarageParkedVehicles(selectedGarage);
            }
        }

        private void buttonUpdateGarage_Click(object sender, EventArgs e)
        {
            if (dataGridViewGaragesDetails.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select garage to update");
                return;
            }
            string garageName = (string)dataGridViewGaragesDetails.SelectedRows[0].Cells[0].Value;
            string newGarageName = textBoxGarageName.Text;
            int newNumOfFloors = (int)numericUpDownNumOfFloors.Value;
            Garage selectedGarage = SystemData.Garages.Find(Garage => Garage.Name == garageName);

            if(selectedGarage.numOfParkedVehicles == 0)
            {
                if(selectedGarage.Name == newGarageName)
                {
                    selectedGarage.AssignFloors(newNumOfFloors);
                    MessageBox.Show("Number of Floors updated");
                    
                }
                else if (checkUniqueGarageName(newGarageName))
                {
                    selectedGarage.Name = newGarageName;
                    selectedGarage.AssignFloors(newNumOfFloors);
                    MessageBox.Show("Updated Successfully");
                }
                else
                    MessageBox.Show("This garage name already used");
            }
            else
            {
                MessageBox.Show("Please Empty Garage Before Update");
            }


            resetInputValues();
            fillDataGridViewGaragesDetails();
            dataGridViewGaragesDetails.ClearSelection();
        }
        private void buttonDeleteGarage_Click(object sender, EventArgs e)
        {
            if (dataGridViewGaragesDetails.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select garage to delete");
                return;
            }
            string garageName = (string)dataGridViewGaragesDetails.SelectedRows[0].Cells[0].Value;
            Garage foundedGarage = SystemData.Garages.Find(Garage => Garage.Name == garageName);
            if(foundedGarage.numOfParkedVehicles == 0)
            {
                SystemData.Garages.Remove(foundedGarage);
                MessageBox.Show("Garage Deleted Successfully");
            }
            else
                MessageBox.Show("Empty garage before delete");

            resetInputValues();
            fillDataGridViewGaragesDetails();
            dataGridViewGaragesDetails.ClearSelection();
        }

        private bool checkUniqueGarageName(string newGarageName)
        {
            Garage foundedGarage = SystemData.Garages.Find(Garage => Garage.Name == newGarageName);
            
            return foundedGarage == null ? true : false;
        }

        private void resetInputValues()
        {
            textBoxGarageName.Text = string.Empty;
            numericUpDownNumOfFloors.Value = 1;
        }

        private void fillDataGridViewGaragesDetails()
        {
            if (SystemData.Garages.Count == 0)
            {
                MsgNoGaragesInSystem.Visible = true;
                dataGridViewGaragesDetails.Visible = false;
            }
            else
            {
                MsgNoGaragesInSystem.Visible = false;
                dataGridViewGaragesDetails.Visible = true;

                int currentRow = 0;
                dataGridViewGaragesDetails.Rows.Clear();
                foreach (Garage garage in SystemData.Garages)
                {
                    dataGridViewGaragesDetails.Rows.Add();
                    dataGridViewGaragesDetails.Rows[currentRow].Cells[0].Value = garage.Name;
                    dataGridViewGaragesDetails.Rows[currentRow].Cells[1].Value = garage.NumOfFloors;
                    currentRow++;
                }

            }
        }

        private void fillDataGridViewGarageParkedVehicles(Garage selectedGarage)
        {
            if (selectedGarage.numOfParkedVehicles == 0)
            {
                MsgGarageEmpty.Visible = true;
                MsgSelectGarageToShowDetails.Visible = false;
                dataGridViewGarageParkedVehicles.Visible = false;
            }
            else
            {
                MsgGarageEmpty.Visible = false;
                MsgSelectGarageToShowDetails.Visible = false;
                dataGridViewGarageParkedVehicles.Visible = true;
                labelNumOfParkedVehicles.Visible = true;
                buttonEmptyGarage.Visible = true;

                labelNumOfParkedVehicles.Text = $"Number Of Vehicles: {selectedGarage.numOfParkedVehicles}";
                int currentRow = 0;
                dataGridViewGarageParkedVehicles.Rows.Clear();
                foreach (VehicleEnterOutDetails vehicleEnterOutDetails in selectedGarage.VehicleEnterOutDetails)
                {
                    if(vehicleEnterOutDetails.ExitDate == null)
                    {
                        dataGridViewGarageParkedVehicles.Rows.Add();
                        dataGridViewGarageParkedVehicles.Rows[currentRow].Cells[0].Value = vehicleEnterOutDetails.Vehicle.Name;
                        dataGridViewGarageParkedVehicles.Rows[currentRow].Cells[1].Value = vehicleEnterOutDetails.Vehicle.Number;
                        dataGridViewGarageParkedVehicles.Rows[currentRow].Cells[2].Value = vehicleEnterOutDetails.Vehicle.Type;
                        dataGridViewGarageParkedVehicles.Rows[currentRow].Cells[3].Value = vehicleEnterOutDetails.Vehicle.Color;
                        dataGridViewGarageParkedVehicles.Rows[currentRow].Cells[4].Value = vehicleEnterOutDetails.Vehicle.vehicleOwner.Name;
                        dataGridViewGarageParkedVehicles.Rows[currentRow].Cells[5].Value = vehicleEnterOutDetails.Vehicle.vehicleOwner.NID;
                        dataGridViewGarageParkedVehicles.Rows[currentRow].Cells[6].Value = vehicleEnterOutDetails.Vehicle.vehicleOwner.Address;
                        currentRow++;
                    }
                }

            }
        }

        private void buttonEmptyGarage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All parked vehicles exit date set to Today Are you sure to empty the garage?", "Warning", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string garageName = (string)dataGridViewGaragesDetails.SelectedRows[0].Cells[0].Value;
                Garage selectedGarage = SystemData.Garages.Find(Garage => Garage.Name == garageName);
                selectedGarage.EmptyGarage();
                MessageBox.Show("Garage Empted successfully");
                resetInputValues();
                dataGridViewGaragesDetails.ClearSelection();
            }
           
        }
    }
}
