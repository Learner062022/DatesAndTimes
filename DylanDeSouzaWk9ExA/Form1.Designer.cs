namespace DylanDeSouzaWk9ExA
{
    partial class Form1
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
            this.txtNumberRepayments = new System.Windows.Forms.TextBox();
            this.lblNumberRepayments = new System.Windows.Forms.Label();
            this.lblPaymentInterval = new System.Windows.Forms.Label();
            this.txtPaymentInterval = new System.Windows.Forms.TextBox();
            this.lstRepaymentDates = new System.Windows.Forms.ListBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumberRepayments
            // 
            this.txtNumberRepayments.Location = new System.Drawing.Point(267, 86);
            this.txtNumberRepayments.Name = "txtNumberRepayments";
            this.txtNumberRepayments.Size = new System.Drawing.Size(100, 20);
            this.txtNumberRepayments.TabIndex = 0;
            // 
            // lblNumberRepayments
            // 
            this.lblNumberRepayments.AutoSize = true;
            this.lblNumberRepayments.Location = new System.Drawing.Point(160, 93);
            this.lblNumberRepayments.Name = "lblNumberRepayments";
            this.lblNumberRepayments.Size = new System.Drawing.Size(101, 13);
            this.lblNumberRepayments.TabIndex = 1;
            this.lblNumberRepayments.Text = "Number repayments";
            // 
            // lblPaymentInterval
            // 
            this.lblPaymentInterval.AutoSize = true;
            this.lblPaymentInterval.Location = new System.Drawing.Point(96, 128);
            this.lblPaymentInterval.Name = "lblPaymentInterval";
            this.lblPaymentInterval.Size = new System.Drawing.Size(165, 13);
            this.lblPaymentInterval.TabIndex = 2;
            this.lblPaymentInterval.Text = "Interval between payments (days)";
            // 
            // txtPaymentInterval
            // 
            this.txtPaymentInterval.Location = new System.Drawing.Point(267, 121);
            this.txtPaymentInterval.Name = "txtPaymentInterval";
            this.txtPaymentInterval.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentInterval.TabIndex = 3;
            // 
            // lstRepaymentDates
            // 
            this.lstRepaymentDates.FormattingEnabled = true;
            this.lstRepaymentDates.Items.AddRange(new object[] {
            "Repayment Dates"});
            this.lstRepaymentDates.Location = new System.Drawing.Point(267, 147);
            this.lstRepaymentDates.Name = "lstRepaymentDates";
            this.lstRepaymentDates.Size = new System.Drawing.Size(120, 95);
            this.lstRepaymentDates.TabIndex = 4;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(267, 248);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 5;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lstRepaymentDates);
            this.Controls.Add(this.txtPaymentInterval);
            this.Controls.Add(this.lblPaymentInterval);
            this.Controls.Add(this.lblNumberRepayments);
            this.Controls.Add(this.txtNumberRepayments);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberRepayments;
        private System.Windows.Forms.Label lblNumberRepayments;
        private System.Windows.Forms.Label lblPaymentInterval;
        private System.Windows.Forms.TextBox txtPaymentInterval;
        private System.Windows.Forms.ListBox lstRepaymentDates;
        private System.Windows.Forms.Button btnClick;
    }
}

