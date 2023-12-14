namespace Pharmacy.CustomerAuth
{
    partial class CustomerDashboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            this.tabs = new Guna.UI2.WinForms.Guna2TabControl();
            this.dashboardTab = new System.Windows.Forms.TabPage();
            this.changePassBtn = new Guna.UI2.WinForms.Guna2Button();
            this.changeNameBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.tit3 = new System.Windows.Forms.Label();
            this.tit2 = new System.Windows.Forms.Label();
            this.tit1 = new System.Windows.Forms.Label();
            this.spentLbl = new System.Windows.Forms.Label();
            this.ordersNumLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.stockTab = new System.Windows.Forms.TabPage();
            this.searchTxtbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.buyMedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.viewMedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.stockTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.medID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genericName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedbackTab = new System.Windows.Forms.TabPage();
            this.sendFeedbackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.viewFeedbackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.feedbackTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.feedbackID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedbackCont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedbackDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersTab = new System.Windows.Forms.TabPage();
            this.viewRcptBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ordersTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.rcptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.tabs.SuspendLayout();
            this.dashboardTab.SuspendLayout();
            this.stockTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockTable)).BeginInit();
            this.feedbackTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackTable)).BeginInit();
            this.ordersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabs.Controls.Add(this.dashboardTab);
            this.tabs.Controls.Add(this.stockTab);
            this.tabs.Controls.Add(this.feedbackTab);
            this.tabs.Controls.Add(this.ordersTab);
            this.tabs.Font = new System.Drawing.Font("Victor Mono", 12.75F);
            this.tabs.ItemSize = new System.Drawing.Size(150, 40);
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(976, 540);
            this.tabs.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabs.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabs.TabButtonHoverState.Font = new System.Drawing.Font("Victor Mono", 15.75F);
            this.tabs.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabs.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabs.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabs.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabs.TabButtonIdleState.Font = new System.Drawing.Font("Victor Mono", 11.75F);
            this.tabs.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabs.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabs.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabs.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabs.TabButtonSelectedState.Font = new System.Drawing.Font("Victor Mono", 12.75F);
            this.tabs.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabs.TabButtonSelectedState.InnerColor = System.Drawing.SystemColors.Highlight;
            this.tabs.TabButtonSize = new System.Drawing.Size(150, 40);
            this.tabs.TabIndex = 118;
            this.tabs.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // dashboardTab
            // 
            this.dashboardTab.Controls.Add(this.guna2Separator2);
            this.dashboardTab.Controls.Add(this.logoutBtn);
            this.dashboardTab.Controls.Add(this.changePassBtn);
            this.dashboardTab.Controls.Add(this.changeNameBtn);
            this.dashboardTab.Controls.Add(this.guna2Separator1);
            this.dashboardTab.Controls.Add(this.tit3);
            this.dashboardTab.Controls.Add(this.tit2);
            this.dashboardTab.Controls.Add(this.tit1);
            this.dashboardTab.Controls.Add(this.spentLbl);
            this.dashboardTab.Controls.Add(this.ordersNumLbl);
            this.dashboardTab.Controls.Add(this.userNameLbl);
            this.dashboardTab.Location = new System.Drawing.Point(154, 4);
            this.dashboardTab.Name = "dashboardTab";
            this.dashboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardTab.Size = new System.Drawing.Size(818, 532);
            this.dashboardTab.TabIndex = 0;
            this.dashboardTab.Text = "Dashboard";
            this.dashboardTab.UseVisualStyleBackColor = true;
            // 
            // changePassBtn
            // 
            this.changePassBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changePassBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changePassBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changePassBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changePassBtn.FillColor = System.Drawing.Color.SlateGray;
            this.changePassBtn.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.changePassBtn.ForeColor = System.Drawing.Color.White;
            this.changePassBtn.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.changePassBtn.Location = new System.Drawing.Point(542, 76);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(267, 46);
            this.changePassBtn.TabIndex = 22;
            this.changePassBtn.Text = "Change Password";
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // changeNameBtn
            // 
            this.changeNameBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changeNameBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changeNameBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changeNameBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changeNameBtn.FillColor = System.Drawing.Color.SlateGray;
            this.changeNameBtn.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.changeNameBtn.ForeColor = System.Drawing.Color.White;
            this.changeNameBtn.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.changeNameBtn.Location = new System.Drawing.Point(11, 76);
            this.changeNameBtn.Name = "changeNameBtn";
            this.changeNameBtn.Size = new System.Drawing.Size(206, 46);
            this.changeNameBtn.TabIndex = 21;
            this.changeNameBtn.Text = "Change Name";
            this.changeNameBtn.Click += new System.EventHandler(this.changeNameBtn_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Silver;
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 52);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(822, 18);
            this.guna2Separator1.TabIndex = 20;
            // 
            // tit3
            // 
            this.tit3.AutoSize = true;
            this.tit3.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.tit3.Location = new System.Drawing.Point(601, 5);
            this.tit3.Name = "tit3";
            this.tit3.Size = new System.Drawing.Size(117, 44);
            this.tit3.TabIndex = 17;
            this.tit3.Text = "Spent :";
            // 
            // tit2
            // 
            this.tit2.AutoSize = true;
            this.tit2.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.tit2.Location = new System.Drawing.Point(277, 5);
            this.tit2.Name = "tit2";
            this.tit2.Size = new System.Drawing.Size(131, 44);
            this.tit2.TabIndex = 16;
            this.tit2.Text = "Orders :";
            // 
            // tit1
            // 
            this.tit1.AutoSize = true;
            this.tit1.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.tit1.Location = new System.Drawing.Point(3, 5);
            this.tit1.Name = "tit1";
            this.tit1.Size = new System.Drawing.Size(103, 44);
            this.tit1.TabIndex = 15;
            this.tit1.Text = "Name :";
            // 
            // spentLbl
            // 
            this.spentLbl.AutoSize = true;
            this.spentLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.spentLbl.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.spentLbl.Location = new System.Drawing.Point(724, 5);
            this.spentLbl.Name = "spentLbl";
            this.spentLbl.Size = new System.Drawing.Size(33, 44);
            this.spentLbl.TabIndex = 14;
            this.spentLbl.Text = "T";
            // 
            // ordersNumLbl
            // 
            this.ordersNumLbl.AutoSize = true;
            this.ordersNumLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.ordersNumLbl.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.ordersNumLbl.Location = new System.Drawing.Point(406, 5);
            this.ordersNumLbl.Name = "ordersNumLbl";
            this.ordersNumLbl.Size = new System.Drawing.Size(33, 44);
            this.ordersNumLbl.TabIndex = 13;
            this.ordersNumLbl.Text = "T";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.userNameLbl.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.userNameLbl.Location = new System.Drawing.Point(112, 5);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(33, 44);
            this.userNameLbl.TabIndex = 11;
            this.userNameLbl.Text = "T";
            // 
            // stockTab
            // 
            this.stockTab.Controls.Add(this.searchTxtbx);
            this.stockTab.Controls.Add(this.buyMedBtn);
            this.stockTab.Controls.Add(this.viewMedBtn);
            this.stockTab.Controls.Add(this.stockTable);
            this.stockTab.Font = new System.Drawing.Font("Victor Mono", 10.75F);
            this.stockTab.Location = new System.Drawing.Point(154, 4);
            this.stockTab.Name = "stockTab";
            this.stockTab.Padding = new System.Windows.Forms.Padding(3);
            this.stockTab.Size = new System.Drawing.Size(818, 532);
            this.stockTab.TabIndex = 1;
            this.stockTab.Text = "Stock";
            this.stockTab.UseVisualStyleBackColor = true;
            // 
            // searchTxtbx
            // 
            this.searchTxtbx.BorderThickness = 0;
            this.searchTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxtbx.DefaultText = "";
            this.searchTxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTxtbx.FillColor = System.Drawing.Color.LightGray;
            this.searchTxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTxtbx.Font = new System.Drawing.Font("Victor Mono", 12F);
            this.searchTxtbx.ForeColor = System.Drawing.Color.Black;
            this.searchTxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTxtbx.Location = new System.Drawing.Point(297, 486);
            this.searchTxtbx.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchTxtbx.Name = "searchTxtbx";
            this.searchTxtbx.PasswordChar = '\0';
            this.searchTxtbx.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.searchTxtbx.PlaceholderText = "Search";
            this.searchTxtbx.SelectedText = "";
            this.searchTxtbx.Size = new System.Drawing.Size(521, 46);
            this.searchTxtbx.TabIndex = 7;
            this.searchTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTxtbx.TextChanged += new System.EventHandler(this.searchTxtbx_TextChanged);
            // 
            // buyMedBtn
            // 
            this.buyMedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buyMedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buyMedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buyMedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buyMedBtn.FillColor = System.Drawing.Color.SlateGray;
            this.buyMedBtn.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.buyMedBtn.ForeColor = System.Drawing.Color.White;
            this.buyMedBtn.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.buyMedBtn.Location = new System.Drawing.Point(148, 486);
            this.buyMedBtn.Name = "buyMedBtn";
            this.buyMedBtn.Size = new System.Drawing.Size(142, 46);
            this.buyMedBtn.TabIndex = 3;
            this.buyMedBtn.Text = "Buy";
            this.buyMedBtn.Click += new System.EventHandler(this.buyMedBtn_Click);
            // 
            // viewMedBtn
            // 
            this.viewMedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewMedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewMedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewMedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewMedBtn.FillColor = System.Drawing.Color.SlateGray;
            this.viewMedBtn.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.viewMedBtn.ForeColor = System.Drawing.Color.White;
            this.viewMedBtn.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.viewMedBtn.Location = new System.Drawing.Point(0, 486);
            this.viewMedBtn.Name = "viewMedBtn";
            this.viewMedBtn.Size = new System.Drawing.Size(142, 46);
            this.viewMedBtn.TabIndex = 2;
            this.viewMedBtn.Text = "View";
            this.viewMedBtn.Click += new System.EventHandler(this.viewMedBtn_Click);
            // 
            // stockTable
            // 
            this.stockTable.AllowUserToAddRows = false;
            this.stockTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.stockTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Victor Mono", 10.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.stockTable.ColumnHeadersHeight = 58;
            this.stockTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.stockTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medID,
            this.genericName,
            this.brandName,
            this.category,
            this.type,
            this.expDate,
            this.supName,
            this.price,
            this.quantity});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Victor Mono", 10.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.stockTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.stockTable.Location = new System.Drawing.Point(1, 1);
            this.stockTable.Name = "stockTable";
            this.stockTable.ReadOnly = true;
            this.stockTable.RowHeadersVisible = false;
            this.stockTable.RowHeadersWidth = 20;
            this.stockTable.Size = new System.Drawing.Size(818, 486);
            this.stockTable.TabIndex = 0;
            this.stockTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.stockTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.stockTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.stockTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.stockTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.stockTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.stockTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.stockTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.stockTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.stockTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.stockTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Victor Mono", 10.75F);
            this.stockTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.stockTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.stockTable.ThemeStyle.HeaderStyle.Height = 58;
            this.stockTable.ThemeStyle.ReadOnly = true;
            this.stockTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.stockTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.stockTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Victor Mono", 10.75F);
            this.stockTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.stockTable.ThemeStyle.RowsStyle.Height = 22;
            this.stockTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.stockTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.stockTable.SelectionChanged += new System.EventHandler(this.stockTable_SelectionChanged);
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
            // brandName
            // 
            this.brandName.FillWeight = 91.37057F;
            this.brandName.HeaderText = "Brand Name";
            this.brandName.Name = "brandName";
            this.brandName.ReadOnly = true;
            // 
            // category
            // 
            this.category.FillWeight = 103.7096F;
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // type
            // 
            this.type.FillWeight = 103.7096F;
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // expDate
            // 
            this.expDate.FillWeight = 103.7096F;
            this.expDate.HeaderText = "Expiry Date";
            this.expDate.Name = "expDate";
            this.expDate.ReadOnly = true;
            // 
            // supName
            // 
            this.supName.FillWeight = 103.7096F;
            this.supName.HeaderText = "Supplier";
            this.supName.Name = "supName";
            this.supName.ReadOnly = true;
            // 
            // price
            // 
            this.price.FillWeight = 103.7096F;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.FillWeight = 103.7096F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // feedbackTab
            // 
            this.feedbackTab.Controls.Add(this.sendFeedbackBtn);
            this.feedbackTab.Controls.Add(this.viewFeedbackBtn);
            this.feedbackTab.Controls.Add(this.feedbackTable);
            this.feedbackTab.Location = new System.Drawing.Point(154, 4);
            this.feedbackTab.Name = "feedbackTab";
            this.feedbackTab.Padding = new System.Windows.Forms.Padding(3);
            this.feedbackTab.Size = new System.Drawing.Size(818, 532);
            this.feedbackTab.TabIndex = 2;
            this.feedbackTab.Text = "Feedback";
            this.feedbackTab.UseVisualStyleBackColor = true;
            // 
            // sendFeedbackBtn
            // 
            this.sendFeedbackBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendFeedbackBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendFeedbackBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendFeedbackBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendFeedbackBtn.FillColor = System.Drawing.Color.SlateGray;
            this.sendFeedbackBtn.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.sendFeedbackBtn.ForeColor = System.Drawing.Color.White;
            this.sendFeedbackBtn.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.sendFeedbackBtn.Location = new System.Drawing.Point(0, 486);
            this.sendFeedbackBtn.Name = "sendFeedbackBtn";
            this.sendFeedbackBtn.Size = new System.Drawing.Size(376, 46);
            this.sendFeedbackBtn.TabIndex = 5;
            this.sendFeedbackBtn.Text = "Send";
            this.sendFeedbackBtn.Click += new System.EventHandler(this.sendFeedbackBtn_Click);
            // 
            // viewFeedbackBtn
            // 
            this.viewFeedbackBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewFeedbackBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewFeedbackBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewFeedbackBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewFeedbackBtn.FillColor = System.Drawing.Color.SlateGray;
            this.viewFeedbackBtn.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.viewFeedbackBtn.ForeColor = System.Drawing.Color.White;
            this.viewFeedbackBtn.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.viewFeedbackBtn.Location = new System.Drawing.Point(382, 486);
            this.viewFeedbackBtn.Name = "viewFeedbackBtn";
            this.viewFeedbackBtn.Size = new System.Drawing.Size(437, 46);
            this.viewFeedbackBtn.TabIndex = 4;
            this.viewFeedbackBtn.Text = "View";
            this.viewFeedbackBtn.Click += new System.EventHandler(this.viewFeedbackBtn_Click);
            // 
            // feedbackTable
            // 
            this.feedbackTable.AllowUserToAddRows = false;
            this.feedbackTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.feedbackTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Victor Mono", 12.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.feedbackTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.feedbackTable.ColumnHeadersHeight = 58;
            this.feedbackTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.feedbackTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feedbackID,
            this.docName,
            this.feedbackCont,
            this.feedbackDate});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Victor Mono", 12.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.feedbackTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.feedbackTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.feedbackTable.Location = new System.Drawing.Point(1, 1);
            this.feedbackTable.MultiSelect = false;
            this.feedbackTable.Name = "feedbackTable";
            this.feedbackTable.ReadOnly = true;
            this.feedbackTable.RowHeadersVisible = false;
            this.feedbackTable.RowHeadersWidth = 20;
            this.feedbackTable.Size = new System.Drawing.Size(818, 486);
            this.feedbackTable.TabIndex = 1;
            this.feedbackTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.feedbackTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.feedbackTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.feedbackTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.feedbackTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.feedbackTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.feedbackTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.feedbackTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.feedbackTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.feedbackTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.feedbackTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Victor Mono", 12.75F);
            this.feedbackTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.feedbackTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.feedbackTable.ThemeStyle.HeaderStyle.Height = 58;
            this.feedbackTable.ThemeStyle.ReadOnly = true;
            this.feedbackTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.feedbackTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.feedbackTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Victor Mono", 12.75F);
            this.feedbackTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.feedbackTable.ThemeStyle.RowsStyle.Height = 22;
            this.feedbackTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.feedbackTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // feedbackID
            // 
            this.feedbackID.FillWeight = 20F;
            this.feedbackID.HeaderText = "ID";
            this.feedbackID.Name = "feedbackID";
            this.feedbackID.ReadOnly = true;
            // 
            // docName
            // 
            this.docName.HeaderText = "To Doctor";
            this.docName.Name = "docName";
            this.docName.ReadOnly = true;
            // 
            // feedbackCont
            // 
            this.feedbackCont.HeaderText = "Content";
            this.feedbackCont.Name = "feedbackCont";
            this.feedbackCont.ReadOnly = true;
            this.feedbackCont.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.feedbackCont.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // feedbackDate
            // 
            this.feedbackDate.HeaderText = "Date";
            this.feedbackDate.Name = "feedbackDate";
            this.feedbackDate.ReadOnly = true;
            // 
            // ordersTab
            // 
            this.ordersTab.Controls.Add(this.viewRcptBtn);
            this.ordersTab.Controls.Add(this.ordersTable);
            this.ordersTab.Location = new System.Drawing.Point(154, 4);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.Padding = new System.Windows.Forms.Padding(3);
            this.ordersTab.Size = new System.Drawing.Size(818, 532);
            this.ordersTab.TabIndex = 3;
            this.ordersTab.Text = "Orders";
            this.ordersTab.UseVisualStyleBackColor = true;
            // 
            // viewRcptBtn
            // 
            this.viewRcptBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewRcptBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewRcptBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewRcptBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewRcptBtn.FillColor = System.Drawing.Color.SlateGray;
            this.viewRcptBtn.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.viewRcptBtn.ForeColor = System.Drawing.Color.White;
            this.viewRcptBtn.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.viewRcptBtn.Location = new System.Drawing.Point(0, 486);
            this.viewRcptBtn.Name = "viewRcptBtn";
            this.viewRcptBtn.Size = new System.Drawing.Size(818, 46);
            this.viewRcptBtn.TabIndex = 5;
            this.viewRcptBtn.Text = "View";
            this.viewRcptBtn.Click += new System.EventHandler(this.viewRcptBtn_Click);
            // 
            // ordersTable
            // 
            this.ordersTable.AllowUserToAddRows = false;
            this.ordersTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.ordersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Victor Mono", 12.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ordersTable.ColumnHeadersHeight = 58;
            this.ordersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ordersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rcptID,
            this.payment,
            this.date,
            this.state});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Victor Mono", 12.75F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersTable.DefaultCellStyle = dataGridViewCellStyle9;
            this.ordersTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.ordersTable.Location = new System.Drawing.Point(1, 1);
            this.ordersTable.MultiSelect = false;
            this.ordersTable.Name = "ordersTable";
            this.ordersTable.ReadOnly = true;
            this.ordersTable.RowHeadersVisible = false;
            this.ordersTable.RowHeadersWidth = 20;
            this.ordersTable.Size = new System.Drawing.Size(818, 486);
            this.ordersTable.TabIndex = 1;
            this.ordersTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.ordersTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.ordersTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ordersTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ordersTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ordersTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ordersTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ordersTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.ordersTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ordersTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ordersTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Victor Mono", 12.75F);
            this.ordersTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ordersTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ordersTable.ThemeStyle.HeaderStyle.Height = 58;
            this.ordersTable.ThemeStyle.ReadOnly = true;
            this.ordersTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ordersTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ordersTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Victor Mono", 12.75F);
            this.ordersTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ordersTable.ThemeStyle.RowsStyle.Height = 22;
            this.ordersTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.ordersTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ordersTable.SelectionChanged += new System.EventHandler(this.ordersTable_SelectionChanged);
            // 
            // rcptID
            // 
            this.rcptID.HeaderText = "ID";
            this.rcptID.Name = "rcptID";
            this.rcptID.ReadOnly = true;
            // 
            // payment
            // 
            this.payment.HeaderText = "Payment";
            this.payment.Name = "payment";
            this.payment.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // state
            // 
            this.state.HeaderText = "State";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 5000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // logoutBtn
            // 
            this.logoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutBtn.FillColor = System.Drawing.Color.SlateGray;
            this.logoutBtn.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.logoutBtn.Location = new System.Drawing.Point(0, 474);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(818, 46);
            this.logoutBtn.TabIndex = 40;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.Silver;
            this.guna2Separator2.FillThickness = 3;
            this.guna2Separator2.Location = new System.Drawing.Point(-2, 129);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(822, 18);
            this.guna2Separator2.TabIndex = 41;
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 536);
            this.Controls.Add(this.tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerDashboard";
            this.Text = "Customer Dashboard";
            this.tabs.ResumeLayout(false);
            this.dashboardTab.ResumeLayout(false);
            this.dashboardTab.PerformLayout();
            this.stockTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stockTable)).EndInit();
            this.feedbackTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feedbackTable)).EndInit();
            this.ordersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabs;
        private System.Windows.Forms.TabPage dashboardTab;
        private System.Windows.Forms.TabPage stockTab;
        private Guna.UI2.WinForms.Guna2Button buyMedBtn;
        private Guna.UI2.WinForms.Guna2Button viewMedBtn;
        private Guna.UI2.WinForms.Guna2DataGridView stockTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn medID;
        private System.Windows.Forms.DataGridViewTextBoxColumn genericName;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn expDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn supName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.TabPage feedbackTab;
        private Guna.UI2.WinForms.Guna2Button sendFeedbackBtn;
        private Guna.UI2.WinForms.Guna2Button viewFeedbackBtn;
        private Guna.UI2.WinForms.Guna2DataGridView feedbackTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedbackID;
        private System.Windows.Forms.DataGridViewTextBoxColumn docName;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedbackCont;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedbackDate;
        private System.Windows.Forms.Timer refreshTimer;
        private Guna.UI2.WinForms.Guna2TextBox searchTxtbx;
        private System.Windows.Forms.TabPage ordersTab;
        private Guna.UI2.WinForms.Guna2DataGridView ordersTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private Guna.UI2.WinForms.Guna2Button viewRcptBtn;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label ordersNumLbl;
        private System.Windows.Forms.Label spentLbl;
        private System.Windows.Forms.Label tit3;
        private System.Windows.Forms.Label tit2;
        private System.Windows.Forms.Label tit1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button changePassBtn;
        private Guna.UI2.WinForms.Guna2Button changeNameBtn;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
    }
}