
namespace GarageSystemProject
{
    partial class SignVehicleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxVehicleTypes = new System.Windows.Forms.ComboBox();
            this.groupBoxVehicleDetails = new System.Windows.Forms.GroupBox();
            this.textBoxVehicleName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxVehicleNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVehicleColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxVehicleOwnerDetails = new System.Windows.Forms.GroupBox();
            this.textBoxOwnerAddress = new System.Windows.Forms.TextBox();
            this.textBoxOwnerNID = new System.Windows.Forms.TextBox();
            this.textBoxOwnerName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAddNewVehicle = new System.Windows.Forms.Button();
            this.dataGridViewSystemVehicles = new System.Windows.Forms.DataGridView();
            this.VehicleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerNid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonUpdateVehicle = new System.Windows.Forms.Button();
            this.buttonDeleteVehicle = new System.Windows.Forms.Button();
            this.MsgSystemHaasNoVehicles = new System.Windows.Forms.Label();
            this.labelNumOfVehicles = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxVehicleDetails.SuspendLayout();
            this.groupBoxVehicleOwnerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSystemVehicles)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle Type";
            // 
            // comboBoxVehicleTypes
            // 
            this.comboBoxVehicleTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVehicleTypes.FormattingEnabled = true;
            this.comboBoxVehicleTypes.Location = new System.Drawing.Point(142, 41);
            this.comboBoxVehicleTypes.Name = "comboBoxVehicleTypes";
            this.comboBoxVehicleTypes.Size = new System.Drawing.Size(165, 28);
            this.comboBoxVehicleTypes.TabIndex = 2;
            // 
            // groupBoxVehicleDetails
            // 
            this.groupBoxVehicleDetails.Controls.Add(this.textBoxVehicleName);
            this.groupBoxVehicleDetails.Controls.Add(this.label11);
            this.groupBoxVehicleDetails.Controls.Add(this.textBoxVehicleNum);
            this.groupBoxVehicleDetails.Controls.Add(this.label3);
            this.groupBoxVehicleDetails.Controls.Add(this.textBoxVehicleColor);
            this.groupBoxVehicleDetails.Controls.Add(this.label2);
            this.groupBoxVehicleDetails.Controls.Add(this.label1);
            this.groupBoxVehicleDetails.Controls.Add(this.comboBoxVehicleTypes);
            this.groupBoxVehicleDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVehicleDetails.Location = new System.Drawing.Point(111, 118);
            this.groupBoxVehicleDetails.Name = "groupBoxVehicleDetails";
            this.groupBoxVehicleDetails.Size = new System.Drawing.Size(313, 241);
            this.groupBoxVehicleDetails.TabIndex = 3;
            this.groupBoxVehicleDetails.TabStop = false;
            this.groupBoxVehicleDetails.Text = "Vehicle Details";
            // 
            // textBoxVehicleName
            // 
            this.textBoxVehicleName.Location = new System.Drawing.Point(142, 193);
            this.textBoxVehicleName.Name = "textBoxVehicleName";
            this.textBoxVehicleName.Size = new System.Drawing.Size(165, 26);
            this.textBoxVehicleName.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Vehicle Name";
            // 
            // textBoxVehicleNum
            // 
            this.textBoxVehicleNum.Location = new System.Drawing.Point(142, 141);
            this.textBoxVehicleNum.Name = "textBoxVehicleNum";
            this.textBoxVehicleNum.Size = new System.Drawing.Size(165, 26);
            this.textBoxVehicleNum.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vehicle Number";
            // 
            // textBoxVehicleColor
            // 
            this.textBoxVehicleColor.Location = new System.Drawing.Point(142, 86);
            this.textBoxVehicleColor.Name = "textBoxVehicleColor";
            this.textBoxVehicleColor.Size = new System.Drawing.Size(165, 26);
            this.textBoxVehicleColor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vehicle Color";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vehicle Number";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Vehicle Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Vehicle Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // groupBoxVehicleOwnerDetails
            // 
            this.groupBoxVehicleOwnerDetails.Controls.Add(this.textBoxOwnerAddress);
            this.groupBoxVehicleOwnerDetails.Controls.Add(this.textBoxOwnerNID);
            this.groupBoxVehicleOwnerDetails.Controls.Add(this.textBoxOwnerName);
            this.groupBoxVehicleOwnerDetails.Controls.Add(this.label9);
            this.groupBoxVehicleOwnerDetails.Controls.Add(this.label8);
            this.groupBoxVehicleOwnerDetails.Controls.Add(this.label7);
            this.groupBoxVehicleOwnerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVehicleOwnerDetails.Location = new System.Drawing.Point(568, 118);
            this.groupBoxVehicleOwnerDetails.Name = "groupBoxVehicleOwnerDetails";
            this.groupBoxVehicleOwnerDetails.Size = new System.Drawing.Size(295, 241);
            this.groupBoxVehicleOwnerDetails.TabIndex = 4;
            this.groupBoxVehicleOwnerDetails.TabStop = false;
            this.groupBoxVehicleOwnerDetails.Text = "Owner Details";
            // 
            // textBoxOwnerAddress
            // 
            this.textBoxOwnerAddress.Location = new System.Drawing.Point(109, 153);
            this.textBoxOwnerAddress.Name = "textBoxOwnerAddress";
            this.textBoxOwnerAddress.Size = new System.Drawing.Size(180, 26);
            this.textBoxOwnerAddress.TabIndex = 5;
            // 
            // textBoxOwnerNID
            // 
            this.textBoxOwnerNID.Location = new System.Drawing.Point(115, 89);
            this.textBoxOwnerNID.Name = "textBoxOwnerNID";
            this.textBoxOwnerNID.Size = new System.Drawing.Size(180, 26);
            this.textBoxOwnerNID.TabIndex = 4;
            // 
            // textBoxOwnerName
            // 
            this.textBoxOwnerName.Location = new System.Drawing.Point(109, 23);
            this.textBoxOwnerName.Name = "textBoxOwnerName";
            this.textBoxOwnerName.Size = new System.Drawing.Size(180, 26);
            this.textBoxOwnerName.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "NID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name";
            // 
            // buttonAddNewVehicle
            // 
            this.buttonAddNewVehicle.BackColor = System.Drawing.Color.Firebrick;
            this.buttonAddNewVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewVehicle.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewVehicle.Location = new System.Drawing.Point(205, 381);
            this.buttonAddNewVehicle.Name = "buttonAddNewVehicle";
            this.buttonAddNewVehicle.Size = new System.Drawing.Size(119, 39);
            this.buttonAddNewVehicle.TabIndex = 5;
            this.buttonAddNewVehicle.Text = "Add";
            this.buttonAddNewVehicle.UseVisualStyleBackColor = false;
            this.buttonAddNewVehicle.Click += new System.EventHandler(this.buttonAddNewVehicle_Click);
            // 
            // dataGridViewSystemVehicles
            // 
            this.dataGridViewSystemVehicles.AllowUserToAddRows = false;
            this.dataGridViewSystemVehicles.AllowUserToDeleteRows = false;
            this.dataGridViewSystemVehicles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSystemVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSystemVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSystemVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleName,
            this.vehicleNum,
            this.vehicleType,
            this.vehicleColor,
            this.ownerName,
            this.ownerNid,
            this.ownerAddress});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSystemVehicles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSystemVehicles.Location = new System.Drawing.Point(111, 457);
            this.dataGridViewSystemVehicles.Name = "dataGridViewSystemVehicles";
            this.dataGridViewSystemVehicles.ReadOnly = true;
            this.dataGridViewSystemVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSystemVehicles.Size = new System.Drawing.Size(823, 141);
            this.dataGridViewSystemVehicles.TabIndex = 11;
            this.dataGridViewSystemVehicles.Visible = false;
            this.dataGridViewSystemVehicles.SelectionChanged += new System.EventHandler(this.dataGridViewSystemVehicles_SelectionChanged);
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
            // buttonUpdateVehicle
            // 
            this.buttonUpdateVehicle.BackColor = System.Drawing.Color.Firebrick;
            this.buttonUpdateVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateVehicle.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateVehicle.Location = new System.Drawing.Point(444, 381);
            this.buttonUpdateVehicle.Name = "buttonUpdateVehicle";
            this.buttonUpdateVehicle.Size = new System.Drawing.Size(116, 39);
            this.buttonUpdateVehicle.TabIndex = 12;
            this.buttonUpdateVehicle.Text = "Update";
            this.buttonUpdateVehicle.UseVisualStyleBackColor = false;
            this.buttonUpdateVehicle.Click += new System.EventHandler(this.buttonUpdateVehicle_Click);
            // 
            // buttonDeleteVehicle
            // 
            this.buttonDeleteVehicle.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDeleteVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteVehicle.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteVehicle.Location = new System.Drawing.Point(665, 381);
            this.buttonDeleteVehicle.Name = "buttonDeleteVehicle";
            this.buttonDeleteVehicle.Size = new System.Drawing.Size(116, 39);
            this.buttonDeleteVehicle.TabIndex = 13;
            this.buttonDeleteVehicle.Text = "Delete";
            this.buttonDeleteVehicle.UseVisualStyleBackColor = false;
            this.buttonDeleteVehicle.Click += new System.EventHandler(this.buttonDeleteVehicle_Click);
            // 
            // MsgSystemHaasNoVehicles
            // 
            this.MsgSystemHaasNoVehicles.AutoSize = true;
            this.MsgSystemHaasNoVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgSystemHaasNoVehicles.ForeColor = System.Drawing.Color.Maroon;
            this.MsgSystemHaasNoVehicles.Location = new System.Drawing.Point(426, 457);
            this.MsgSystemHaasNoVehicles.Name = "MsgSystemHaasNoVehicles";
            this.MsgSystemHaasNoVehicles.Size = new System.Drawing.Size(159, 20);
            this.MsgSystemHaasNoVehicles.TabIndex = 6;
            this.MsgSystemHaasNoVehicles.Text = "No vehicles in system";
            this.MsgSystemHaasNoVehicles.Visible = false;
            // 
            // labelNumOfVehicles
            // 
            this.labelNumOfVehicles.AutoSize = true;
            this.labelNumOfVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumOfVehicles.Location = new System.Drawing.Point(107, 434);
            this.labelNumOfVehicles.Name = "labelNumOfVehicles";
            this.labelNumOfVehicles.Size = new System.Drawing.Size(51, 20);
            this.labelNumOfVehicles.TabIndex = 6;
            this.labelNumOfVehicles.Text = "Name";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Firebrick;
            this.panelTitle.Controls.Add(this.label10);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1030, 100);
            this.panelTitle.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(372, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(273, 39);
            this.label10.TabIndex = 0;
            this.label10.Text = "Manage vehicle";
            // 
            // SignVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 719);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.labelNumOfVehicles);
            this.Controls.Add(this.MsgSystemHaasNoVehicles);
            this.Controls.Add(this.buttonDeleteVehicle);
            this.Controls.Add(this.buttonUpdateVehicle);
            this.Controls.Add(this.dataGridViewSystemVehicles);
            this.Controls.Add(this.buttonAddNewVehicle);
            this.Controls.Add(this.groupBoxVehicleOwnerDetails);
            this.Controls.Add(this.groupBoxVehicleDetails);
            this.Name = "SignVehicleForm";
            this.Text = "Add New Vehicle";
            this.Load += new System.EventHandler(this.AddNewVehicleForm_Load);
            this.groupBoxVehicleDetails.ResumeLayout(false);
            this.groupBoxVehicleDetails.PerformLayout();
            this.groupBoxVehicleOwnerDetails.ResumeLayout(false);
            this.groupBoxVehicleOwnerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSystemVehicles)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVehicleTypes;
        private System.Windows.Forms.GroupBox groupBoxVehicleDetails;
        private System.Windows.Forms.TextBox textBoxVehicleNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVehicleColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBoxVehicleOwnerDetails;
        private System.Windows.Forms.TextBox textBoxOwnerAddress;
        private System.Windows.Forms.TextBox textBoxOwnerNID;
        private System.Windows.Forms.TextBox textBoxOwnerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAddNewVehicle;
        private System.Windows.Forms.TextBox textBoxVehicleName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridViewSystemVehicles;
        private System.Windows.Forms.Button buttonUpdateVehicle;
        private System.Windows.Forms.Button buttonDeleteVehicle;
        private System.Windows.Forms.Label MsgSystemHaasNoVehicles;
        private System.Windows.Forms.Label labelNumOfVehicles;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerNid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerAddress;
    }
}