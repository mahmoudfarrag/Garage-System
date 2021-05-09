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
    public partial class ManageFloorsForm : Form
    {
        public event EventHandler AddVehicleTypeClicked;
        public ManageFloorsForm()
        {
            InitializeComponent();
            comboBoxGaragesFloors.SelectedFloorChanged += ComboBoxGaragesFloors_SelectedFloorChanged;
        }

        private void ComboBoxGaragesFloors_SelectedFloorChanged(object sender, EventArgs e)
        {
            fillCheckedListBoxVehicleTypes();
        }

        private void AssignVehicleTypesToFloorForm_Load(object sender, EventArgs e)
        {
            fillCheckedListBoxVehicleTypes();
        }
        private void buttonAssignTypes_Click(object sender, EventArgs e)
        {

            Floor selectedFloor = comboBoxGaragesFloors.SelectedFloor;
            if (selectedFloor == null)
            {
                MessageBox.Show("There's no garages in the system");
                return;
            }
            if (SystemData.VehicleTypes.Count == 0)
            {
                MessageBox.Show("There's no vehicles types in the system");
                return;
            }
            selectedFloor.ClearAcceptedTypesList();
            foreach (VehicleType vehicleType in checkedListBoxVehicleTypes.CheckedItems)
            {
                selectedFloor.AssignType(vehicleType);
            }
            MessageBox.Show("Floor types updated");
        }
        private void fillCheckedListBoxVehicleTypes()
        {
            if(SystemData.VehicleTypes.Count == 0)
            {
                MsgNoVehicleTypeInSystem.Visible = true;
                buttonAddVehicleType.Visible = true;
                checkedListBoxVehicleTypes.Visible = false;
                labelChooseVehicleTypeForFloor.Visible = false;
            }
            else
            {
                MsgNoVehicleTypeInSystem.Visible = false;
                buttonAddVehicleType.Visible = false;
                checkedListBoxVehicleTypes.Visible = true;
                labelChooseVehicleTypeForFloor.Visible = true;
            }
            Floor selectedFloor = comboBoxGaragesFloors.SelectedFloor;

            if (selectedFloor == null)
                return;
            
            checkedListBoxVehicleTypes.Items.Clear();
            
            foreach (VehicleType vehicleType in SystemData.VehicleTypes)
            {
                checkedListBoxVehicleTypes.Items.Add(vehicleType);
                foreach (VehicleType acceptedVehicleType in selectedFloor.AcceptedTypes)
                {
                    int lastChkLstBoxIndex = checkedListBoxVehicleTypes.Items.Count - 1;
                    if (vehicleType.Name == acceptedVehicleType.Name)
                        checkedListBoxVehicleTypes.SetItemChecked(lastChkLstBoxIndex, true);
                }
            }
        }

        private void buttonAddVehicleType_Click(object sender, EventArgs e)
        {
            if(AddVehicleTypeClicked != null)
            AddVehicleTypeClicked(this, new EventArgs());
        }
    }
}
