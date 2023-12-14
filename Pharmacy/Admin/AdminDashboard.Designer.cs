namespace Pharmacy.Admin
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.doctorBtn = new Guna.UI2.WinForms.Guna2Button();
            this.customerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cashierBtn = new Guna.UI2.WinForms.Guna2Button();
            this.fnameLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.fnameTxtbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.lnameLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lnameTxtbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.passLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.passTxtbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.usrnameLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.usrnameTxtbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.viewBtn = new Guna.UI2.WinForms.Guna2Button();
            this.removeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.shiftLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.shiftTxtbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.viewTxtbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.resetBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // doctorBtn
            // 
            this.doctorBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.doctorBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.doctorBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.doctorBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.doctorBtn.FillColor = System.Drawing.Color.SlateGray;
            this.doctorBtn.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.doctorBtn.ForeColor = System.Drawing.Color.White;
            this.doctorBtn.Location = new System.Drawing.Point(-1, 492);
            this.doctorBtn.Name = "doctorBtn";
            this.doctorBtn.Size = new System.Drawing.Size(319, 45);
            this.doctorBtn.TabIndex = 0;
            this.doctorBtn.Text = "Doctor";
            this.doctorBtn.Click += new System.EventHandler(this.doctorBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customerBtn.FillColor = System.Drawing.Color.SlateGray;
            this.customerBtn.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.customerBtn.ForeColor = System.Drawing.Color.White;
            this.customerBtn.Location = new System.Drawing.Point(324, 492);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(319, 45);
            this.customerBtn.TabIndex = 1;
            this.customerBtn.Text = "Customer";
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // cashierBtn
            // 
            this.cashierBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cashierBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cashierBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cashierBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cashierBtn.FillColor = System.Drawing.Color.SlateGray;
            this.cashierBtn.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.cashierBtn.ForeColor = System.Drawing.Color.White;
            this.cashierBtn.Location = new System.Drawing.Point(649, 492);
            this.cashierBtn.Name = "cashierBtn";
            this.cashierBtn.Size = new System.Drawing.Size(326, 45);
            this.cashierBtn.TabIndex = 2;
            this.cashierBtn.Text = "Cashier";
            this.cashierBtn.Click += new System.EventHandler(this.cashierBtn_Click);
            // 
            // fnameLbl
            // 
            this.fnameLbl.BackColor = System.Drawing.Color.Transparent;
            this.fnameLbl.Font = new System.Drawing.Font("Victor Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameLbl.IsSelectionEnabled = false;
            this.fnameLbl.Location = new System.Drawing.Point(10, 26);
            this.fnameLbl.Name = "fnameLbl";
            this.fnameLbl.Size = new System.Drawing.Size(103, 31);
            this.fnameLbl.TabIndex = 102;
            this.fnameLbl.TabStop = false;
            this.fnameLbl.Text = "First Name";
            // 
            // fnameTxtbx
            // 
            this.fnameTxtbx.BorderRadius = 10;
            this.fnameTxtbx.BorderThickness = 0;
            this.fnameTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fnameTxtbx.DefaultText = "";
            this.fnameTxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fnameTxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fnameTxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fnameTxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fnameTxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fnameTxtbx.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.fnameTxtbx.ForeColor = System.Drawing.Color.Black;
            this.fnameTxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fnameTxtbx.Location = new System.Drawing.Point(116, 18);
            this.fnameTxtbx.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.fnameTxtbx.Name = "fnameTxtbx";
            this.fnameTxtbx.PasswordChar = '\0';
            this.fnameTxtbx.PlaceholderText = "";
            this.fnameTxtbx.SelectedText = "";
            this.fnameTxtbx.Size = new System.Drawing.Size(269, 37);
            this.fnameTxtbx.TabIndex = 101;
            this.fnameTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lnameLbl
            // 
            this.lnameLbl.BackColor = System.Drawing.Color.Transparent;
            this.lnameLbl.Font = new System.Drawing.Font("Victor Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameLbl.IsSelectionEnabled = false;
            this.lnameLbl.Location = new System.Drawing.Point(18, 79);
            this.lnameLbl.Name = "lnameLbl";
            this.lnameLbl.Size = new System.Drawing.Size(93, 31);
            this.lnameLbl.TabIndex = 108;
            this.lnameLbl.TabStop = false;
            this.lnameLbl.Text = "Last Name";
            // 
            // lnameTxtbx
            // 
            this.lnameTxtbx.BorderRadius = 10;
            this.lnameTxtbx.BorderThickness = 0;
            this.lnameTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lnameTxtbx.DefaultText = "";
            this.lnameTxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lnameTxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lnameTxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lnameTxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lnameTxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lnameTxtbx.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.lnameTxtbx.ForeColor = System.Drawing.Color.Black;
            this.lnameTxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lnameTxtbx.Location = new System.Drawing.Point(116, 73);
            this.lnameTxtbx.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.lnameTxtbx.Name = "lnameTxtbx";
            this.lnameTxtbx.PasswordChar = '\0';
            this.lnameTxtbx.PlaceholderText = "";
            this.lnameTxtbx.SelectedText = "";
            this.lnameTxtbx.Size = new System.Drawing.Size(269, 37);
            this.lnameTxtbx.TabIndex = 105;
            this.lnameTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passLbl
            // 
            this.passLbl.BackColor = System.Drawing.Color.Transparent;
            this.passLbl.Font = new System.Drawing.Font("Victor Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLbl.IsSelectionEnabled = false;
            this.passLbl.Location = new System.Drawing.Point(28, 189);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(83, 31);
            this.passLbl.TabIndex = 110;
            this.passLbl.TabStop = false;
            this.passLbl.Text = "Password";
            // 
            // passTxtbx
            // 
            this.passTxtbx.BorderRadius = 10;
            this.passTxtbx.BorderThickness = 0;
            this.passTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTxtbx.DefaultText = "";
            this.passTxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passTxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passTxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTxtbx.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.passTxtbx.ForeColor = System.Drawing.Color.Black;
            this.passTxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTxtbx.Location = new System.Drawing.Point(116, 183);
            this.passTxtbx.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.passTxtbx.Name = "passTxtbx";
            this.passTxtbx.PasswordChar = '\0';
            this.passTxtbx.PlaceholderText = "";
            this.passTxtbx.SelectedText = "";
            this.passTxtbx.Size = new System.Drawing.Size(269, 37);
            this.passTxtbx.TabIndex = 107;
            this.passTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usrnameLbl
            // 
            this.usrnameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usrnameLbl.Font = new System.Drawing.Font("Victor Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrnameLbl.IsSelectionEnabled = false;
            this.usrnameLbl.Location = new System.Drawing.Point(28, 134);
            this.usrnameLbl.Name = "usrnameLbl";
            this.usrnameLbl.Size = new System.Drawing.Size(83, 31);
            this.usrnameLbl.TabIndex = 111;
            this.usrnameLbl.TabStop = false;
            this.usrnameLbl.Text = "Username";
            // 
            // usrnameTxtbx
            // 
            this.usrnameTxtbx.BorderRadius = 10;
            this.usrnameTxtbx.BorderThickness = 0;
            this.usrnameTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usrnameTxtbx.DefaultText = "";
            this.usrnameTxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usrnameTxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usrnameTxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usrnameTxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usrnameTxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usrnameTxtbx.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.usrnameTxtbx.ForeColor = System.Drawing.Color.Black;
            this.usrnameTxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usrnameTxtbx.Location = new System.Drawing.Point(116, 128);
            this.usrnameTxtbx.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.usrnameTxtbx.Name = "usrnameTxtbx";
            this.usrnameTxtbx.PasswordChar = '\0';
            this.usrnameTxtbx.PlaceholderText = "";
            this.usrnameTxtbx.SelectedText = "";
            this.usrnameTxtbx.Size = new System.Drawing.Size(269, 37);
            this.usrnameTxtbx.TabIndex = 106;
            this.usrnameTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addBtn
            // 
            this.addBtn.BorderRadius = 15;
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.FillColor = System.Drawing.Color.DarkTurquoise;
            this.addBtn.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(768, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(195, 45);
            this.addBtn.TabIndex = 112;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BorderRadius = 15;
            this.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBtn.FillColor = System.Drawing.Color.DarkTurquoise;
            this.updateBtn.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(768, 63);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(195, 45);
            this.updateBtn.TabIndex = 113;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewBtn.FillColor = System.Drawing.Color.DarkTurquoise;
            this.viewBtn.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.viewBtn.ForeColor = System.Drawing.Color.White;
            this.viewBtn.Location = new System.Drawing.Point(768, 397);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(195, 45);
            this.viewBtn.TabIndex = 114;
            this.viewBtn.Text = "View";
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BorderRadius = 15;
            this.removeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.removeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.removeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.removeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.removeBtn.FillColor = System.Drawing.Color.DarkTurquoise;
            this.removeBtn.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(768, 114);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(195, 45);
            this.removeBtn.TabIndex = 115;
            this.removeBtn.Text = "Remove";
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // shiftLbl
            // 
            this.shiftLbl.BackColor = System.Drawing.Color.Transparent;
            this.shiftLbl.Font = new System.Drawing.Font("Victor Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftLbl.IsSelectionEnabled = false;
            this.shiftLbl.Location = new System.Drawing.Point(60, 244);
            this.shiftLbl.Name = "shiftLbl";
            this.shiftLbl.Size = new System.Drawing.Size(53, 31);
            this.shiftLbl.TabIndex = 117;
            this.shiftLbl.TabStop = false;
            this.shiftLbl.Text = "Shift";
            this.shiftLbl.Visible = false;
            // 
            // shiftTxtbx
            // 
            this.shiftTxtbx.BorderRadius = 10;
            this.shiftTxtbx.BorderThickness = 0;
            this.shiftTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.shiftTxtbx.DefaultText = "";
            this.shiftTxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.shiftTxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.shiftTxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.shiftTxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.shiftTxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shiftTxtbx.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.shiftTxtbx.ForeColor = System.Drawing.Color.Black;
            this.shiftTxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shiftTxtbx.Location = new System.Drawing.Point(116, 238);
            this.shiftTxtbx.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.shiftTxtbx.Name = "shiftTxtbx";
            this.shiftTxtbx.PasswordChar = '\0';
            this.shiftTxtbx.PlaceholderText = "";
            this.shiftTxtbx.SelectedText = "";
            this.shiftTxtbx.Size = new System.Drawing.Size(269, 37);
            this.shiftTxtbx.TabIndex = 108;
            this.shiftTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.shiftTxtbx.Visible = false;
            // 
            // viewTxtbx
            // 
            this.viewTxtbx.BorderThickness = 0;
            this.viewTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viewTxtbx.DefaultText = "";
            this.viewTxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.viewTxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.viewTxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.viewTxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.viewTxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.viewTxtbx.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.viewTxtbx.ForeColor = System.Drawing.Color.Black;
            this.viewTxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.viewTxtbx.Location = new System.Drawing.Point(768, 346);
            this.viewTxtbx.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.viewTxtbx.Name = "viewTxtbx";
            this.viewTxtbx.PasswordChar = '\0';
            this.viewTxtbx.PlaceholderText = "";
            this.viewTxtbx.SelectedText = "";
            this.viewTxtbx.Size = new System.Drawing.Size(192, 59);
            this.viewTxtbx.TabIndex = 118;
            this.viewTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Victor Mono SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(817, 309);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(91, 37);
            this.guna2HtmlLabel1.TabIndex = 119;
            this.guna2HtmlLabel1.TabStop = false;
            this.guna2HtmlLabel1.Text = "Username";
            // 
            // resetBtn
            // 
            this.resetBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetBtn.FillColor = System.Drawing.Color.Goldenrod;
            this.resetBtn.Font = new System.Drawing.Font("Victor Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(768, 189);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(195, 45);
            this.resetBtn.TabIndex = 120;
            this.resetBtn.Text = "Reset System";
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 536);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.viewTxtbx);
            this.Controls.Add(this.shiftLbl);
            this.Controls.Add(this.shiftTxtbx);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.lnameLbl);
            this.Controls.Add(this.lnameTxtbx);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.passTxtbx);
            this.Controls.Add(this.usrnameLbl);
            this.Controls.Add(this.usrnameTxtbx);
            this.Controls.Add(this.fnameLbl);
            this.Controls.Add(this.fnameTxtbx);
            this.Controls.Add(this.cashierBtn);
            this.Controls.Add(this.customerBtn);
            this.Controls.Add(this.doctorBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button doctorBtn;
        private Guna.UI2.WinForms.Guna2Button customerBtn;
        private Guna.UI2.WinForms.Guna2Button cashierBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel fnameLbl;
        private Guna.UI2.WinForms.Guna2TextBox fnameTxtbx;
        private Guna.UI2.WinForms.Guna2HtmlLabel lnameLbl;
        private Guna.UI2.WinForms.Guna2TextBox lnameTxtbx;
        private Guna.UI2.WinForms.Guna2HtmlLabel passLbl;
        private Guna.UI2.WinForms.Guna2TextBox passTxtbx;
        private Guna.UI2.WinForms.Guna2HtmlLabel usrnameLbl;
        private Guna.UI2.WinForms.Guna2TextBox usrnameTxtbx;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2Button viewBtn;
        private Guna.UI2.WinForms.Guna2Button removeBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel shiftLbl;
        private Guna.UI2.WinForms.Guna2TextBox shiftTxtbx;
        private Guna.UI2.WinForms.Guna2TextBox viewTxtbx;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button resetBtn;
    }
}