namespace Pharmacy.EmployeeAuth
{
    partial class AddMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedicine));
            this.brandNameLbl = new System.Windows.Forms.Label();
            this.medIDLbl = new System.Windows.Forms.Label();
            this.genericNameLbl = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.expityDateLbl = new System.Windows.Forms.Label();
            this.supplierLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.priceNum = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.categoryCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.typeCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.expiryDateCal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.supplierCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.brandNameTxtbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.genericNameTxtbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.medIDTxtbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.addMedBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).BeginInit();
            this.SuspendLayout();
            // 
            // brandNameLbl
            // 
            this.brandNameLbl.AutoSize = true;
            this.brandNameLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.brandNameLbl.Location = new System.Drawing.Point(12, 98);
            this.brandNameLbl.Name = "brandNameLbl";
            this.brandNameLbl.Size = new System.Drawing.Size(159, 44);
            this.brandNameLbl.TabIndex = 1;
            this.brandNameLbl.Text = "Brand Name";
            // 
            // medIDLbl
            // 
            this.medIDLbl.AutoSize = true;
            this.medIDLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.medIDLbl.Location = new System.Drawing.Point(12, 9);
            this.medIDLbl.Name = "medIDLbl";
            this.medIDLbl.Size = new System.Drawing.Size(173, 44);
            this.medIDLbl.TabIndex = 2;
            this.medIDLbl.Text = "Medicine ID";
            // 
            // genericNameLbl
            // 
            this.genericNameLbl.AutoSize = true;
            this.genericNameLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.genericNameLbl.Location = new System.Drawing.Point(12, 52);
            this.genericNameLbl.Name = "genericNameLbl";
            this.genericNameLbl.Size = new System.Drawing.Size(187, 44);
            this.genericNameLbl.TabIndex = 3;
            this.genericNameLbl.Text = "Generic Name";
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.categoryLbl.Location = new System.Drawing.Point(416, 9);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(131, 44);
            this.categoryLbl.TabIndex = 4;
            this.categoryLbl.Text = "Category";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.typeLbl.Location = new System.Drawing.Point(416, 53);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(75, 44);
            this.typeLbl.TabIndex = 5;
            this.typeLbl.Text = "Type";
            // 
            // expityDateLbl
            // 
            this.expityDateLbl.AutoSize = true;
            this.expityDateLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.expityDateLbl.Location = new System.Drawing.Point(416, 97);
            this.expityDateLbl.Name = "expityDateLbl";
            this.expityDateLbl.Size = new System.Drawing.Size(103, 44);
            this.expityDateLbl.TabIndex = 6;
            this.expityDateLbl.Text = "Expiry";
            // 
            // supplierLbl
            // 
            this.supplierLbl.AutoSize = true;
            this.supplierLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.supplierLbl.Location = new System.Drawing.Point(12, 141);
            this.supplierLbl.Name = "supplierLbl";
            this.supplierLbl.Size = new System.Drawing.Size(131, 44);
            this.supplierLbl.TabIndex = 7;
            this.supplierLbl.Text = "Supplier";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.priceLbl.Location = new System.Drawing.Point(416, 141);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(89, 44);
            this.priceLbl.TabIndex = 8;
            this.priceLbl.Text = "Price";
            // 
            // priceNum
            // 
            this.priceNum.BackColor = System.Drawing.Color.Transparent;
            this.priceNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceNum.Font = new System.Drawing.Font("Victor Mono", 11F);
            this.priceNum.Location = new System.Drawing.Point(553, 149);
            this.priceNum.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.priceNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priceNum.Name = "priceNum";
            this.priceNum.Size = new System.Drawing.Size(235, 36);
            this.priceNum.TabIndex = 8;
            this.priceNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // categoryCb
            // 
            this.categoryCb.BackColor = System.Drawing.Color.Transparent;
            this.categoryCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoryCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryCb.Font = new System.Drawing.Font("Victor Mono", 11F);
            this.categoryCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.categoryCb.ItemHeight = 30;
            this.categoryCb.Items.AddRange(new object[] {
            "Cold Drugs",
            "Antineoplastic",
            "Lubricant",
            "Vitamin A",
            "Soothing Topical",
            "Soothing Agent",
            "Eye Contour",
            "Vitamine C",
            "Antiseptic",
            "Multivitamins",
            "Whitening Topical",
            "Vaccine",
            "Psychiatric Antipsychotics",
            "Lazative",
            "Oral Care",
            "Immunosuppressant",
            "Immunosuppressants",
            "Antioxidant",
            "Psychiatric Antidepressants",
            "Analgesics Opioid",
            "Diaper Rash",
            "Mucolytic",
            "Antipyretic",
            "Glucocorticoid",
            "Vaginal Care",
            "Cold Products",
            "Menstrual Pain Releif"});
            this.categoryCb.Location = new System.Drawing.Point(553, 17);
            this.categoryCb.Name = "categoryCb";
            this.categoryCb.Size = new System.Drawing.Size(235, 36);
            this.categoryCb.TabIndex = 5;
            // 
            // typeCb
            // 
            this.typeCb.BackColor = System.Drawing.Color.Transparent;
            this.typeCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.typeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.typeCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.typeCb.Font = new System.Drawing.Font("Victor Mono", 11F);
            this.typeCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.typeCb.ItemHeight = 30;
            this.typeCb.Items.AddRange(new object[] {
            "Tablet",
            "Gel",
            "Vial",
            "Capsule",
            "Solution",
            "Cream",
            "Syrup",
            "Sachet",
            "Mouth Drops",
            "Suppository",
            "Eye Drops",
            "Effervescent",
            "Syringe",
            "Vaginal Douche",
            "Pen",
            "Suspension",
            "Ampoule",
            "Bottle",
            "Piece",
            "Paint"});
            this.typeCb.Location = new System.Drawing.Point(553, 61);
            this.typeCb.Name = "typeCb";
            this.typeCb.Size = new System.Drawing.Size(235, 36);
            this.typeCb.TabIndex = 6;
            // 
            // expiryDateCal
            // 
            this.expiryDateCal.Checked = true;
            this.expiryDateCal.FillColor = System.Drawing.Color.White;
            this.expiryDateCal.Font = new System.Drawing.Font("Victor Mono", 9F);
            this.expiryDateCal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expiryDateCal.Location = new System.Drawing.Point(553, 105);
            this.expiryDateCal.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.expiryDateCal.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.expiryDateCal.Name = "expiryDateCal";
            this.expiryDateCal.Size = new System.Drawing.Size(235, 36);
            this.expiryDateCal.TabIndex = 7;
            this.expiryDateCal.Value = new System.DateTime(2023, 12, 1, 12, 45, 42, 18);
            // 
            // supplierCb
            // 
            this.supplierCb.BackColor = System.Drawing.Color.Transparent;
            this.supplierCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.supplierCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supplierCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supplierCb.Font = new System.Drawing.Font("Victor Mono", 11F);
            this.supplierCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.supplierCb.ItemHeight = 30;
            this.supplierCb.Location = new System.Drawing.Point(194, 146);
            this.supplierCb.Name = "supplierCb";
            this.supplierCb.Size = new System.Drawing.Size(202, 36);
            this.supplierCb.TabIndex = 4;
            // 
            // brandNameTxtbx
            // 
            this.brandNameTxtbx.BorderThickness = 0;
            this.brandNameTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.brandNameTxtbx.DefaultText = "";
            this.brandNameTxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.brandNameTxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.brandNameTxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.brandNameTxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.brandNameTxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.brandNameTxtbx.Font = new System.Drawing.Font("Victor Mono", 11F);
            this.brandNameTxtbx.ForeColor = System.Drawing.Color.Black;
            this.brandNameTxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.brandNameTxtbx.Location = new System.Drawing.Point(194, 102);
            this.brandNameTxtbx.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.brandNameTxtbx.Name = "brandNameTxtbx";
            this.brandNameTxtbx.PasswordChar = '\0';
            this.brandNameTxtbx.PlaceholderText = "";
            this.brandNameTxtbx.SelectedText = "";
            this.brandNameTxtbx.Size = new System.Drawing.Size(202, 35);
            this.brandNameTxtbx.TabIndex = 3;
            this.brandNameTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // genericNameTxtbx
            // 
            this.genericNameTxtbx.BorderThickness = 0;
            this.genericNameTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.genericNameTxtbx.DefaultText = "";
            this.genericNameTxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.genericNameTxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.genericNameTxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.genericNameTxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.genericNameTxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genericNameTxtbx.Font = new System.Drawing.Font("Victor Mono", 11F);
            this.genericNameTxtbx.ForeColor = System.Drawing.Color.Black;
            this.genericNameTxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genericNameTxtbx.Location = new System.Drawing.Point(194, 58);
            this.genericNameTxtbx.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.genericNameTxtbx.Name = "genericNameTxtbx";
            this.genericNameTxtbx.PasswordChar = '\0';
            this.genericNameTxtbx.PlaceholderText = "";
            this.genericNameTxtbx.SelectedText = "";
            this.genericNameTxtbx.Size = new System.Drawing.Size(202, 35);
            this.genericNameTxtbx.TabIndex = 2;
            this.genericNameTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // medIDTxtbx
            // 
            this.medIDTxtbx.BorderThickness = 0;
            this.medIDTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.medIDTxtbx.DefaultText = "";
            this.medIDTxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.medIDTxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.medIDTxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.medIDTxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.medIDTxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medIDTxtbx.Font = new System.Drawing.Font("Victor Mono", 11F);
            this.medIDTxtbx.ForeColor = System.Drawing.Color.Black;
            this.medIDTxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medIDTxtbx.Location = new System.Drawing.Point(194, 15);
            this.medIDTxtbx.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.medIDTxtbx.Name = "medIDTxtbx";
            this.medIDTxtbx.PasswordChar = '\0';
            this.medIDTxtbx.PlaceholderText = "";
            this.medIDTxtbx.SelectedText = "";
            this.medIDTxtbx.Size = new System.Drawing.Size(202, 35);
            this.medIDTxtbx.TabIndex = 1;
            this.medIDTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addMedBtn
            // 
            this.addMedBtn.BorderRadius = 7;
            this.addMedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addMedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addMedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addMedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addMedBtn.FillColor = System.Drawing.Color.LightSkyBlue;
            this.addMedBtn.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.addMedBtn.ForeColor = System.Drawing.Color.White;
            this.addMedBtn.Location = new System.Drawing.Point(349, 233);
            this.addMedBtn.Name = "addMedBtn";
            this.addMedBtn.Size = new System.Drawing.Size(142, 46);
            this.addMedBtn.TabIndex = 9;
            this.addMedBtn.Text = "Add";
            this.addMedBtn.Click += new System.EventHandler(this.addMedBtn_Click);
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 291);
            this.Controls.Add(this.addMedBtn);
            this.Controls.Add(this.medIDTxtbx);
            this.Controls.Add(this.genericNameTxtbx);
            this.Controls.Add(this.brandNameTxtbx);
            this.Controls.Add(this.supplierCb);
            this.Controls.Add(this.expiryDateCal);
            this.Controls.Add(this.typeCb);
            this.Controls.Add(this.categoryCb);
            this.Controls.Add(this.priceNum);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.supplierLbl);
            this.Controls.Add(this.expityDateLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.genericNameLbl);
            this.Controls.Add(this.medIDLbl);
            this.Controls.Add(this.brandNameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddMedicine";
            this.Text = "Add Medicine";
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label brandNameLbl;
        private System.Windows.Forms.Label medIDLbl;
        private System.Windows.Forms.Label genericNameLbl;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label expityDateLbl;
        private System.Windows.Forms.Label supplierLbl;
        private System.Windows.Forms.Label priceLbl;
        private Guna.UI2.WinForms.Guna2NumericUpDown priceNum;
        private Guna.UI2.WinForms.Guna2ComboBox categoryCb;
        private Guna.UI2.WinForms.Guna2ComboBox typeCb;
        private Guna.UI2.WinForms.Guna2DateTimePicker expiryDateCal;
        private Guna.UI2.WinForms.Guna2ComboBox supplierCb;
        private Guna.UI2.WinForms.Guna2TextBox brandNameTxtbx;
        private Guna.UI2.WinForms.Guna2TextBox genericNameTxtbx;
        private Guna.UI2.WinForms.Guna2TextBox medIDTxtbx;
        private Guna.UI2.WinForms.Guna2Button addMedBtn;
    }
}