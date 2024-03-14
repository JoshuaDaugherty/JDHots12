namespace PasswordCracker
{
    partial class frmPasswordCracker
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
            this.lblHash = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.btnCrack = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHash
            // 
            this.lblHash.Location = new System.Drawing.Point(114, 94);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(100, 23);
            this.lblHash.TabIndex = 3;
            this.lblHash.Text = "MD5 Hash";
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(114, 120);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(220, 26);
            this.txtHash.TabIndex = 0;
            this.txtHash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCrack
            // 
            this.btnCrack.Location = new System.Drawing.Point(360, 120);
            this.btnCrack.Name = "btnCrack";
            this.btnCrack.Size = new System.Drawing.Size(75, 26);
            this.btnCrack.TabIndex = 1;
            this.btnCrack.Text = "Crack";
            this.btnCrack.UseVisualStyleBackColor = true;
            this.btnCrack.Click += new System.EventHandler(this.btnCrack_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Fuchsia;
            this.lblResult.Location = new System.Drawing.Point(110, 166);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(224, 44);
            this.lblResult.TabIndex = 2;
            // 
            // frmPasswordCracker
            // 
            this.AcceptButton = this.btnCrack;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCrack);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.lblHash);
            this.Name = "frmPasswordCracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Cracker";
            this.Load += new System.EventHandler(this.frmPasswordCracker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Button btnCrack;
        private System.Windows.Forms.Label lblResult;
    }
}

