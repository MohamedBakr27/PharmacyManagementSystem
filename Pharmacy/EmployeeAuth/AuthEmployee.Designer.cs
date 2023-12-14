namespace Pharmacy.EmployeeAuth
{
    partial class AuthEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthEmployee));
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.pageTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.passLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.passTxtbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.usrnameLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.usrnameTxtbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BorderRadius = 20;
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.Font = new System.Drawing.Font("Victor Mono", 15.75F);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(413, 309);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(180, 45);
            this.loginBtn.TabIndex = 106;
            this.loginBtn.TabStop = false;
            this.loginBtn.Text = "Login";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pageTitle
            // 
            this.pageTitle.BackColor = System.Drawing.Color.Transparent;
            this.pageTitle.Font = new System.Drawing.Font("Victor Mono SemiBold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pageTitle.IsSelectionEnabled = false;
            this.pageTitle.Location = new System.Drawing.Point(452, 124);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(98, 61);
            this.pageTitle.TabIndex = 112;
            this.pageTitle.TabStop = false;
            this.pageTitle.Text = "Login";
            // 
            // passLbl
            // 
            this.passLbl.BackColor = System.Drawing.Color.Transparent;
            this.passLbl.Font = new System.Drawing.Font("Victor Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLbl.IsSelectionEnabled = false;
            this.passLbl.Location = new System.Drawing.Point(285, 250);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(83, 31);
            this.passLbl.TabIndex = 113;
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
            this.passTxtbx.Location = new System.Drawing.Point(373, 244);
            this.passTxtbx.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.passTxtbx.Name = "passTxtbx";
            this.passTxtbx.PasswordChar = '●';
            this.passTxtbx.PlaceholderText = "";
            this.passTxtbx.SelectedText = "";
            this.passTxtbx.Size = new System.Drawing.Size(269, 37);
            this.passTxtbx.TabIndex = 104;
            this.passTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passTxtbx.UseSystemPasswordChar = true;
            // 
            // usrnameLbl
            // 
            this.usrnameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usrnameLbl.Font = new System.Drawing.Font("Victor Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrnameLbl.IsSelectionEnabled = false;
            this.usrnameLbl.Location = new System.Drawing.Point(285, 195);
            this.usrnameLbl.Name = "usrnameLbl";
            this.usrnameLbl.Size = new System.Drawing.Size(83, 31);
            this.usrnameLbl.TabIndex = 114;
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
            this.usrnameTxtbx.Location = new System.Drawing.Point(373, 189);
            this.usrnameTxtbx.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.usrnameTxtbx.Name = "usrnameTxtbx";
            this.usrnameTxtbx.PasswordChar = '\0';
            this.usrnameTxtbx.PlaceholderText = "";
            this.usrnameTxtbx.SelectedText = "";
            this.usrnameTxtbx.Size = new System.Drawing.Size(269, 37);
            this.usrnameTxtbx.TabIndex = 103;
            this.usrnameTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AuthEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 536);
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.passTxtbx);
            this.Controls.Add(this.usrnameLbl);
            this.Controls.Add(this.usrnameTxtbx);
            this.Controls.Add(this.loginBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthEmployee";
            this.Text = "Employee - Authentication - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel pageTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel passLbl;
        private Guna.UI2.WinForms.Guna2TextBox passTxtbx;
        private Guna.UI2.WinForms.Guna2HtmlLabel usrnameLbl;
        private Guna.UI2.WinForms.Guna2TextBox usrnameTxtbx;
    }
}