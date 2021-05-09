
namespace GarageSystemProject
{
    partial class ManageFloorsForm
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
            this.checkedListBoxVehicleTypes = new System.Windows.Forms.CheckedListBox();
            this.buttonAssignTypes = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.labelChooseVehicleTypeForFloor = new System.Windows.Forms.Label();
            this.MsgNoVehicleTypeInSystem = new System.Windows.Forms.Label();
            this.buttonAddVehicleType = new System.Windows.Forms.Button();
            this.comboBoxGaragesFloors = new GarageSystemProject.ComboBoxGaragesFloors();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBoxVehicleTypes
            // 
            this.checkedListBoxVehicleTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.checkedListBoxVehicleTypes.CheckOnClick = true;
            this.checkedListBoxVehicleTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxVehicleTypes.ForeColor = System.Drawing.Color.White;
            this.checkedListBoxVehicleTypes.FormattingEnabled = true;
            this.checkedListBoxVehicleTypes.Location = new System.Drawing.Point(617, 155);
            this.checkedListBoxVehicleTypes.Name = "checkedListBoxVehicleTypes";
            this.checkedListBoxVehicleTypes.Size = new System.Drawing.Size(191, 151);
            this.checkedListBoxVehicleTypes.TabIndex = 2;
            this.checkedListBoxVehicleTypes.Visible = false;
            // 
            // buttonAssignTypes
            // 
            this.buttonAssignTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.buttonAssignTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssignTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAssignTypes.ForeColor = System.Drawing.Color.White;
            this.buttonAssignTypes.Location = new System.Drawing.Point(269, 341);
            this.buttonAssignTypes.Name = "buttonAssignTypes";
            this.buttonAssignTypes.Size = new System.Drawing.Size(120, 45);
            this.buttonAssignTypes.TabIndex = 3;
            this.buttonAssignTypes.Text = "Assign";
            this.buttonAssignTypes.UseVisualStyleBackColor = false;
            this.buttonAssignTypes.Click += new System.EventHandler(this.buttonAssignTypes_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.panelTitle.Controls.Add(this.label10);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(944, 100);
            this.panelTitle.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(333, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(241, 39);
            this.label10.TabIndex = 0;
            this.label10.Text = "Manage Floor";
            // 
            // labelChooseVehicleTypeForFloor
            // 
            this.labelChooseVehicleTypeForFloor.AutoSize = true;
            this.labelChooseVehicleTypeForFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseVehicleTypeForFloor.Location = new System.Drawing.Point(614, 117);
            this.labelChooseVehicleTypeForFloor.Name = "labelChooseVehicleTypeForFloor";
            this.labelChooseVehicleTypeForFloor.Size = new System.Drawing.Size(199, 18);
            this.labelChooseVehicleTypeForFloor.TabIndex = 24;
            this.labelChooseVehicleTypeForFloor.Text = "Choose Vehicle type for floor";
            this.labelChooseVehicleTypeForFloor.Visible = false;
            // 
            // MsgNoVehicleTypeInSystem
            // 
            this.MsgNoVehicleTypeInSystem.AutoSize = true;
            this.MsgNoVehicleTypeInSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgNoVehicleTypeInSystem.ForeColor = System.Drawing.Color.Maroon;
            this.MsgNoVehicleTypeInSystem.Location = new System.Drawing.Point(624, 206);
            this.MsgNoVehicleTypeInSystem.Name = "MsgNoVehicleTypeInSystem";
            this.MsgNoVehicleTypeInSystem.Size = new System.Drawing.Size(175, 18);
            this.MsgNoVehicleTypeInSystem.TabIndex = 25;
            this.MsgNoVehicleTypeInSystem.Text = "No vehicle type in system";
            this.MsgNoVehicleTypeInSystem.Visible = false;
            // 
            // buttonAddVehicleType
            // 
            this.buttonAddVehicleType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.buttonAddVehicleType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddVehicleType.ForeColor = System.Drawing.Color.White;
            this.buttonAddVehicleType.Location = new System.Drawing.Point(674, 237);
            this.buttonAddVehicleType.Name = "buttonAddVehicleType";
            this.buttonAddVehicleType.Size = new System.Drawing.Size(73, 28);
            this.buttonAddVehicleType.TabIndex = 26;
            this.buttonAddVehicleType.Text = "Add";
            this.buttonAddVehicleType.UseVisualStyleBackColor = false;
            this.buttonAddVehicleType.Visible = false;
            this.buttonAddVehicleType.Click += new System.EventHandler(this.buttonAddVehicleType_Click);
            // 
            // comboBoxGaragesFloors
            // 
            this.comboBoxGaragesFloors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.comboBoxGaragesFloors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGaragesFloors.Location = new System.Drawing.Point(30, 142);
            this.comboBoxGaragesFloors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxGaragesFloors.Name = "comboBoxGaragesFloors";
            this.comboBoxGaragesFloors.Size = new System.Drawing.Size(544, 139);
            this.comboBoxGaragesFloors.TabIndex = 4;
            // 
            // ManageFloorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 537);
            this.Controls.Add(this.buttonAddVehicleType);
            this.Controls.Add(this.MsgNoVehicleTypeInSystem);
            this.Controls.Add(this.labelChooseVehicleTypeForFloor);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.comboBoxGaragesFloors);
            this.Controls.Add(this.buttonAssignTypes);
            this.Controls.Add(this.checkedListBoxVehicleTypes);
            this.Name = "ManageFloorsForm";
            this.Text = "Assign Vehicle Types To Floor";
            this.Load += new System.EventHandler(this.AssignVehicleTypesToFloorForm_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBoxVehicleTypes;
        private System.Windows.Forms.Button buttonAssignTypes;
        private ComboBoxGaragesFloors comboBoxGaragesFloors;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelChooseVehicleTypeForFloor;
        private System.Windows.Forms.Label MsgNoVehicleTypeInSystem;
        private System.Windows.Forms.Button buttonAddVehicleType;
    }
}