
namespace GarageSystemProject
{
    partial class ManageVehicleTypeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddVehicleType = new System.Windows.Forms.Button();
            this.textBoxVehicleType = new System.Windows.Forms.TextBox();
            this.numericUpDownCostPerHour = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTypesCost = new System.Windows.Forms.DataGridView();
            this.GridTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonUpdateType = new System.Windows.Forms.Button();
            this.buttonDeleteType = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.MsgNoVehiclesTypesInSystem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostPerHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypesCost)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Type";
            // 
            // buttonAddVehicleType
            // 
            this.buttonAddVehicleType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.buttonAddVehicleType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddVehicleType.ForeColor = System.Drawing.Color.White;
            this.buttonAddVehicleType.Location = new System.Drawing.Point(68, 338);
            this.buttonAddVehicleType.Name = "buttonAddVehicleType";
            this.buttonAddVehicleType.Size = new System.Drawing.Size(126, 40);
            this.buttonAddVehicleType.TabIndex = 1;
            this.buttonAddVehicleType.Text = "Add";
            this.buttonAddVehicleType.UseVisualStyleBackColor = false;
            this.buttonAddVehicleType.Click += new System.EventHandler(this.buttonAddVehicleType_Click);
            // 
            // textBoxVehicleType
            // 
            this.textBoxVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVehicleType.Location = new System.Drawing.Point(225, 155);
            this.textBoxVehicleType.Name = "textBoxVehicleType";
            this.textBoxVehicleType.Size = new System.Drawing.Size(189, 26);
            this.textBoxVehicleType.TabIndex = 2;
            // 
            // numericUpDownCostPerHour
            // 
            this.numericUpDownCostPerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCostPerHour.Location = new System.Drawing.Point(225, 208);
            this.numericUpDownCostPerHour.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCostPerHour.Name = "numericUpDownCostPerHour";
            this.numericUpDownCostPerHour.Size = new System.Drawing.Size(189, 26);
            this.numericUpDownCostPerHour.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cost Per Hour";
            // 
            // dataGridViewTypesCost
            // 
            this.dataGridViewTypesCost.AllowUserToAddRows = false;
            this.dataGridViewTypesCost.AllowUserToDeleteRows = false;
            this.dataGridViewTypesCost.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.dataGridViewTypesCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTypesCost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridTypeColumn,
            this.GridCostColumn});
            this.dataGridViewTypesCost.Location = new System.Drawing.Point(519, 141);
            this.dataGridViewTypesCost.Name = "dataGridViewTypesCost";
            this.dataGridViewTypesCost.ReadOnly = true;
            this.dataGridViewTypesCost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTypesCost.Size = new System.Drawing.Size(243, 150);
            this.dataGridViewTypesCost.TabIndex = 7;
            this.dataGridViewTypesCost.SelectionChanged += new System.EventHandler(this.dataGridViewTypesCost_SelectionChanged);
            // 
            // GridTypeColumn
            // 
            this.GridTypeColumn.HeaderText = "Type";
            this.GridTypeColumn.Name = "GridTypeColumn";
            this.GridTypeColumn.ReadOnly = true;
            // 
            // GridCostColumn
            // 
            this.GridCostColumn.HeaderText = "Cost";
            this.GridCostColumn.Name = "GridCostColumn";
            this.GridCostColumn.ReadOnly = true;
            // 
            // buttonUpdateType
            // 
            this.buttonUpdateType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.buttonUpdateType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateType.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateType.Location = new System.Drawing.Point(238, 338);
            this.buttonUpdateType.Name = "buttonUpdateType";
            this.buttonUpdateType.Size = new System.Drawing.Size(126, 40);
            this.buttonUpdateType.TabIndex = 8;
            this.buttonUpdateType.Text = "Update ";
            this.buttonUpdateType.UseVisualStyleBackColor = false;
            this.buttonUpdateType.Click += new System.EventHandler(this.buttonUpdateType_Click);
            // 
            // buttonDeleteType
            // 
            this.buttonDeleteType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.buttonDeleteType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteType.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteType.Location = new System.Drawing.Point(404, 338);
            this.buttonDeleteType.Name = "buttonDeleteType";
            this.buttonDeleteType.Size = new System.Drawing.Size(126, 40);
            this.buttonDeleteType.TabIndex = 9;
            this.buttonDeleteType.Text = "Delete";
            this.buttonDeleteType.UseVisualStyleBackColor = false;
            this.buttonDeleteType.Click += new System.EventHandler(this.buttonDeleteType_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.panelTitle.Controls.Add(this.label10);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(938, 100);
            this.panelTitle.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(266, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(388, 39);
            this.label10.TabIndex = 0;
            this.label10.Text = "Manage Vehicle Types";
            // 
            // MsgNoVehiclesTypesInSystem
            // 
            this.MsgNoVehiclesTypesInSystem.AutoSize = true;
            this.MsgNoVehiclesTypesInSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgNoVehiclesTypesInSystem.ForeColor = System.Drawing.Color.Maroon;
            this.MsgNoVehiclesTypesInSystem.Location = new System.Drawing.Point(542, 180);
            this.MsgNoVehiclesTypesInSystem.Name = "MsgNoVehiclesTypesInSystem";
            this.MsgNoVehiclesTypesInSystem.Size = new System.Drawing.Size(197, 20);
            this.MsgNoVehiclesTypesInSystem.TabIndex = 24;
            this.MsgNoVehiclesTypesInSystem.Text = "No Vehicle types in system";
            this.MsgNoVehiclesTypesInSystem.Visible = false;
            // 
            // ManageVehicleTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 512);
            this.Controls.Add(this.MsgNoVehiclesTypesInSystem);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.buttonDeleteType);
            this.Controls.Add(this.buttonUpdateType);
            this.Controls.Add(this.dataGridViewTypesCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownCostPerHour);
            this.Controls.Add(this.textBoxVehicleType);
            this.Controls.Add(this.buttonAddVehicleType);
            this.Controls.Add(this.label1);
            this.Name = "ManageVehicleTypeForm";
            this.Text = "Add Vehicle Type ";
            this.Load += new System.EventHandler(this.AddVehicleTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostPerHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypesCost)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddVehicleType;
        private System.Windows.Forms.TextBox textBoxVehicleType;
        private System.Windows.Forms.NumericUpDown numericUpDownCostPerHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewTypesCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridCostColumn;
        private System.Windows.Forms.Button buttonUpdateType;
        private System.Windows.Forms.Button buttonDeleteType;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label MsgNoVehiclesTypesInSystem;
    }
}