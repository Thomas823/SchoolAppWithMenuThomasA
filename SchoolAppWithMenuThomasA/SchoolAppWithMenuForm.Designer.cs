namespace SchoolAppWithMenuThomasA
{
    partial class frmSchoolAppWithMenu
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
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.lblSchoolTeamName = new System.Windows.Forms.Label();
            this.mnuFileMenu = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Font = new System.Drawing.Font("Brush Script Std", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolName.Location = new System.Drawing.Point(82, 57);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(356, 74);
            this.lblSchoolName.TabIndex = 0;
            this.lblSchoolName.Text = "Immaculata";
            // 
            // lblSchoolTeamName
            // 
            this.lblSchoolTeamName.AutoSize = true;
            this.lblSchoolTeamName.Font = new System.Drawing.Font("Birch Std", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolTeamName.Location = new System.Drawing.Point(200, 131);
            this.lblSchoolTeamName.Name = "lblSchoolTeamName";
            this.lblSchoolTeamName.Size = new System.Drawing.Size(93, 56);
            this.lblSchoolTeamName.TabIndex = 1;
            this.lblSchoolTeamName.Text = "Saints";
            // 
            // mnuFileMenu
            // 
            this.mnuFileMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnuFileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuFileMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuFileMenu.Name = "mnuFileMenu";
            this.mnuFileMenu.Size = new System.Drawing.Size(513, 24);
            this.mnuFileMenu.TabIndex = 2;
            // 
            // mniFile
            // 
            this.mniFile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // frmSchoolAppWithMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(513, 261);
            this.Controls.Add(this.lblSchoolTeamName);
            this.Controls.Add(this.lblSchoolName);
            this.Controls.Add(this.mnuFileMenu);
            this.MainMenuStrip = this.mnuFileMenu;
            this.Name = "frmSchoolAppWithMenu";
            this.Text = "School App";
            this.mnuFileMenu.ResumeLayout(false);
            this.mnuFileMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.Label lblSchoolTeamName;
        private System.Windows.Forms.MenuStrip mnuFileMenu;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

