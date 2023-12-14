namespace Pharmacy.EmployeeAuth
{
    partial class ViewReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReport));
            this.dateTitle = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.contentLbl = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // dateTitle
            // 
            this.dateTitle.AutoSize = true;
            this.dateTitle.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.dateTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateTitle.Location = new System.Drawing.Point(93, 9);
            this.dateTitle.Name = "dateTitle";
            this.dateTitle.Size = new System.Drawing.Size(75, 44);
            this.dateTitle.TabIndex = 9;
            this.dateTitle.Text = "Name";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.dateLbl.Location = new System.Drawing.Point(12, 9);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(75, 44);
            this.dateLbl.TabIndex = 8;
            this.dateLbl.Text = "Date";
            // 
            // contentLbl
            // 
            this.contentLbl.Font = new System.Drawing.Font("Victor Mono", 18F);
            this.contentLbl.Location = new System.Drawing.Point(12, 56);
            this.contentLbl.Name = "contentLbl";
            this.contentLbl.ReadOnly = true;
            this.contentLbl.Size = new System.Drawing.Size(427, 246);
            this.contentLbl.TabIndex = 11;
            this.contentLbl.Text = "";
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 314);
            this.Controls.Add(this.contentLbl);
            this.Controls.Add(this.dateTitle);
            this.Controls.Add(this.dateLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewReport";
            this.Text = "View Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateTitle;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.RichTextBox contentLbl;
    }
}