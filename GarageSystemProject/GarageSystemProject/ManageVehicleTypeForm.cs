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
    public partial class ManageVehicleTypeForm : Form
    {
        public ManageVehicleTypeForm()
        {
            InitializeComponent();
        }
        private void AddVehicleTypeForm_Load(object sender, EventArgs e)
        {
            fillDataGridViewTypesCost();
            dataGridViewTypesCost.ClearSelection();
        }
        private void buttonAddVehicleType_Click(object sender, EventArgs e)
        {
            string TypeName = textBoxVehicleType.Text;
            int costPerHour = (int)numericUpDownCostPerHour.Value;
            if (TypeName == string.Empty)
            {
                MessageBox.Show("Enter Type name");
                return;
            }
            VehicleType ExistVehicleType = SystemData.VehicleTypes.Find(vType => vType.Name == TypeName);
            if(ExistVehicleType != null)
            {
                MessageBox.Show("This vehicle type exist already");
                return;
            }
            VehicleType vehicleType = new VehicleType(TypeName, costPerHour);
            SystemData.VehicleTypes.Add(vehicleType);
            MessageBox.Show("Vehicle Type Added Successfully");
            resetInputValues();
            fillDataGridViewTypesCost();
            dataGridViewTypesCost.ClearSelection();
        }
        private void buttonUpdateType_Click(object sender, EventArgs e)
        {
            if(dataGridViewTypesCost.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select Type To update");
                return;
            }
            string TypeName = (string)dataGridViewTypesCost.SelectedRows[0].Cells[0].Value;
            string newTypeName = textBoxVehicleType.Text;
            int newCostPerHour = (int) numericUpDownCostPerHour.Value;
            VehicleType selectedVehicleType = SystemData.VehicleTypes.Find(vType => vType.Name == TypeName);
            if (TypeName == newTypeName)
            {
                selectedVehicleType.CostPerHour = newCostPerHour;
                MessageBox.Show("Cost updated Successfully");
            }
            else if(checkUniqueVehicleTypeName(newTypeName))
            {
                Vehicle vehicleWithSameType = SystemData.Vehicles.Find(vehicle => vehicle.Type.Name == TypeName);
                selectedVehicleType.Name = newTypeName;
                selectedVehicleType.CostPerHour = newCostPerHour;
                MessageBox.Show("Type updated Successfully");
            }
            else
            {
                MessageBox.Show("This type name already used");
            }
            resetInputValues();
            fillDataGridViewTypesCost();
            dataGridViewTypesCost.ClearSelection();
        }
        private void buttonDeleteType_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypesCost.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select Type To delete");
                return;
            }
            string TypeName = (string)dataGridViewTypesCost.SelectedRows[0].Cells[0].Value;
            VehicleType selectedVehicleType = SystemData.VehicleTypes.Find(vType => vType.Name == TypeName);
            Vehicle vehicleWithSameType = SystemData.Vehicles.Find(vehicle => vehicle.Type.Name == TypeName);
            if (vehicleWithSameType == null)
            {
                SystemData.VehicleTypes.Remove(selectedVehicleType);
                removeVehicleTypeFromAllSystemfloors(TypeName);
                MessageBox.Show("Type deleted successfully");
            }
            else
            {
                DialogResult result = MessageBox.Show("there are vehicles with this type in system all data will be deleted sure?", "Warning", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    for (int i = 0; i < SystemData.Vehicles.Count; i++)
                    {
                        if(SystemData.Vehicles[i].Type.Name == TypeName) 
                        {
                            SystemData.Vehicles.RemoveAt(i);
                            i--;
                        }
                    }
                    removeVehicleTypeFromAllSystemfloors(TypeName);
                    SystemData.VehicleTypes.Remove(selectedVehicleType);
                    MessageBox.Show("Type and all vehicles with same type removed from system successfully");
                }
            }
            resetInputValues();
            fillDataGridViewTypesCost();
            dataGridViewTypesCost.ClearSelection();
        }

        private void removeVehicleTypeFromAllSystemfloors(string typeName)
        {
            foreach (Garage garage in SystemData.Garages)
            {
                foreach (Floor floor in garage.floors)
                {
                    floor.RemoveType(typeName);
                }
            }
        }

        private void dataGridViewTypesCost_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTypesCost.SelectedRows.Count != 0)
            {
                string TypeName = null;
                int costPerHour = 0;
                if (dataGridViewTypesCost.SelectedRows[0].Cells[0].Value != null)
                    TypeName = (string)dataGridViewTypesCost.SelectedRows[0].Cells[0].Value;
                if (dataGridViewTypesCost.SelectedRows[0].Cells[1].Value != null)
                    costPerHour = (int)dataGridViewTypesCost.SelectedRows[0].Cells[1].Value;
                textBoxVehicleType.Text = TypeName;
                numericUpDownCostPerHour.Value = Convert.ToDecimal(costPerHour);
            }

        }
        private void fillDataGridViewTypesCost()
        {
            dataGridViewTypesCost.Rows.Clear();
            int currentRow = 0;
            if (SystemData.VehicleTypes.Count == 0)
            {
                dataGridViewTypesCost.Visible = false;
                MsgNoVehiclesTypesInSystem.Visible = true;
            }
            else
            {
                dataGridViewTypesCost.Visible = true;
                MsgNoVehiclesTypesInSystem.Visible = false;
            }
                

            foreach (VehicleType vehicleType in SystemData.VehicleTypes)
            {
                dataGridViewTypesCost.Rows.Add();
                dataGridViewTypesCost.Rows[currentRow].Cells[0].Value = vehicleType.Name;
                dataGridViewTypesCost.Rows[currentRow].Cells[1].Value = vehicleType.CostPerHour;
                currentRow++;
            }
        }
        private void resetInputValues()
        {
            textBoxVehicleType.Text = string.Empty;
            numericUpDownCostPerHour.Value = 0;
        }
        private bool checkUniqueVehicleTypeName(string newVehicleType)
        {
            VehicleType foundedVehicleType = SystemData.VehicleTypes.Find(vehicleType => vehicleType.Name == newVehicleType);

            return foundedVehicleType == null ? true : false;
        }
    }
}
