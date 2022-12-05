namespace DylanDeSouzaWk9ExA
{
    partial class Form2
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtAgeYears = new System.Windows.Forms.TextBox();
            this.lblAgeYears = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2022, 9, 22, 21, 57, 19, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtAgeYears
            // 
            this.txtAgeYears.Location = new System.Drawing.Point(186, 148);
            this.txtAgeYears.Name = "txtAgeYears";
            this.txtAgeYears.Size = new System.Drawing.Size(100, 20);
            this.txtAgeYears.TabIndex = 1;
            // 
            // lblAgeYears
            // 
            this.lblAgeYears.AutoSize = true;
            this.lblAgeYears.Location = new System.Drawing.Point(120, 155);
            this.lblAgeYears.Name = "lblAgeYears";
            this.lblAgeYears.Size = new System.Drawing.Size(60, 13);
            this.lblAgeYears.TabIndex = 2;
            this.lblAgeYears.Text = "Age (years)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAgeYears);
            this.Controls.Add(this.txtAgeYears);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtAgeYears;
        private System.Windows.Forms.Label lblAgeYears;
    }
}