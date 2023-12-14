namespace Pharmacy.EmployeeAuth
{
    partial class BuyMedicine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.orderTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.medID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genericName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.reqBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // orderTable
            // 
            this.orderTable.AllowUserToAddRows = false;
            this.orderTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.orderTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Victor Mono", 10.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orderTable.ColumnHeadersHeight = 58;
            this.orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.orderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medID,
            this.genericName,
            this.price,
            this.maxQuantity,
            this.quantity,
            this.subTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Victor Mono", 10.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.orderTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.orderTable.Location = new System.Drawing.Point(-2, 0);
            this.orderTable.MultiSelect = false;
            this.orderTable.Name = "orderTable";
            this.orderTable.ReadOnly = true;
            this.orderTable.RowHeadersVisible = false;
            this.orderTable.RowHeadersWidth = 20;
            this.orderTable.Size = new System.Drawing.Size(803, 395);
            this.orderTable.TabIndex = 1;
            this.orderTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.orderTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.orderTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.orderTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.orderTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.orderTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.orderTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.orderTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.orderTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.orderTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.orderTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Victor Mono", 10.75F);
            this.orderTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.orderTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.orderTable.ThemeStyle.HeaderStyle.Height = 58;
            this.orderTable.ThemeStyle.ReadOnly = true;
            this.orderTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.orderTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Victor Mono", 10.75F);
            this.orderTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.orderTable.ThemeStyle.RowsStyle.Height = 22;
            this.orderTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.orderTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.orderTable.SelectionChanged += new System.EventHandler(this.orderTable_SelectionChanged);
            // 
            // medID
            // 
            this.medID.FillWeight = 93.74877F;
            this.medID.HeaderText = "ID";
            this.medID.Name = "medID";
            this.medID.ReadOnly = true;
            // 
            // genericName
            // 
            this.genericName.FillWeight = 92.62325F;
            this.genericName.HeaderText = "Generic Name";
            this.genericName.Name = "genericName";
            this.genericName.ReadOnly = true;
            // 
            // price
            // 
            this.price.FillWeight = 103.7096F;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // maxQuantity
            // 
            this.maxQuantity.HeaderText = "Max.Quantity";
            this.maxQuantity.Name = "maxQuantity";
            this.maxQuantity.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // subTotal
            // 
            this.subTotal.HeaderText = "Sub Total";
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            // 
            // medQuantity
            // 
            this.medQuantity.BackColor = System.Drawing.Color.Transparent;
            this.medQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.medQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.medQuantity.Location = new System.Drawing.Point(149, 401);
            this.medQuantity.Name = "medQuantity";
            this.medQuantity.Size = new System.Drawing.Size(100, 37);
            this.medQuantity.TabIndex = 2;
            this.medQuantity.ValueChanged += new System.EventHandler(this.medQuantity_ValueChanged);
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.quantityLbl.Location = new System.Drawing.Point(12, 398);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(131, 44);
            this.quantityLbl.TabIndex = 3;
            this.quantityLbl.Text = "Quantity";
            // 
            // reqBtn
            // 
            this.reqBtn.BorderRadius = 7;
            this.reqBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reqBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reqBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reqBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reqBtn.FillColor = System.Drawing.Color.LightSkyBlue;
            this.reqBtn.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.reqBtn.ForeColor = System.Drawing.Color.White;
            this.reqBtn.Location = new System.Drawing.Point(538, 398);
            this.reqBtn.Name = "reqBtn";
            this.reqBtn.Size = new System.Drawing.Size(250, 46);
            this.reqBtn.TabIndex = 10;
            this.reqBtn.Text = "Request Cashier";
            this.reqBtn.Click += new System.EventHandler(this.reqBtn_Click);
            // 
            // BuyMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reqBtn);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.medQuantity);
            this.Controls.Add(this.orderTable);
            this.MaximizeBox = false;
            this.Name = "BuyMedicine";
            this.Text = "Buy Medicine";
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView orderTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn medID;
        private System.Windows.Forms.DataGridViewTextBoxColumn genericName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private Guna.UI2.WinForms.Guna2NumericUpDown medQuantity;
        private System.Windows.Forms.Label quantityLbl;
        private Guna.UI2.WinForms.Guna2Button reqBtn;
    }
}