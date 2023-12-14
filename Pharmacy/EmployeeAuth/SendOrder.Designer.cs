namespace Pharmacy.EmployeeAuth
{
    partial class SendOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendOrder));
            this.sendOrderBtn = new Guna.UI2.WinForms.Guna2Button();
            this.medCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.supNameLbl = new System.Windows.Forms.Label();
            this.quantityNum = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.selectMedLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNum)).BeginInit();
            this.SuspendLayout();
            // 
            // sendOrderBtn
            // 
            this.sendOrderBtn.BorderRadius = 7;
            this.sendOrderBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendOrderBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendOrderBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendOrderBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendOrderBtn.FillColor = System.Drawing.Color.LightSkyBlue;
            this.sendOrderBtn.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.sendOrderBtn.ForeColor = System.Drawing.Color.White;
            this.sendOrderBtn.Location = new System.Drawing.Point(20, 217);
            this.sendOrderBtn.Name = "sendOrderBtn";
            this.sendOrderBtn.Size = new System.Drawing.Size(383, 46);
            this.sendOrderBtn.TabIndex = 17;
            this.sendOrderBtn.Text = "Send Order";
            this.sendOrderBtn.Click += new System.EventHandler(this.sendOrderBtn_Click);
            // 
            // medCb
            // 
            this.medCb.BackColor = System.Drawing.Color.Transparent;
            this.medCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.medCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medCb.Font = new System.Drawing.Font("Victor Mono", 11F);
            this.medCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.medCb.ItemHeight = 30;
            this.medCb.Location = new System.Drawing.Point(20, 115);
            this.medCb.Name = "medCb";
            this.medCb.Size = new System.Drawing.Size(221, 36);
            this.medCb.TabIndex = 12;
            this.medCb.SelectedIndexChanged += new System.EventHandler(this.medCb_SelectedIndexChanged);
            // 
            // supNameLbl
            // 
            this.supNameLbl.AutoSize = true;
            this.supNameLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.supNameLbl.Location = new System.Drawing.Point(12, 9);
            this.supNameLbl.Name = "supNameLbl";
            this.supNameLbl.Size = new System.Drawing.Size(131, 44);
            this.supNameLbl.TabIndex = 10;
            this.supNameLbl.Text = "Supplier";
            // 
            // quantityNum
            // 
            this.quantityNum.BackColor = System.Drawing.Color.Transparent;
            this.quantityNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityNum.Font = new System.Drawing.Font("Victor Mono", 11F);
            this.quantityNum.Location = new System.Drawing.Point(268, 115);
            this.quantityNum.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.quantityNum.Name = "quantityNum";
            this.quantityNum.Size = new System.Drawing.Size(123, 36);
            this.quantityNum.TabIndex = 18;
            this.quantityNum.ValueChanged += new System.EventHandler(this.quantityNum_ValueChanged);
            // 
            // selectMedLbl
            // 
            this.selectMedLbl.AutoSize = true;
            this.selectMedLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.selectMedLbl.Location = new System.Drawing.Point(12, 68);
            this.selectMedLbl.Name = "selectMedLbl";
            this.selectMedLbl.Size = new System.Drawing.Size(229, 44);
            this.selectMedLbl.TabIndex = 19;
            this.selectMedLbl.Text = "Select Medicine";
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.quantityLbl.Location = new System.Drawing.Point(260, 68);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(131, 44);
            this.quantityLbl.TabIndex = 20;
            this.quantityLbl.Text = "Quantity";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.totalLbl.Location = new System.Drawing.Point(12, 170);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(187, 44);
            this.totalLbl.TabIndex = 21;
            this.totalLbl.Text = "Total = 0.0$";
            // 
            // SendOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 283);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.selectMedLbl);
            this.Controls.Add(this.quantityNum);
            this.Controls.Add(this.sendOrderBtn);
            this.Controls.Add(this.medCb);
            this.Controls.Add(this.supNameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SendOrder";
            this.Text = "Send Order";
            ((System.ComponentModel.ISupportInitialize)(this.quantityNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button sendOrderBtn;
        private Guna.UI2.WinForms.Guna2ComboBox medCb;
        private System.Windows.Forms.Label supNameLbl;
        private Guna.UI2.WinForms.Guna2NumericUpDown quantityNum;
        private System.Windows.Forms.Label selectMedLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label totalLbl;
    }
}