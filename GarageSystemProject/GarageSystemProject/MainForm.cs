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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Side menu
        private void HideSubMenus()
        {
            panelAddSubMenu.Visible = false;
            panelManageVehicleSubMenu.Visible = false;
        }
        private void ShowSubMenus(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ShowSubMenus(panelAddSubMenu);
        }
        private void buttonManageVehicle_Click(object sender, EventArgs e)
        {
            ShowSubMenus(panelManageVehicleSubMenu);
        }
        #endregion

        private Form activeFrom = null;
        private void openChildForm(Form childForm)
        {
            if (activeFrom != null)
                activeFrom.Close();
            activeFrom = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.AutoScroll = true;
            panelChildFormContainer.Controls.Add(childForm);
            panelChildFormContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonManageGarage_Click(object sender, EventArgs e)
        {
            ManageGarageForm manageGarageForm = new ManageGarageForm();
            openChildForm(manageGarageForm);
        }
        private void buttonManageFloor_Click(object sender, EventArgs e)
        {
            ManageFloorsForm manageFloorsForm = new ManageFloorsForm();
            manageFloorsForm.AddVehicleTypeClicked += ManageFloorsForm_AddVehicleTypeClicked;
            openChildForm(manageFloorsForm);
        }

        

        private void buttonManageVehicleType_Click(object sender, EventArgs e)
        {
            ManageVehicleTypeForm manageVehicleTypeForm = new ManageVehicleTypeForm();
            openChildForm(manageVehicleTypeForm);
        }


        private void buttonAddNewVehicle_Click(object sender, EventArgs e)
        {
            SignVehicleForm addNewVehicleForm = new SignVehicleForm();
            openChildForm(addNewVehicleForm);
        }
        private void buttonEnterVehicle_Click(object sender, EventArgs e)
        {
            EnterVehicleToGarageForm enterVehicleToGarageForm = new EnterVehicleToGarageForm();
            openChildForm(enterVehicleToGarageForm);
            enterVehicleToGarageForm.btnAddNewVehicleClicked += EnterVehicleToGarageForm_btnAddNewVehicleClicked;
            enterVehicleToGarageForm.btnAddTypeToFloorClicked += EnterVehicleToGarageForm_btnAddTypeToFloorClicked;
        }
        private void buttonExitVehicle_Click(object sender, EventArgs e)
        {
            ExitVehicleFromGarageForm exitVehicleFromGarageForm = new ExitVehicleFromGarageForm();
            openChildForm(exitVehicleFromGarageForm);
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            GarageReportsForm garageReportsForm = new GarageReportsForm();
            openChildForm(garageReportsForm);
            HideSubMenus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (activeFrom != null)
                activeFrom.Close();
        }
        private void EnterVehicleToGarageForm_btnAddTypeToFloorClicked(object sender, EventArgs e)
        {
            ManageFloorsForm manageFloorsForm = new ManageFloorsForm();
            manageFloorsForm.AddVehicleTypeClicked += ManageFloorsForm_AddVehicleTypeClicked;
            openChildForm(manageFloorsForm);
        }
        private void EnterVehicleToGarageForm_btnAddNewVehicleClicked(object sender, EventArgs e)
        {
            SignVehicleForm addNewVehicleForm = new SignVehicleForm();
            openChildForm(addNewVehicleForm);
        }

        private void ManageFloorsForm_AddVehicleTypeClicked(object sender, EventArgs e)
        {
            ManageVehicleTypeForm manageVehicleTypeForm = new ManageVehicleTypeForm();
            openChildForm(manageVehicleTypeForm);
        }
    }
}
