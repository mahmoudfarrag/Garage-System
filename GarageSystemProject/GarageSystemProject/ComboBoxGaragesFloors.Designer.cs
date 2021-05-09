
namespace GarageSystemProject
{
    partial class ComboBoxGaragesFloors
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxGarages = new System.Windows.Forms.ComboBox();
            this.comboBoxFloors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxGarages
            // 
            this.comboBoxGarages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGarages.FormattingEnabled = true;
            this.comboBoxGarages.Location = new System.Drawing.Point(156, 15);
            this.comboBoxGarages.Name = "comboBoxGarages";
            this.comboBoxGarages.Size = new System.Drawing.Size(180, 28);
            this.comboBoxGarages.TabIndex = 0;
            this.comboBoxGarages.SelectedIndexChanged += new System.EventHandler(this.comboBoxGarages_SelectedIndexChanged);
            // 
            // comboBoxFloors
            // 
            this.comboBoxFloors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFloors.FormattingEnabled = true;
            this.comboBoxFloors.Location = new System.Drawing.Point(156, 51);
            this.comboBoxFloors.Name = "comboBoxFloors";
            this.comboBoxFloors.Size = new System.Drawing.Size(180, 28);
            this.comboBoxFloors.TabIndex = 1;
            this.comboBoxFloors.SelectedIndexChanged += new System.EventHandler(this.comboBoxFloors_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Garages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Floors";
            // 
            // ComboBoxGaragesFloors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFloors);
            this.Controls.Add(this.comboBoxGarages);
            this.Name = "ComboBoxGaragesFloors";
            this.Size = new System.Drawing.Size(409, 98);
            this.Load += new System.EventHandler(this.ComboBoxGaragesFloors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGarages;
        private System.Windows.Forms.ComboBox comboBoxFloors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
