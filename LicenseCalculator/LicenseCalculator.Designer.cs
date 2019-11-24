namespace LicenseCalculator
{
    partial class LicenseCalculator
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
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnFileName = new System.Windows.Forms.Button();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.lblLicenseRequired = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtApplicationID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(119, 27);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(71, 17);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "File Name";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(195, 26);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(397, 22);
            this.txtFileName.TabIndex = 1;
            // 
            // btnFileName
            // 
            this.btnFileName.Location = new System.Drawing.Point(599, 25);
            this.btnFileName.Name = "btnFileName";
            this.btnFileName.Size = new System.Drawing.Size(36, 24);
            this.btnFileName.TabIndex = 2;
            this.btnFileName.Text = "...";
            this.btnFileName.UseVisualStyleBackColor = true;
            this.btnFileName.Click += new System.EventHandler(this.btnFileName_Click);
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Location = new System.Drawing.Point(96, 60);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(94, 17);
            this.lblApplicationID.TabIndex = 5;
            this.lblApplicationID.Text = "Application ID";
            this.lblApplicationID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLicenseRequired
            // 
            this.lblLicenseRequired.AutoSize = true;
            this.lblLicenseRequired.Location = new System.Drawing.Point(25, 128);
            this.lblLicenseRequired.Name = "lblLicenseRequired";
            this.lblLicenseRequired.Size = new System.Drawing.Size(164, 17);
            this.lblLicenseRequired.TabIndex = 7;
            this.lblLicenseRequired.Text = "No.of Licenses Required";
            this.lblLicenseRequired.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLicenseRequired.Visible = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(195, 89);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(97, 25);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(195, 129);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(16, 17);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtApplicationID
            // 
            this.txtApplicationID.Enabled = false;
            this.txtApplicationID.Location = new System.Drawing.Point(195, 57);
            this.txtApplicationID.MaxLength = 3;
            this.txtApplicationID.Name = "txtApplicationID";
            this.txtApplicationID.Size = new System.Drawing.Size(100, 22);
            this.txtApplicationID.TabIndex = 10;
            this.txtApplicationID.Text = "374";
            // 
            // LicenseCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 179);
            this.Controls.Add(this.txtApplicationID);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblLicenseRequired);
            this.Controls.Add(this.lblApplicationID);
            this.Controls.Add(this.btnFileName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFileName);
            this.Name = "LicenseCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LicenseCalculator";
            this.Load += new System.EventHandler(this.LicenseCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnFileName;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label lblLicenseRequired;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtApplicationID;
    }
}

