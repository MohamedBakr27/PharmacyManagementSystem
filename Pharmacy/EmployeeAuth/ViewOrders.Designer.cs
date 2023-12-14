namespace Pharmacy.EmployeeAuth
{
    partial class ViewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrders));
            this.supNameLbl = new System.Windows.Forms.Label();
            this.supNameTitle = new System.Windows.Forms.Label();
            this.orderSupplierTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orderSupplierTable)).BeginInit();
            this.SuspendLayout();
            // 
            // supNameLbl
            // 
            this.supNameLbl.AutoSize = true;
            this.supNameLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.supNameLbl.Location = new System.Drawing.Point(12, 9);
            this.supNameLbl.Name = "supNameLbl";
            this.supNameLbl.Size = new System.Drawing.Size(187, 44);
            this.supNameLbl.TabIndex = 3;
            this.supNameLbl.Text = "Supplie Name";
            // 
            // supNameTitle
            // 
            this.supNameTitle.AutoSize = true;
            this.supNameTitle.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.supNameTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.supNameTitle.Location = new System.Drawing.Point(205, 9);
            this.supNameTitle.Name = "supNameTitle";
            this.supNameTitle.Size = new System.Drawing.Size(75, 44);
            this.supNameTitle.TabIndex = 4;
            this.supNameTitle.Text = "Name";
            // 
            // orderSupplierTable
            // 
            this.orderSupplierTable.AllowUserToAddRows = false;
            this.orderSupplierTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.orderSupplierTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Victor Mono", 15.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderSupplierTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orderSupplierTable.ColumnHeadersHeight = 58;
            this.orderSupplierTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.orderSupplierTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderID,
            this.medName,
            this.quantity,
            this.orderDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Victor Mono", 15.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderSupplierTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.orderSupplierTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.orderSupplierTable.Location = new System.Drawing.Point(12, 56);
            this.orderSupplierTable.MultiSelect = false;
            this.orderSupplierTable.Name = "orderSupplierTable";
            this.orderSupplierTable.ReadOnly = true;
            this.orderSupplierTable.RowHeadersVisible = false;
            this.orderSupplierTable.RowHeadersWidth = 20;
            this.orderSupplierTable.Size = new System.Drawing.Size(776, 366);
            this.orderSupplierTable.TabIndex = 5;
            this.orderSupplierTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.orderSupplierTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.orderSupplierTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.orderSupplierTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.orderSupplierTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.orderSupplierTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.orderSupplierTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.orderSupplierTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.orderSupplierTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.orderSupplierTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.orderSupplierTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Victor Mono", 15.75F);
            this.orderSupplierTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.orderSupplierTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.orderSupplierTable.ThemeStyle.HeaderStyle.Height = 58;
            this.orderSupplierTable.ThemeStyle.ReadOnly = true;
            this.orderSupplierTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.orderSupplierTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderSupplierTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Victor Mono", 15.75F);
            this.orderSupplierTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.orderSupplierTable.ThemeStyle.RowsStyle.Height = 22;
            this.orderSupplierTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.orderSupplierTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // orderID
            // 
            this.orderID.FillWeight = 60F;
            this.orderID.HeaderText = "ID";
            this.orderID.Name = "orderID";
            this.orderID.ReadOnly = true;
            // 
            // medName
            // 
            this.medName.FillWeight = 120F;
            this.medName.HeaderText = "Medicine Name";
            this.medName.Name = "medName";
            this.medName.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // orderDate
            // 
            this.orderDate.HeaderText = "Date";
            this.orderDate.Name = "orderDate";
            this.orderDate.ReadOnly = true;
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.orderSupplierTable);
            this.Controls.Add(this.supNameTitle);
            this.Controls.Add(this.supNameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewOrders";
            this.Text = "View Orders";
            ((System.ComponentModel.ISupportInitialize)(this.orderSupplierTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label supNameLbl;
        private System.Windows.Forms.Label supNameTitle;
        private Guna.UI2.WinForms.Guna2DataGridView orderSupplierTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn medName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
    }
}