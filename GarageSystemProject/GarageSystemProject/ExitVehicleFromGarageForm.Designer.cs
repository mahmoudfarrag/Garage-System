
namespace GarageSystemProject
{
    partial class ExitVehicleFromGarageForm
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
            this.buttonExitVehicle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVehicleNum = new System.Windows.Forms.TextBox();
            this.dateTimePickerExitDate = new System.Windows.Forms.DateTimePicker();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxGarages
            // 
            this.comboBoxGarages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGarages.FormattingEnabled = true;
            this.comboBoxGarages.Location = new System.Drawing.Point(251, 154);
            this.comboBoxGarages.Name = "comboBoxGarages";
            this.comboBoxGarages.Size = new System.Drawing.Size(202, 28);
            this.comboBoxGarages.TabIndex = 0;
            // 
            // buttonExitVehicle
            // 
            this.buttonExitVehicle.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonExitVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitVehicle.ForeColor = System.Drawing.Color.White;
            this.buttonExitVehicle.Location = new System.Drawing.Point(251, 354);
            this.buttonExitVehicle.Name = "buttonExitVehicle";
            this.buttonExitVehicle.Size = new System.Drawing.Size(144, 44);
            this.buttonExitVehicle.TabIndex = 1;
            this.buttonExitVehicle.Text = "Exit Vehicle";
            this.buttonExitVehicle.UseVisualStyleBackColor = false;
            this.buttonExitVehicle.Click += new System.EventHandler(this.buttonExitVehicle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Garage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vehicle Number";
            // 
            // textBoxVehicleNum
            // 
            this.textBoxVehicleNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVehicleNum.Location = new System.Drawing.Point(251, 212);
            this.textBoxVehicleNum.Name = "textBoxVehicleNum";
            this.textBoxVehicleNum.Size = new System.Drawing.Size(202, 26);
            this.textBoxVehicleNum.TabIndex = 4;
            // 
            // dateTimePickerExitDate
            // 
            this.dateTimePickerExitDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePickerExitDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerExitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerExitDate.Location = new System.Drawing.Point(251, 270);
            this.dateTimePickerExitDate.Name = "dateTimePickerExitDate";
            this.dateTimePickerExitDate.Size = new System.Drawing.Size(202, 26);
            this.dateTimePickerExitDate.TabIndex = 5;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelTitle.Controls.Add(this.label3);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(819, 100);
            this.panelTitle.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(372, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Exit vehicle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Exit Date";
            // 
            // ExitVehicleFromGarageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(819, 431);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.dateTimePickerExitDate);
            this.Controls.Add(this.textBoxVehicleNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExitVehicle);
            this.Controls.Add(this.comboBoxGarages);
            this.Name = "ExitVehicleFromGarageForm";
            this.Text = "Exit Vehicle From Garage";
            this.Load += new System.EventHandler(this.ExitVehicleFromGarageForm_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGarages;
        private System.Windows.Forms.Button buttonExitVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVehicleNum;
        private System.Windows.Forms.DateTimePicker dateTimePickerExitDate;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}