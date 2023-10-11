namespace logbookPLV
{
    partial class transaction
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
            System.Windows.Forms.Label controlNo_Label;
            System.Windows.Forms.Label courseLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label middleInitialLabel;
            System.Windows.Forms.Label student_idLabel;
            System.Windows.Forms.Label transactionLabel;
            System.Windows.Forms.Label yearLabel;
            this.txtcontrolNo = new System.Windows.Forms.TextBox();
            this.txtcourse = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.txtfirstName = new System.Windows.Forms.TextBox();
            this.txtlastName = new System.Windows.Forms.TextBox();
            this.txtmiddleInitial = new System.Windows.Forms.TextBox();
            this.txtstudentId = new System.Windows.Forms.TextBox();
            this.txttransaction = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            controlNo_Label = new System.Windows.Forms.Label();
            courseLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            middleInitialLabel = new System.Windows.Forms.Label();
            student_idLabel = new System.Windows.Forms.Label();
            transactionLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlNo_Label
            // 
            controlNo_Label.AutoSize = true;
            controlNo_Label.Location = new System.Drawing.Point(25, 101);
            controlNo_Label.Name = "controlNo_Label";
            controlNo_Label.Size = new System.Drawing.Size(79, 16);
            controlNo_Label.TabIndex = 39;
            controlNo_Label.Text = "Control No. :";
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.Location = new System.Drawing.Point(347, 70);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new System.Drawing.Size(53, 16);
            courseLabel.TabIndex = 42;
            courseLabel.Text = "Course:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(25, 74);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(39, 16);
            dateLabel.TabIndex = 46;
            dateLabel.Text = "Date:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(25, 45);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(75, 16);
            firstNameLabel.TabIndex = 48;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(492, 45);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(75, 16);
            lastNameLabel.TabIndex = 51;
            lastNameLabel.Text = "Last Name:";
            // 
            // middleInitialLabel
            // 
            middleInitialLabel.AutoSize = true;
            middleInitialLabel.Location = new System.Drawing.Point(325, 45);
            middleInitialLabel.Name = "middleInitialLabel";
            middleInitialLabel.Size = new System.Drawing.Size(84, 16);
            middleInitialLabel.TabIndex = 52;
            middleInitialLabel.Text = "Middle Initial:";
            // 
            // student_idLabel
            // 
            student_idLabel.AutoSize = true;
            student_idLabel.Location = new System.Drawing.Point(347, 98);
            student_idLabel.Name = "student_idLabel";
            student_idLabel.Size = new System.Drawing.Size(69, 16);
            student_idLabel.TabIndex = 53;
            student_idLabel.Text = "Student Id:";
            // 
            // transactionLabel
            // 
            transactionLabel.AutoSize = true;
            transactionLabel.Location = new System.Drawing.Point(24, 126);
            transactionLabel.Name = "transactionLabel";
            transactionLabel.Size = new System.Drawing.Size(81, 16);
            transactionLabel.TabIndex = 54;
            transactionLabel.Text = "Transaction:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(347, 129);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(39, 16);
            yearLabel.TabIndex = 55;
            yearLabel.Text = "Year:";
            // 
            // txtcontrolNo
            // 
            this.txtcontrolNo.Location = new System.Drawing.Point(115, 98);
            this.txtcontrolNo.Name = "txtcontrolNo";
            this.txtcontrolNo.Size = new System.Drawing.Size(200, 22);
            this.txtcontrolNo.TabIndex = 45;
            // 
            // txtcourse
            // 
            this.txtcourse.Location = new System.Drawing.Point(437, 67);
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.Size = new System.Drawing.Size(200, 22);
            this.txtcourse.TabIndex = 44;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(115, 70);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(200, 22);
            this.txtdate.TabIndex = 43;
            // 
            // txtfirstName
            // 
            this.txtfirstName.Location = new System.Drawing.Point(115, 42);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(200, 22);
            this.txtfirstName.TabIndex = 38;
            this.txtfirstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // txtlastName
            // 
            this.txtlastName.Location = new System.Drawing.Point(582, 42);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(200, 22);
            this.txtlastName.TabIndex = 41;
            // 
            // txtmiddleInitial
            // 
            this.txtmiddleInitial.Location = new System.Drawing.Point(415, 42);
            this.txtmiddleInitial.Name = "txtmiddleInitial";
            this.txtmiddleInitial.Size = new System.Drawing.Size(49, 22);
            this.txtmiddleInitial.TabIndex = 40;
            // 
            // txtstudentId
            // 
            this.txtstudentId.Location = new System.Drawing.Point(437, 95);
            this.txtstudentId.Name = "txtstudentId";
            this.txtstudentId.Size = new System.Drawing.Size(200, 22);
            this.txtstudentId.TabIndex = 47;
            // 
            // txttransaction
            // 
            this.txttransaction.Location = new System.Drawing.Point(114, 123);
            this.txttransaction.Name = "txttransaction";
            this.txttransaction.Size = new System.Drawing.Size(200, 22);
            this.txttransaction.TabIndex = 49;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(437, 126);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(78, 22);
            this.txtyear.TabIndex = 50;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(562, 178);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 37;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(674, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 213);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(controlNo_Label);
            this.Controls.Add(this.txtcontrolNo);
            this.Controls.Add(courseLabel);
            this.Controls.Add(this.txtcourse);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.txtfirstName);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.txtlastName);
            this.Controls.Add(middleInitialLabel);
            this.Controls.Add(this.txtmiddleInitial);
            this.Controls.Add(student_idLabel);
            this.Controls.Add(this.txtstudentId);
            this.Controls.Add(transactionLabel);
            this.Controls.Add(this.txttransaction);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.save);
            this.Name = "transaction";
            this.Text = "transaction";
            this.Load += new System.EventHandler(this.transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtcontrolNo;
        private System.Windows.Forms.TextBox txtcourse;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.TextBox txtfirstName;
        private System.Windows.Forms.TextBox txtlastName;
        private System.Windows.Forms.TextBox txtmiddleInitial;
        private System.Windows.Forms.TextBox txtstudentId;
        private System.Windows.Forms.TextBox txttransaction;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}