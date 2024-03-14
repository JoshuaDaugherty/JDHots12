namespace NetworkScanner
{
    partial class frmIPAddress
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Fuchsia;
            this.lblResult.Location = new System.Drawing.Point(136, 195);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(224, 233);
            this.lblResult.TabIndex = 2;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(386, 149);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 26);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(140, 149);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(220, 26);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(140, 123);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "IP Address";
            // 
            // lblResult2
            // 
            this.lblResult2.BackColor = System.Drawing.Color.Fuchsia;
            this.lblResult2.Location = new System.Drawing.Point(382, 195);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(224, 233);
            this.lblResult2.TabIndex = 4;
            // 
            // frmIPAddress
            // 
            this.AcceptButton = this.btnScan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Name = "frmIPAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP Address";
            this.Load += new System.EventHandler(this.frmIPAddress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblResult2;
    }
}

