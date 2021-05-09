
namespace GarageSystemProject
{
    partial class GarageReportsForm
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
            this.comboBoxGarages = new System.Windows.Forms.ComboBox();
            this.comboBoxReportTypes = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewEnterOutVehiclesReport = new System.Windows.Forms.DataGridView();
            this.VehicleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerNid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOfHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonShowReport = new System.Windows.Forms.Button();
            this.dataGridViewVehiclesTypesAndCost = new System.Windows.Forms.DataGridView();
            this.VehicleTypesAndCosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTotalProfits = new System.Windows.Forms.Label();
            this.dataGridViewCrowdTimes = new System.Windows.Forms.DataGridView();
            this.By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodFrom12AmTo6Am = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodFrom6AmTo12Pm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodFrom12PmTo6Pm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodFrom6PmTo12Am = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelMaxNumOFVehicles = new System.Windows.Forms.Label();
            this.labelMinProfits = new System.Windows.Forms.Label();
            this.labelMaxProfits = new System.Windows.Forms.Label();
            this.labelMinNumOFVehicles = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnterOutVehiclesReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiclesTypesAndCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrowdTimes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxGarages
            // 
            this.comboBoxGarages.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxGarages.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxGarages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGarages.FormattingEnabled = true;
            this.comboBoxGarages.Location = new System.Drawing.Point(191, 139);
            this.comboBoxGarages.Name = "comboBoxGarages";
            this.comboBoxGarages.Size = new System.Drawing.Size(258, 28);
            this.comboBoxGarages.TabIndex = 0;
            // 
            // comboBoxReportTypes
            // 
            this.comboBoxReportTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReportTypes.FormattingEnabled = true;
            this.comboBoxReportTypes.Items.AddRange(new object[] {
            "All Vehicles",
            "All Vehicles Types And Cost",
            "Crowd Times"});
            this.comboBoxReportTypes.Location = new System.Drawing.Point(624, 136);
            this.comboBoxReportTypes.Name = "comboBoxReportTypes";
            this.comboBoxReportTypes.Size = new System.Drawing.Size(260, 28);
            this.comboBoxReportTypes.TabIndex = 1;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(191, 190);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(258, 26);
            this.dateTimePickerStartDate.TabIndex = 2;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(624, 185);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(258, 26);
            this.dateTimePickerEndDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Garage";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(488, 139);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(96, 20);
            this.l.TabIndex = 5;
            this.l.Text = "Report Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(497, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "End Date";
            // 
            // dataGridViewEnterOutVehiclesReport
            // 
            this.dataGridViewEnterOutVehiclesReport.AllowUserToAddRows = false;
            this.dataGridViewEnterOutVehiclesReport.AllowUserToDeleteRows = false;
            this.dataGridViewEnterOutVehiclesReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.dataGridViewEnterOutVehiclesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnterOutVehiclesReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleName,
            this.VehicleNum,
            this.VehicleType,
            this.VehicleColor,
            this.OwnerName,
            this.OwnerNid,
            this.OwnerAddress,
            this.EnterDate,
            this.ExitDate,
            this.NumOfHours,
            this.TotCost});
            this.dataGridViewEnterOutVehiclesReport.Location = new System.Drawing.Point(0, 380);
            this.dataGridViewEnterOutVehiclesReport.Name = "dataGridViewEnterOutVehiclesReport";
            this.dataGridViewEnterOutVehiclesReport.ReadOnly = true;
            this.dataGridViewEnterOutVehiclesReport.Size = new System.Drawing.Size(1121, 218);
            this.dataGridViewEnterOutVehiclesReport.TabIndex = 8;
            this.dataGridViewEnterOutVehiclesReport.Visible = false;
            // 
            // VehicleName
            // 
            this.VehicleName.HeaderText = "Vehicle Name";
            this.VehicleName.Name = "VehicleName";
            this.VehicleName.ReadOnly = true;
            // 
            // VehicleNum
            // 
            this.VehicleNum.HeaderText = "Vehicle number";
            this.VehicleNum.Name = "VehicleNum";
            this.VehicleNum.ReadOnly = true;
            // 
            // VehicleType
            // 
            this.VehicleType.HeaderText = "Vehicle Type";
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.ReadOnly = true;
            // 
            // VehicleColor
            // 
            this.VehicleColor.HeaderText = "Vehicle Color";
            this.VehicleColor.Name = "VehicleColor";
            this.VehicleColor.ReadOnly = true;
            // 
            // OwnerName
            // 
            this.OwnerName.HeaderText = "Owner Name";
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.ReadOnly = true;
            // 
            // OwnerNid
            // 
            this.OwnerNid.HeaderText = "Owner NID";
            this.OwnerNid.Name = "OwnerNid";
            this.OwnerNid.ReadOnly = true;
            // 
            // OwnerAddress
            // 
            this.OwnerAddress.HeaderText = "Owner Address";
            this.OwnerAddress.Name = "OwnerAddress";
            this.OwnerAddress.ReadOnly = true;
            // 
            // EnterDate
            // 
            this.EnterDate.HeaderText = "Enter date";
            this.EnterDate.Name = "EnterDate";
            this.EnterDate.ReadOnly = true;
            this.EnterDate.Width = 150;
            // 
            // ExitDate
            // 
            this.ExitDate.HeaderText = "Exit date";
            this.ExitDate.Name = "ExitDate";
            this.ExitDate.ReadOnly = true;
            this.ExitDate.Width = 150;
            // 
            // NumOfHours
            // 
            this.NumOfHours.HeaderText = "Total hours";
            this.NumOfHours.Name = "NumOfHours";
            this.NumOfHours.ReadOnly = true;
            // 
            // TotCost
            // 
            this.TotCost.HeaderText = "Total Cost";
            this.TotCost.Name = "TotCost";
            this.TotCost.ReadOnly = true;
            // 
            // buttonShowReport
            // 
            this.buttonShowReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.buttonShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowReport.ForeColor = System.Drawing.Color.White;
            this.buttonShowReport.Location = new System.Drawing.Point(379, 289);
            this.buttonShowReport.Name = "buttonShowReport";
            this.buttonShowReport.Size = new System.Drawing.Size(185, 42);
            this.buttonShowReport.TabIndex = 9;
            this.buttonShowReport.Text = "Show Report";
            this.buttonShowReport.UseVisualStyleBackColor = false;
            this.buttonShowReport.Click += new System.EventHandler(this.buttonShowReport_Click);
            // 
            // dataGridViewVehiclesTypesAndCost
            // 
            this.dataGridViewVehiclesTypesAndCost.AllowUserToAddRows = false;
            this.dataGridViewVehiclesTypesAndCost.AllowUserToDeleteRows = false;
            this.dataGridViewVehiclesTypesAndCost.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.dataGridViewVehiclesTypesAndCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiclesTypesAndCost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleTypesAndCosts,
            this.numOfVehicle,
            this.costPerHour,
            this.profit});
            this.dataGridViewVehiclesTypesAndCost.Location = new System.Drawing.Point(132, 408);
            this.dataGridViewVehiclesTypesAndCost.Name = "dataGridViewVehiclesTypesAndCost";
            this.dataGridViewVehiclesTypesAndCost.ReadOnly = true;
            this.dataGridViewVehiclesTypesAndCost.Size = new System.Drawing.Size(643, 190);
            this.dataGridViewVehiclesTypesAndCost.TabIndex = 10;
            this.dataGridViewVehiclesTypesAndCost.Visible = false;
            // 
            // VehicleTypesAndCosts
            // 
            this.VehicleTypesAndCosts.HeaderText = "Vehicle type";
            this.VehicleTypesAndCosts.Name = "VehicleTypesAndCosts";
            this.VehicleTypesAndCosts.ReadOnly = true;
            this.VehicleTypesAndCosts.Width = 150;
            // 
            // numOfVehicle
            // 
            this.numOfVehicle.HeaderText = "Number of vehicles";
            this.numOfVehicle.Name = "numOfVehicle";
            this.numOfVehicle.ReadOnly = true;
            this.numOfVehicle.Width = 150;
            // 
            // costPerHour
            // 
            this.costPerHour.HeaderText = "Cost per hour";
            this.costPerHour.Name = "costPerHour";
            this.costPerHour.ReadOnly = true;
            this.costPerHour.Width = 150;
            // 
            // profit
            // 
            this.profit.HeaderText = "Profit";
            this.profit.Name = "profit";
            this.profit.ReadOnly = true;
            this.profit.Width = 150;
            // 
            // labelTotalProfits
            // 
            this.labelTotalProfits.AutoSize = true;
            this.labelTotalProfits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalProfits.Location = new System.Drawing.Point(131, 612);
            this.labelTotalProfits.Name = "labelTotalProfits";
            this.labelTotalProfits.Size = new System.Drawing.Size(155, 20);
            this.labelTotalProfits.TabIndex = 11;
            this.labelTotalProfits.Text = "Total Garage Profits:";
            this.labelTotalProfits.Visible = false;
            // 
            // dataGridViewCrowdTimes
            // 
            this.dataGridViewCrowdTimes.AllowUserToAddRows = false;
            this.dataGridViewCrowdTimes.AllowUserToDeleteRows = false;
            this.dataGridViewCrowdTimes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.dataGridViewCrowdTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrowdTimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.By,
            this.periodFrom12AmTo6Am,
            this.PeriodFrom6AmTo12Pm,
            this.PeriodFrom12PmTo6Pm,
            this.PeriodFrom6PmTo12Am});
            this.dataGridViewCrowdTimes.Location = new System.Drawing.Point(132, 380);
            this.dataGridViewCrowdTimes.Name = "dataGridViewCrowdTimes";
            this.dataGridViewCrowdTimes.ReadOnly = true;
            this.dataGridViewCrowdTimes.Size = new System.Drawing.Size(643, 119);
            this.dataGridViewCrowdTimes.TabIndex = 12;
            this.dataGridViewCrowdTimes.Visible = false;
            // 
            // By
            // 
            this.By.HeaderText = " By";
            this.By.Name = "By";
            this.By.ReadOnly = true;
            this.By.Width = 160;
            // 
            // periodFrom12AmTo6Am
            // 
            this.periodFrom12AmTo6Am.HeaderText = "12:00 am - 06:00 am";
            this.periodFrom12AmTo6Am.Name = "periodFrom12AmTo6Am";
            this.periodFrom12AmTo6Am.ReadOnly = true;
            this.periodFrom12AmTo6Am.Width = 110;
            // 
            // PeriodFrom6AmTo12Pm
            // 
            this.PeriodFrom6AmTo12Pm.HeaderText = "06:00 am - 12:00 pm";
            this.PeriodFrom6AmTo12Pm.Name = "PeriodFrom6AmTo12Pm";
            this.PeriodFrom6AmTo12Pm.ReadOnly = true;
            this.PeriodFrom6AmTo12Pm.Width = 110;
            // 
            // PeriodFrom12PmTo6Pm
            // 
            this.PeriodFrom12PmTo6Pm.HeaderText = "12:00 pm - 06:00 pm";
            this.PeriodFrom12PmTo6Pm.Name = "PeriodFrom12PmTo6Pm";
            this.PeriodFrom12PmTo6Pm.ReadOnly = true;
            this.PeriodFrom12PmTo6Pm.Width = 110;
            // 
            // PeriodFrom6PmTo12Am
            // 
            this.PeriodFrom6PmTo12Am.HeaderText = "06:00 pm - 12:00 am";
            this.PeriodFrom6PmTo12Am.Name = "PeriodFrom6PmTo12Am";
            this.PeriodFrom6PmTo12Am.ReadOnly = true;
            this.PeriodFrom6PmTo12Am.Width = 110;
            // 
            // labelMaxNumOFVehicles
            // 
            this.labelMaxNumOFVehicles.AutoSize = true;
            this.labelMaxNumOFVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxNumOFVehicles.Location = new System.Drawing.Point(796, 392);
            this.labelMaxNumOFVehicles.Name = "labelMaxNumOFVehicles";
            this.labelMaxNumOFVehicles.Size = new System.Drawing.Size(114, 16);
            this.labelMaxNumOFVehicles.TabIndex = 20;
            this.labelMaxNumOFVehicles.Text = "Max num vehicles";
            this.labelMaxNumOFVehicles.Visible = false;
            // 
            // labelMinProfits
            // 
            this.labelMinProfits.AutoSize = true;
            this.labelMinProfits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinProfits.Location = new System.Drawing.Point(796, 494);
            this.labelMinProfits.Name = "labelMinProfits";
            this.labelMinProfits.Size = new System.Drawing.Size(68, 16);
            this.labelMinProfits.TabIndex = 21;
            this.labelMinProfits.Text = "Min profits";
            this.labelMinProfits.Visible = false;
            // 
            // labelMaxProfits
            // 
            this.labelMaxProfits.AutoSize = true;
            this.labelMaxProfits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxProfits.Location = new System.Drawing.Point(796, 460);
            this.labelMaxProfits.Name = "labelMaxProfits";
            this.labelMaxProfits.Size = new System.Drawing.Size(72, 16);
            this.labelMaxProfits.TabIndex = 22;
            this.labelMaxProfits.Text = "max profits";
            this.labelMaxProfits.Visible = false;
            // 
            // labelMinNumOFVehicles
            // 
            this.labelMinNumOFVehicles.AutoSize = true;
            this.labelMinNumOFVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinNumOFVehicles.Location = new System.Drawing.Point(796, 427);
            this.labelMinNumOFVehicles.Name = "labelMinNumOFVehicles";
            this.labelMinNumOFVehicles.Size = new System.Drawing.Size(110, 16);
            this.labelMinNumOFVehicles.TabIndex = 23;
            this.labelMinNumOFVehicles.Text = "Min num vehicles";
            this.labelMinNumOFVehicles.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 100);
            this.panel1.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(372, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 39);
            this.label10.TabIndex = 0;
            this.label10.Text = "Garage Reports";
            // 
            // GarageReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 689);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelMinNumOFVehicles);
            this.Controls.Add(this.labelMaxProfits);
            this.Controls.Add(this.labelMinProfits);
            this.Controls.Add(this.labelMaxNumOFVehicles);
            this.Controls.Add(this.dataGridViewCrowdTimes);
            this.Controls.Add(this.labelTotalProfits);
            this.Controls.Add(this.dataGridViewVehiclesTypesAndCost);
            this.Controls.Add(this.buttonShowReport);
            this.Controls.Add(this.dataGridViewEnterOutVehiclesReport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.comboBoxReportTypes);
            this.Controls.Add(this.comboBoxGarages);
            this.Name = "GarageReportsForm";
            this.Text = "GarageReportsForm";
            this.Load += new System.EventHandler(this.GarageReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnterOutVehiclesReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiclesTypesAndCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrowdTimes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGarages;
        private System.Windows.Forms.ComboBox comboBoxReportTypes;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewEnterOutVehiclesReport;
        private System.Windows.Forms.Button buttonShowReport;
        private System.Windows.Forms.DataGridView dataGridViewVehiclesTypesAndCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleTypesAndCosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPerHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn profit;
        private System.Windows.Forms.Label labelTotalProfits;
        private System.Windows.Forms.DataGridView dataGridViewCrowdTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn By;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodFrom12AmTo6Am;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodFrom6AmTo12Pm;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodFrom12PmTo6Pm;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodFrom6PmTo12Am;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerNid;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOfHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotCost;
        private System.Windows.Forms.Label labelMaxNumOFVehicles;
        private System.Windows.Forms.Label labelMinProfits;
        private System.Windows.Forms.Label labelMaxProfits;
        private System.Windows.Forms.Label labelMinNumOFVehicles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
    }
}