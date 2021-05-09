
namespace GarageSystemProject
{
    partial class ManageGarageForm
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
            this.labelGarageName = new System.Windows.Forms.Label();
            this.textBoxGarageName = new System.Windows.Forms.TextBox();
            this.labelNumOfFloors = new System.Windows.Forms.Label();
            this.numericUpDownNumOfFloors = new System.Windows.Forms.NumericUpDown();
            this.buttonAddGarage = new System.Windows.Forms.Button();
            this.dataGridViewGaragesDetails = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsgNoGaragesInSystem = new System.Windows.Forms.Label();
            this.buttonUpdateGarage = new System.Windows.Forms.Button();
            this.buttonDeleteGarage = new System.Windows.Forms.Button();
            this.dataGridViewGarageParkedVehicles = new System.Windows.Forms.DataGridView();
            this.VehicleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerNid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsgGarageEmpty = new System.Windows.Forms.Label();
            this.MsgSelectGarageToShowDetails = new System.Windows.Forms.Label();
            this.labelNumOfParkedVehicles = new System.Windows.Forms.Label();
            this.buttonEmptyGarage = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfFloors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGaragesDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGarageParkedVehicles)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGarageName
            // 
            this.labelGarageName.AutoSize = true;
            this.labelGarageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGarageName.Location = new System.Drawing.Point(68, 154);
            this.labelGarageName.Name = "labelGarageName";
            this.labelGarageName.Size = new System.Drawing.Size(109, 20);
            this.labelGarageName.TabIndex = 0;
            this.labelGarageName.Text = "Garage Name";
            // 
            // textBoxGarageName
            // 
            this.textBoxGarageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGarageName.Location = new System.Drawing.Point(237, 154);
            this.textBoxGarageName.Name = "textBoxGarageName";
            this.textBoxGarageName.Size = new System.Drawing.Size(195, 26);
            this.textBoxGarageName.TabIndex = 1;
            // 
            // labelNumOfFloors
            // 
            this.labelNumOfFloors.AutoSize = true;
            this.labelNumOfFloors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumOfFloors.Location = new System.Drawing.Point(68, 227);
            this.labelNumOfFloors.Name = "labelNumOfFloors";
            this.labelNumOfFloors.Size = new System.Drawing.Size(131, 20);
            this.labelNumOfFloors.TabIndex = 2;
            this.labelNumOfFloors.Text = "Number of Floors";
            // 
            // numericUpDownNumOfFloors
            // 
            this.numericUpDownNumOfFloors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNumOfFloors.Location = new System.Drawing.Point(237, 221);
            this.numericUpDownNumOfFloors.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownNumOfFloors.Name = "numericUpDownNumOfFloors";
            this.numericUpDownNumOfFloors.Size = new System.Drawing.Size(195, 26);
            this.numericUpDownNumOfFloors.TabIndex = 3;
            this.numericUpDownNumOfFloors.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAddGarage
            // 
            this.buttonAddGarage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.buttonAddGarage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGarage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddGarage.ForeColor = System.Drawing.Color.White;
            this.buttonAddGarage.Location = new System.Drawing.Point(124, 309);
            this.buttonAddGarage.Name = "buttonAddGarage";
            this.buttonAddGarage.Size = new System.Drawing.Size(130, 36);
            this.buttonAddGarage.TabIndex = 4;
            this.buttonAddGarage.Text = "Add ";
            this.buttonAddGarage.UseVisualStyleBackColor = false;
            this.buttonAddGarage.Click += new System.EventHandler(this.buttonAddGarage_Click);
            // 
            // dataGridViewGaragesDetails
            // 
            this.dataGridViewGaragesDetails.AllowUserToAddRows = false;
            this.dataGridViewGaragesDetails.AllowUserToDeleteRows = false;
            this.dataGridViewGaragesDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.dataGridViewGaragesDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGaragesDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewGaragesDetails.Location = new System.Drawing.Point(500, 142);
            this.dataGridViewGaragesDetails.Name = "dataGridViewGaragesDetails";
            this.dataGridViewGaragesDetails.ReadOnly = true;
            this.dataGridViewGaragesDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGaragesDetails.Size = new System.Drawing.Size(343, 149);
            this.dataGridViewGaragesDetails.TabIndex = 5;
            this.dataGridViewGaragesDetails.SelectionChanged += new System.EventHandler(this.dataGridViewGaragesDetails_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Garage Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Number Of Floor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // MsgNoGaragesInSystem
            // 
            this.MsgNoGaragesInSystem.AutoSize = true;
            this.MsgNoGaragesInSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgNoGaragesInSystem.ForeColor = System.Drawing.Color.Maroon;
            this.MsgNoGaragesInSystem.Location = new System.Drawing.Point(559, 192);
            this.MsgNoGaragesInSystem.Name = "MsgNoGaragesInSystem";
            this.MsgNoGaragesInSystem.Size = new System.Drawing.Size(242, 20);
            this.MsgNoGaragesInSystem.TabIndex = 6;
            this.MsgNoGaragesInSystem.Text = "There\'s no garages in the system";
            // 
            // buttonUpdateGarage
            // 
            this.buttonUpdateGarage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.buttonUpdateGarage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateGarage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateGarage.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateGarage.Location = new System.Drawing.Point(302, 308);
            this.buttonUpdateGarage.Name = "buttonUpdateGarage";
            this.buttonUpdateGarage.Size = new System.Drawing.Size(130, 37);
            this.buttonUpdateGarage.TabIndex = 7;
            this.buttonUpdateGarage.Text = "Update ";
            this.buttonUpdateGarage.UseVisualStyleBackColor = false;
            this.buttonUpdateGarage.Click += new System.EventHandler(this.buttonUpdateGarage_Click);
            // 
            // buttonDeleteGarage
            // 
            this.buttonDeleteGarage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.buttonDeleteGarage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteGarage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteGarage.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteGarage.Location = new System.Drawing.Point(481, 308);
            this.buttonDeleteGarage.Name = "buttonDeleteGarage";
            this.buttonDeleteGarage.Size = new System.Drawing.Size(130, 36);
            this.buttonDeleteGarage.TabIndex = 8;
            this.buttonDeleteGarage.Text = "Delete";
            this.buttonDeleteGarage.UseVisualStyleBackColor = false;
            this.buttonDeleteGarage.Click += new System.EventHandler(this.buttonDeleteGarage_Click);
            // 
            // dataGridViewGarageParkedVehicles
            // 
            this.dataGridViewGarageParkedVehicles.AllowUserToAddRows = false;
            this.dataGridViewGarageParkedVehicles.AllowUserToDeleteRows = false;
            this.dataGridViewGarageParkedVehicles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.dataGridViewGarageParkedVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGarageParkedVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleName,
            this.vehicleNum,
            this.vehicleType,
            this.vehicleColor,
            this.ownerName,
            this.ownerNid,
            this.ownerAddress});
            this.dataGridViewGarageParkedVehicles.Location = new System.Drawing.Point(48, 408);
            this.dataGridViewGarageParkedVehicles.Name = "dataGridViewGarageParkedVehicles";
            this.dataGridViewGarageParkedVehicles.ReadOnly = true;
            this.dataGridViewGarageParkedVehicles.Size = new System.Drawing.Size(823, 255);
            this.dataGridViewGarageParkedVehicles.TabIndex = 10;
            this.dataGridViewGarageParkedVehicles.Visible = false;
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
            // MsgGarageEmpty
            // 
            this.MsgGarageEmpty.AutoSize = true;
            this.MsgGarageEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgGarageEmpty.ForeColor = System.Drawing.Color.Maroon;
            this.MsgGarageEmpty.Location = new System.Drawing.Point(424, 390);
            this.MsgGarageEmpty.Name = "MsgGarageEmpty";
            this.MsgGarageEmpty.Size = new System.Drawing.Size(125, 20);
            this.MsgGarageEmpty.TabIndex = 11;
            this.MsgGarageEmpty.Text = "garage is empty ";
            this.MsgGarageEmpty.Visible = false;
            // 
            // MsgSelectGarageToShowDetails
            // 
            this.MsgSelectGarageToShowDetails.AutoSize = true;
            this.MsgSelectGarageToShowDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgSelectGarageToShowDetails.ForeColor = System.Drawing.Color.Maroon;
            this.MsgSelectGarageToShowDetails.Location = new System.Drawing.Point(386, 410);
            this.MsgSelectGarageToShowDetails.Name = "MsgSelectGarageToShowDetails";
            this.MsgSelectGarageToShowDetails.Size = new System.Drawing.Size(225, 20);
            this.MsgSelectGarageToShowDetails.TabIndex = 12;
            this.MsgSelectGarageToShowDetails.Text = "Select Garage to show details ";
            // 
            // labelNumOfParkedVehicles
            // 
            this.labelNumOfParkedVehicles.AutoSize = true;
            this.labelNumOfParkedVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumOfParkedVehicles.ForeColor = System.Drawing.Color.Black;
            this.labelNumOfParkedVehicles.Location = new System.Drawing.Point(44, 372);
            this.labelNumOfParkedVehicles.Name = "labelNumOfParkedVehicles";
            this.labelNumOfParkedVehicles.Size = new System.Drawing.Size(168, 20);
            this.labelNumOfParkedVehicles.TabIndex = 13;
            this.labelNumOfParkedVehicles.Text = "Number of Vehicles : 0";
            this.labelNumOfParkedVehicles.Visible = false;
            // 
            // buttonEmptyGarage
            // 
            this.buttonEmptyGarage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.buttonEmptyGarage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmptyGarage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmptyGarage.ForeColor = System.Drawing.Color.White;
            this.buttonEmptyGarage.Location = new System.Drawing.Point(737, 363);
            this.buttonEmptyGarage.Name = "buttonEmptyGarage";
            this.buttonEmptyGarage.Size = new System.Drawing.Size(134, 39);
            this.buttonEmptyGarage.TabIndex = 14;
            this.buttonEmptyGarage.Text = "Empty Garage";
            this.buttonEmptyGarage.UseVisualStyleBackColor = false;
            this.buttonEmptyGarage.Visible = false;
            this.buttonEmptyGarage.Click += new System.EventHandler(this.buttonEmptyGarage_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.panelTitle.Controls.Add(this.label10);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(915, 100);
            this.panelTitle.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(372, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(278, 39);
            this.label10.TabIndex = 0;
            this.label10.Text = "Manage Garage";
            // 
            // ManageGarageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 749);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.buttonEmptyGarage);
            this.Controls.Add(this.labelNumOfParkedVehicles);
            this.Controls.Add(this.MsgSelectGarageToShowDetails);
            this.Controls.Add(this.MsgGarageEmpty);
            this.Controls.Add(this.dataGridViewGarageParkedVehicles);
            this.Controls.Add(this.buttonDeleteGarage);
            this.Controls.Add(this.buttonUpdateGarage);
            this.Controls.Add(this.MsgNoGaragesInSystem);
            this.Controls.Add(this.dataGridViewGaragesDetails);
            this.Controls.Add(this.buttonAddGarage);
            this.Controls.Add(this.numericUpDownNumOfFloors);
            this.Controls.Add(this.labelNumOfFloors);
            this.Controls.Add(this.textBoxGarageName);
            this.Controls.Add(this.labelGarageName);
            this.Name = "ManageGarageForm";
            this.Text = "Add New Garage";
            this.Load += new System.EventHandler(this.AddGarageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfFloors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGaragesDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGarageParkedVehicles)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGarageName;
        private System.Windows.Forms.TextBox textBoxGarageName;
        private System.Windows.Forms.Label labelNumOfFloors;
        private System.Windows.Forms.NumericUpDown numericUpDownNumOfFloors;
        private System.Windows.Forms.Button buttonAddGarage;
        private System.Windows.Forms.DataGridView dataGridViewGaragesDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label MsgNoGaragesInSystem;
        private System.Windows.Forms.Button buttonUpdateGarage;
        private System.Windows.Forms.Button buttonDeleteGarage;
        private System.Windows.Forms.DataGridView dataGridViewGarageParkedVehicles;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerNid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerAddress;
        private System.Windows.Forms.Label MsgGarageEmpty;
        private System.Windows.Forms.Label MsgSelectGarageToShowDetails;
        private System.Windows.Forms.Label labelNumOfParkedVehicles;
        private System.Windows.Forms.Button buttonEmptyGarage;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label10;
    }
}