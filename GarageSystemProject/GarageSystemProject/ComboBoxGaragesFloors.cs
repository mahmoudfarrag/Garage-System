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
    public partial class ComboBoxGaragesFloors : UserControl
    {
        public event EventHandler SelectedFloorChanged;
        public event EventHandler SelectedGarageChanged;
        public Garage SelectedGarage
        {
            get
            {
                return (Garage)comboBoxGarages.SelectedItem;
            }
        }
        public Floor SelectedFloor 
        { 
            get 
            {
                return (Floor) comboBoxFloors.SelectedItem;
            } 
        }
        public ComboBoxGaragesFloors()
        {
            InitializeComponent();
        }

        private void ComboBoxGaragesFloors_Load(object sender, EventArgs e)
        {
            fillComboBoxGarages();
        }
        private void comboBoxGarages_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillComboBoxFloors();
            if (SelectedGarageChanged != null)
                SelectedGarageChanged(this, new EventArgs());
        }
        public void fillComboBoxGarages()
        {
            comboBoxGarages.DisplayMember = nameof(Garage.Name);
            comboBoxGarages.DataSource = SystemData.Garages.ToList();
        }
        public void fillComboBoxFloors()
        {
            Garage selectedGarage = (Garage)comboBoxGarages.SelectedItem;
            comboBoxFloors.DisplayMember = nameof(Floor.Name);
            comboBoxFloors.DataSource = selectedGarage.floors.ToList();
        }
        private void comboBoxFloors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedFloorChanged != null)
                SelectedFloorChanged(this, new EventArgs());
        }
    }
}
