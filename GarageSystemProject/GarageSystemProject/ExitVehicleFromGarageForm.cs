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
    public partial class ExitVehicleFromGarageForm : Form
    {
        public ExitVehicleFromGarageForm()
        {
            InitializeComponent();
        }

        private void ExitVehicleFromGarageForm_Load(object sender, EventArgs e)
        {
            fillComboBoxGarages();
        }
        public void fillComboBoxGarages()
        {
            comboBoxGarages.DisplayMember = nameof(Garage.Name);
            comboBoxGarages.DataSource = SystemData.Garages.ToList();
        }
        private void buttonExitVehicle_Click(object sender, EventArgs e)
        {
            Garage selectedGarage = (Garage)comboBoxGarages.SelectedItem;
            if(selectedGarage == null)
            {
                MessageBox.Show("There's no garages in the system");
            }
            string ExitVehicleNum = textBoxVehicleNum.Text;
            DateTime ExitDate = dateTimePickerExitDate.Value;
            if (ExitVehicleNum != string.Empty)
            {
                selectedGarage.ExitVehicle(ExitVehicleNum, ExitDate);
            }
            else
            {
                MessageBox.Show("Please Enter Vehicle Number");
            }
        }


    }
}
