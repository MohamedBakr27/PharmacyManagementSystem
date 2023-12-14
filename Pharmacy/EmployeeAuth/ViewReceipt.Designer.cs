namespace Pharmacy.EmployeeAuth
{
    partial class ViewReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReceipt));
            this.cashierNameTitle = new System.Windows.Forms.Label();
            this.cashierNameLbl = new System.Windows.Forms.Label();
            this.customerNameTitle = new System.Windows.Forms.Label();
            this.customerNameLbl = new System.Windows.Forms.Label();
            this.dateTitle = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.totalTitle = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.medRcptTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.medName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.medRcptTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cashierNameTitle
            // 
            this.cashierNameTitle.AutoSize = true;
            this.cashierNameTitle.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.cashierNameTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cashierNameTitle.Location = new System.Drawing.Point(205, 9);
            this.cashierNameTitle.Name = "cashierNameTitle";
            this.cashierNameTitle.Size = new System.Drawing.Size(75, 44);
            this.cashierNameTitle.TabIndex = 3;
            this.cashierNameTitle.Text = "Name";
            // 
            // cashierNameLbl
            // 
            this.cashierNameLbl.AutoSize = true;
            this.cashierNameLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.cashierNameLbl.Location = new System.Drawing.Point(12, 9);
            this.cashierNameLbl.Name = "cashierNameLbl";
            this.cashierNameLbl.Size = new System.Drawing.Size(187, 44);
            this.cashierNameLbl.TabIndex = 2;
            this.cashierNameLbl.Text = "Cashier Name";
            // 
            // customerNameTitle
            // 
            this.customerNameTitle.AutoSize = true;
            this.customerNameTitle.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.customerNameTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.customerNameTitle.Location = new System.Drawing.Point(645, 9);
            this.customerNameTitle.Name = "customerNameTitle";
            this.customerNameTitle.Size = new System.Drawing.Size(75, 44);
            this.customerNameTitle.TabIndex = 5;
            this.customerNameTitle.Text = "Name";
            // 
            // customerNameLbl
            // 
            this.customerNameLbl.AutoSize = true;
            this.customerNameLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.customerNameLbl.Location = new System.Drawing.Point(438, 9);
            this.customerNameLbl.Name = "customerNameLbl";
            this.customerNameLbl.Size = new System.Drawing.Size(201, 44);
            this.customerNameLbl.TabIndex = 4;
            this.customerNameLbl.Text = "Customer Name";
            // 
            // dateTitle
            // 
            this.dateTitle.AutoSize = true;
            this.dateTitle.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.dateTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateTitle.Location = new System.Drawing.Point(93, 53);
            this.dateTitle.Name = "dateTitle";
            this.dateTitle.Size = new System.Drawing.Size(75, 44);
            this.dateTitle.TabIndex = 7;
            this.dateTitle.Text = "Name";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.dateLbl.Location = new System.Drawing.Point(12, 53);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(75, 44);
            this.dateLbl.TabIndex = 6;
            this.dateLbl.Text = "Date";
            // 
            // totalTitle
            // 
            this.totalTitle.AutoSize = true;
            this.totalTitle.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.totalTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.totalTitle.Location = new System.Drawing.Point(519, 53);
            this.totalTitle.Name = "totalTitle";
            this.totalTitle.Size = new System.Drawing.Size(75, 44);
            this.totalTitle.TabIndex = 9;
            this.totalTitle.Text = "Name";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.totalLbl.Location = new System.Drawing.Point(438, 53);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(89, 44);
            this.totalLbl.TabIndex = 8;
            this.totalLbl.Text = "Total";
            // 
            // medRcptTable
            // 
            this.medRcptTable.AllowUserToAddRows = false;
            this.medRcptTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.medRcptTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Victor Mono", 15.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medRcptTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.medRcptTable.ColumnHeadersHeight = 58;
            this.medRcptTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.medRcptTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medName,
            this.medPrice,
            this.quantity,
            this.subTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Victor Mono", 15.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.medRcptTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.medRcptTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.medRcptTable.Location = new System.Drawing.Point(20, 100);
            this.medRcptTable.MultiSelect = false;
            this.medRcptTable.Name = "medRcptTable";
            this.medRcptTable.ReadOnly = true;
            this.medRcptTable.RowHeadersVisible = false;
            this.medRcptTable.RowHeadersWidth = 20;
            this.medRcptTable.Size = new System.Drawing.Size(768, 338);
            this.medRcptTable.TabIndex = 10;
            this.medRcptTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.medRcptTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.medRcptTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.medRcptTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.medRcptTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.medRcptTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.medRcptTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.medRcptTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.medRcptTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.medRcptTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.medRcptTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Victor Mono", 15.75F);
            this.medRcptTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.medRcptTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.medRcptTable.ThemeStyle.HeaderStyle.Height = 58;
            this.medRcptTable.ThemeStyle.ReadOnly = true;
            this.medRcptTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.medRcptTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.medRcptTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Victor Mono", 15.75F);
            this.medRcptTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.medRcptTable.ThemeStyle.RowsStyle.Height = 22;
            this.medRcptTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.medRcptTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // medName
            // 
            this.medName.HeaderText = "Medicine Name";
            this.medName.Name = "medName";
            this.medName.ReadOnly = true;
            // 
            // medPrice
            // 
            this.medPrice.FillWeight = 50F;
            this.medPrice.HeaderText = "Price";
            this.medPrice.Name = "medPrice";
            this.medPrice.ReadOnly = true;
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
            // ViewReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.medRcptTable);
            this.Controls.Add(this.totalTitle);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.dateTitle);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.customerNameTitle);
            this.Controls.Add(this.customerNameLbl);
            this.Controls.Add(this.cashierNameTitle);
            this.Controls.Add(this.cashierNameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewReceipt";
            this.Text = "View Receipt";
            ((System.ComponentModel.ISupportInitialize)(this.medRcptTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cashierNameTitle;
        private System.Windows.Forms.Label cashierNameLbl;
        private System.Windows.Forms.Label customerNameTitle;
        private System.Windows.Forms.Label customerNameLbl;
        private System.Windows.Forms.Label dateTitle;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label totalTitle;
        private System.Windows.Forms.Label totalLbl;
        private Guna.UI2.WinForms.Guna2DataGridView medRcptTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn medName;
        private System.Windows.Forms.DataGridViewTextBoxColumn medPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
    }
}