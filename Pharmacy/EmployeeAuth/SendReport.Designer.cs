namespace Pharmacy.EmployeeAuth
{
    partial class SendReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendReport));
            this.contentLbl = new System.Windows.Forms.RichTextBox();
            this.sendReportBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // contentLbl
            // 
            this.contentLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.contentLbl.Location = new System.Drawing.Point(12, 12);
            this.contentLbl.Name = "contentLbl";
            this.contentLbl.Size = new System.Drawing.Size(427, 246);
            this.contentLbl.TabIndex = 14;
            this.contentLbl.Text = "";
            // 
            // sendReportBtn
            // 
            this.sendReportBtn.BorderRadius = 7;
            this.sendReportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendReportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendReportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendReportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendReportBtn.FillColor = System.Drawing.Color.LightSkyBlue;
            this.sendReportBtn.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.sendReportBtn.ForeColor = System.Drawing.Color.White;
            this.sendReportBtn.Location = new System.Drawing.Point(149, 264);
            this.sendReportBtn.Name = "sendReportBtn";
            this.sendReportBtn.Size = new System.Drawing.Size(142, 46);
            this.sendReportBtn.TabIndex = 15;
            this.sendReportBtn.Text = "Send";
            this.sendReportBtn.Click += new System.EventHandler(this.sendReportBtn_Click);
            // 
            // SendReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 321);
            this.Controls.Add(this.sendReportBtn);
            this.Controls.Add(this.contentLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SendReport";
            this.Text = "Send Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox contentLbl;
        private Guna.UI2.WinForms.Guna2Button sendReportBtn;
    }
}