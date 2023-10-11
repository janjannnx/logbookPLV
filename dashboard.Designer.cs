namespace logbookPLV
{
    partial class dashboard
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
            this.logbookButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logbookButton
            // 
            this.logbookButton.Location = new System.Drawing.Point(217, 80);
            this.logbookButton.Name = "logbookButton";
            this.logbookButton.Size = new System.Drawing.Size(172, 80);
            this.logbookButton.TabIndex = 0;
            this.logbookButton.Text = "Logbook";
            this.logbookButton.UseVisualStyleBackColor = true;
            this.logbookButton.Click += new System.EventHandler(this.logbookButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(217, 252);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(172, 80);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.Location = new System.Drawing.Point(217, 166);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(172, 80);
            this.reportsButton.TabIndex = 3;
            this.reportsButton.Text = "Reports";
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(656, 444);
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.logbookButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logbookButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button reportsButton;
    }
}