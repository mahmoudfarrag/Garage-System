
namespace GarageSystemProject
{
    partial class EnterVehicleToGarageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEnterVehicleToGarage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVehicleNum = new System.Windows.Forms.TextBox();
            this.ErrMsgVehicleNotFound = new System.Windows.Forms.Label();
            this.buttonAddNewVehicle = new System.Windows.Forms.Button();
            this.ErrMsgNoTypesInFloor = new System.Windows.Forms.Label();
            this.listBoxAcceptedVehicleTypes = new System.Windows.Forms.ListBox();
            this.labelAcceptedVehicleTypes = new System.Windows.Forms.Label();
            this.dateTimePickerEnterDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewFloorParkedVehicles = new System.Windows.Forms.DataGridView();
            this.VehicleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerNid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNumOfParkedVehicles = new System.Windows.Forms.Label();
            this.MsgFloorHasNoVehicles = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddTypeToFloor = new System.Windows.Forms.Button();
            this.GaragesFloors = new GarageSystemProject.ComboBoxGaragesFloors();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloorParkedVehicles)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEnterVehicleToGarage
            // 
            this.buttonEnterVehicleToGarage.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonEnterVehicleToGarage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnterVehicleToGarage.Enabled = false;
            this.buttonEnterVehicleToGarage.FlatAppearance.BorderSize = 0;
            this.buttonEnterVehicleToGarage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnterVehicleToGarage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnterVehicleToGarage.ForeColor = System.Drawing.Color.White;
            this.buttonEnterVehicleToGarage.Location = new System.Drawing.Point(188, 356);
            this.buttonEnterVehicleToGarage.Name = "buttonEnterVehicleToGarage";
            this.buttonEnterVehicleToGarage.Size = new System.Drawing.Size(144, 49);
            this.buttonEnterVehicleToGarage.TabIndex = 0;
            this.buttonEnterVehicleToGarage.Text = "Enter";
            this.buttonEnterVehicleToGarage.UseVisualStyleBackColor = false;
            this.buttonEnterVehicleToGarage.Click += new System.EventHandler(this.buttonEnterVehicleToGarage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vehicle number";
            // 
            // textBoxVehicleNum
            // 
            this.textBoxVehicleNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVehicleNum.Location = new System.Drawing.Point(172, 208);
            this.textBoxVehicleNum.Name = "textBoxVehicleNum";
            this.textBoxVehicleNum.Size = new System.Drawing.Size(180, 26);
            this.textBoxVehicleNum.TabIndex = 6;
            // 
            // ErrMsgVehicleNotFound
            // 
            this.ErrMsgVehicleNotFound.AutoSize = true;
            this.ErrMsgVehicleNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrMsgVehicleNotFound.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrMsgVehicleNotFound.Location = new System.Drawing.Point(17, 309);
            this.ErrMsgVehicleNotFound.Name = "ErrMsgVehicleNotFound";
            this.ErrMsgVehicleNotFound.Size = new System.Drawing.Size(293, 20);
            this.ErrMsgVehicleNotFound.TabIndex = 7;
            this.ErrMsgVehicleNotFound.Text = "This vehicle info not stored in the system";
            this.ErrMsgVehicleNotFound.Visible = false;
            // 
            // buttonAddNewVehicle
            // 
            this.buttonAddNewVehicle.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonAddNewVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddNewVehicle.FlatAppearance.BorderSize = 0;
            this.buttonAddNewVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewVehicle.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewVehicle.Location = new System.Drawing.Point(352, 304);
            this.buttonAddNewVehicle.Name = "buttonAddNewVehicle";
            this.buttonAddNewVehicle.Size = new System.Drawing.Size(133, 35);
            this.buttonAddNewVehicle.TabIndex = 8;
            this.buttonAddNewVehicle.Text = "Add new vehicle";
            this.buttonAddNewVehicle.UseVisualStyleBackColor = false;
            this.buttonAddNewVehicle.Visible = false;
            this.buttonAddNewVehicle.Click += new System.EventHandler(this.buttonAddNewVehicle_Click);
            // 
            // ErrMsgNoTypesInFloor
            // 
            this.ErrMsgNoTypesInFloor.AutoSize = true;
            this.ErrMsgNoTypesInFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrMsgNoTypesInFloor.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrMsgNoTypesInFloor.Location = new System.Drawing.Point(510, 193);
            this.ErrMsgNoTypesInFloor.Name = "ErrMsgNoTypesInFloor";
            this.ErrMsgNoTypesInFloor.Size = new System.Drawing.Size(195, 20);
            this.ErrMsgNoTypesInFloor.TabIndex = 10;
            this.ErrMsgNoTypesInFloor.Text = "Floor has no Vehicle types";
            this.ErrMsgNoTypesInFloor.Visible = false;
            // 
            // listBoxAcceptedVehicleTypes
            // 
            this.listBoxAcceptedVehicleTypes.BackColor = System.Drawing.Color.White;
            this.listBoxAcceptedVehicleTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAcceptedVehicleTypes.ForeColor = System.Drawing.Color.Black;
            this.listBoxAcceptedVehicleTypes.FormattingEnabled = true;
            this.listBoxAcceptedVehicleTypes.ItemHeight = 20;
            this.listBoxAcceptedVehicleTypes.Location = new System.Drawing.Point(514, 133);
            this.listBoxAcceptedVehicleTypes.Name = "listBoxAcceptedVehicleTypes";
            this.listBoxAcceptedVehicleTypes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxAcceptedVehicleTypes.Size = new System.Drawing.Size(211, 164);
            this.listBoxAcceptedVehicleTypes.TabIndex = 11;
            this.listBoxAcceptedVehicleTypes.Visible = false;
            // 
            // labelAcceptedVehicleTypes
            // 
            this.labelAcceptedVehicleTypes.AutoSize = true;
            this.labelAcceptedVehicleTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcceptedVehicleTypes.Location = new System.Drawing.Point(510, 110);
            this.labelAcceptedVehicleTypes.Name = "labelAcceptedVehicleTypes";
            this.labelAcceptedVehicleTypes.Size = new System.Drawing.Size(222, 20);
            this.labelAcceptedVehicleTypes.TabIndex = 12;
            this.labelAcceptedVehicleTypes.Text = "Accepted vehicle types in floor";
            this.labelAcceptedVehicleTypes.Visible = false;
            // 
            // dateTimePickerEnterDate
            // 
            this.dateTimePickerEnterDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerEnterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnterDate.Location = new System.Drawing.Point(172, 250);
            this.dateTimePickerEnterDate.Name = "dateTimePickerEnterDate";
            this.dateTimePickerEnterDate.Size = new System.Drawing.Size(180, 26);
            this.dateTimePickerEnterDate.TabIndex = 13;
            // 
            // dataGridViewFloorParkedVehicles
            // 
            this.dataGridViewFloorParkedVehicles.AllowUserToAddRows = false;
            this.dataGridViewFloorParkedVehicles.AllowUserToDeleteRows = false;
            this.dataGridViewFloorParkedVehicles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.dataGridViewFloorParkedVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFloorParkedVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleName,
            this.vehicleNum,
            this.vehicleType,
            this.vehicleColor,
            this.ownerName,
            this.ownerNid,
            this.ownerAddress});
            this.dataGridViewFloorParkedVehicles.Location = new System.Drawing.Point(61, 464);
            this.dataGridViewFloorParkedVehicles.Name = "dataGridViewFloorParkedVehicles";
            this.dataGridViewFloorParkedVehicles.ReadOnly = true;
            this.dataGridViewFloorParkedVehicles.Size = new System.Drawing.Size(823, 218);
            this.dataGridViewFloorParkedVehicles.TabIndex = 14;
            this.dataGridViewFloorParkedVehicles.Visible = false;
            // 
            // VehicleName
            // 
            this.VehicleName.HeaderText = "Vehicle Name";
            this.VehicleName.Name = "VehicleName";
            this.VehicleName.ReadOnly = true;
            this.VehicleName.Width = 120;
            // 
            // vehicleNum
            // 
            this.vehicleNum.HeaderText = "Vehicle Number";
            this.vehicleNum.Name = "vehicleNum";
            this.vehicleNum.ReadOnly = true;
            // 
            // vehicleType
            // 
            this.vehicleType.HeaderText = "Vehicle Type";
            this.vehicleType.Name = "vehicleType";
            this.vehicleType.ReadOnly = true;
            // 
            // vehicleColor
            // 
            this.vehicleColor.HeaderText = "Vehicle Color";
            this.vehicleColor.Name = "vehicleColor";
            this.vehicleColor.ReadOnly = true;
            // 
            // ownerName
            // 
            this.ownerName.HeaderText = "Owner Name";
            this.ownerName.Name = "ownerName";
            this.ownerName.ReadOnly = true;
            this.ownerName.Width = 120;
            // 
            // ownerNid
            // 
            this.ownerNid.HeaderText = "Owner Nid";
            this.ownerNid.Name = "ownerNid";
            this.ownerNid.ReadOnly = true;
            this.ownerNid.Width = 120;
            // 
            // ownerAddress
            // 
            this.ownerAddress.HeaderText = "Owner Address";
            this.ownerAddress.Name = "ownerAddress";
            this.ownerAddress.ReadOnly = true;
            this.ownerAddress.Width = 120;
            // 
            // labelNumOfParkedVehicles
            // 
            this.labelNumOfParkedVehicles.AutoSize = true;
            this.labelNumOfParkedVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumOfParkedVehicles.ForeColor = System.Drawing.Color.Black;
            this.labelNumOfParkedVehicles.Location = new System.Drawing.Point(57, 441);
            this.labelNumOfParkedVehicles.Name = "labelNumOfParkedVehicles";
            this.labelNumOfParkedVehicles.Size = new System.Drawing.Size(177, 20);
            this.labelNumOfParkedVehicles.TabIndex = 16;
            this.labelNumOfParkedVehicles.Text = " Vehicles parked in floor";
            this.labelNumOfParkedVehicles.Visible = false;
            // 
            // MsgFloorHasNoVehicles
            // 
            this.MsgFloorHasNoVehicles.AutoSize = true;
            this.MsgFloorHasNoVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgFloorHasNoVehicles.ForeColor = System.Drawing.Color.Maroon;
            this.MsgFloorHasNoVehicles.Location = new System.Drawing.Point(348, 441);
            this.MsgFloorHasNoVehicles.Name = "MsgFloorHasNoVehicles";
            this.MsgFloorHasNoVehicles.Size = new System.Drawing.Size(213, 20);
            this.MsgFloorHasNoVehicles.TabIndex = 17;
            this.MsgFloorHasNoVehicles.Text = "Floor Has no parked vehicles";
            this.MsgFloorHasNoVehicles.Visible = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.DarkCyan;
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(976, 100);
            this.panelTitle.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(372, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter vehicle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Enter date";
            // 
            // buttonAddTypeToFloor
            // 
            this.buttonAddTypeToFloor.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonAddTypeToFloor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddTypeToFloor.FlatAppearance.BorderSize = 0;
            this.buttonAddTypeToFloor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTypeToFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTypeToFloor.ForeColor = System.Drawing.Color.White;
            this.buttonAddTypeToFloor.Location = new System.Drawing.Point(574, 216);
            this.buttonAddTypeToFloor.Name = "buttonAddTypeToFloor";
            this.buttonAddTypeToFloor.Size = new System.Drawing.Size(90, 30);
            this.buttonAddTypeToFloor.TabIndex = 21;
            this.buttonAddTypeToFloor.Text = "Add type";
            this.buttonAddTypeToFloor.UseVisualStyleBackColor = false;
            this.buttonAddTypeToFloor.Visible = false;
            this.buttonAddTypeToFloor.Click += new System.EventHandler(this.buttonAddTypeToFloor_Click);
            // 
            // GaragesFloors
            // 
            this.GaragesFloors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.GaragesFloors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GaragesFloors.Location = new System.Drawing.Point(12, 110);
            this.GaragesFloors.Name = "GaragesFloors";
            this.GaragesFloors.Size = new System.Drawing.Size(354, 95);
            this.GaragesFloors.TabIndex = 9;
            this.GaragesFloors.SelectedFloorChanged += new System.EventHandler(this.GaragesFloors_SelectedFloorChanged);
            this.GaragesFloors.SelectedGarageChanged += new System.EventHandler(this.GaragesFloors_SelectedGarageChanged);
            // 
            // EnterVehicleToGarageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(976, 749);
            this.Controls.Add(this.buttonAddTypeToFloor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.MsgFloorHasNoVehicles);
            this.Controls.Add(this.labelNumOfParkedVehicles);
            this.Controls.Add(this.dataGridViewFloorParkedVehicles);
            this.Controls.Add(this.dateTimePickerEnterDate);
            this.Controls.Add(this.labelAcceptedVehicleTypes);
            this.Controls.Add(this.listBoxAcceptedVehicleTypes);
            this.Controls.Add(this.ErrMsgNoTypesInFloor);
            this.Controls.Add(this.GaragesFloors);
            this.Controls.Add(this.buttonAddNewVehicle);
            this.Controls.Add(this.ErrMsgVehicleNotFound);
            this.Controls.Add(this.textBoxVehicleNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonEnterVehicleToGarage);
            this.Name = "EnterVehicleToGarageForm";
            this.Text = "Enter Vehicle To Garage ";
            this.Load += new System.EventHandler(this.EnterVehicleToGarageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloorParkedVehicles)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnterVehicleToGarage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVehicleNum;
        private System.Windows.Forms.Label ErrMsgVehicleNotFound;
        private System.Windows.Forms.Button buttonAddNewVehicle;
        private ComboBoxGaragesFloors GaragesFloors;
        private System.Windows.Forms.Label ErrMsgNoTypesInFloor;
        private System.Windows.Forms.ListBox listBoxAcceptedVehicleTypes;
        private System.Windows.Forms.Label labelAcceptedVehicleTypes;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnterDate;
        private System.Windows.Forms.DataGridView dataGridViewFloorParkedVehicles;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerNid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerAddress;
        private System.Windows.Forms.Label labelNumOfParkedVehicles;
        private System.Windows.Forms.Label MsgFloorHasNoVehicles;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddTypeToFloor;
    }
}