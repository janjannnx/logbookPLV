namespace logbookPLV
{
    partial class Report
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.allTransactionCheckBox = new System.Windows.Forms.CheckBox();
            this.allDateCheckBox = new System.Windows.Forms.CheckBox();
            this.allCourseCheckBox = new System.Windows.Forms.CheckBox();
            this.extractButton = new System.Windows.Forms.Button();
            this.addTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOGBOOKPLVDataSet1 = new logbookPLV.LOGBOOKPLVDataSet1();
            this.transactionlbl = new System.Windows.Forms.Label();
            this.yearlbl = new System.Windows.Forms.Label();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.courselbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleInitial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addTransactionTableAdapter = new logbookPLV.LOGBOOKPLVDataSet1TableAdapters.addTransactionTableAdapter();
            this.numberOfTransaction = new System.Windows.Forms.Label();
            this.dateComboBox = new System.Windows.Forms.ComboBox();
            this.transactionComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGBOOKPLVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.transactionComboBox);
            this.panel1.Controls.Add(this.dateComboBox);
            this.panel1.Controls.Add(this.allTransactionCheckBox);
            this.panel1.Controls.Add(this.allDateCheckBox);
            this.panel1.Controls.Add(this.allCourseCheckBox);
            this.panel1.Controls.Add(this.extractButton);
            this.panel1.Controls.Add(this.transactionlbl);
            this.panel1.Controls.Add(this.yearlbl);
            this.panel1.Controls.Add(this.courseComboBox);
            this.panel1.Controls.Add(this.courselbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 351);
            this.panel1.TabIndex = 0;
            // 
            // allTransactionCheckBox
            // 
            this.allTransactionCheckBox.AutoSize = true;
            this.allTransactionCheckBox.Location = new System.Drawing.Point(106, 186);
            this.allTransactionCheckBox.Name = "allTransactionCheckBox";
            this.allTransactionCheckBox.Size = new System.Drawing.Size(44, 20);
            this.allTransactionCheckBox.TabIndex = 14;
            this.allTransactionCheckBox.Text = "All";
            this.allTransactionCheckBox.UseVisualStyleBackColor = true;
            this.allTransactionCheckBox.CheckedChanged += new System.EventHandler(this.allTransactionCheckBox_CheckedChanged);
            // 
            // allDateCheckBox
            // 
            this.allDateCheckBox.AutoSize = true;
            this.allDateCheckBox.Location = new System.Drawing.Point(64, 107);
            this.allDateCheckBox.Name = "allDateCheckBox";
            this.allDateCheckBox.Size = new System.Drawing.Size(44, 20);
            this.allDateCheckBox.TabIndex = 13;
            this.allDateCheckBox.Text = "All";
            this.allDateCheckBox.UseVisualStyleBackColor = true;
            this.allDateCheckBox.CheckedChanged += new System.EventHandler(this.allDateCheckBox_CheckedChanged);
            // 
            // allCourseCheckBox
            // 
            this.allCourseCheckBox.AutoSize = true;
            this.allCourseCheckBox.Location = new System.Drawing.Point(78, 21);
            this.allCourseCheckBox.Name = "allCourseCheckBox";
            this.allCourseCheckBox.Size = new System.Drawing.Size(44, 20);
            this.allCourseCheckBox.TabIndex = 12;
            this.allCourseCheckBox.Text = "All";
            this.allCourseCheckBox.UseVisualStyleBackColor = true;
            this.allCourseCheckBox.CheckedChanged += new System.EventHandler(this.allCourseCheckBox_CheckedChanged);
            // 
            // extractButton
            // 
            this.extractButton.Location = new System.Drawing.Point(116, 282);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(125, 55);
            this.extractButton.TabIndex = 11;
            this.extractButton.Text = "Extract";
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // addTransactionBindingSource
            // 
            this.addTransactionBindingSource.DataMember = "addTransaction";
            this.addTransactionBindingSource.DataSource = this.lOGBOOKPLVDataSet1;
            // 
            // lOGBOOKPLVDataSet1
            // 
            this.lOGBOOKPLVDataSet1.DataSetName = "LOGBOOKPLVDataSet1";
            this.lOGBOOKPLVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionlbl
            // 
            this.transactionlbl.AutoSize = true;
            this.transactionlbl.Location = new System.Drawing.Point(19, 187);
            this.transactionlbl.Name = "transactionlbl";
            this.transactionlbl.Size = new System.Drawing.Size(81, 16);
            this.transactionlbl.TabIndex = 8;
            this.transactionlbl.Text = "Transaction:";
            this.transactionlbl.Click += new System.EventHandler(this.transactionlbl_Click);
            // 
            // yearlbl
            // 
            this.yearlbl.AutoSize = true;
            this.yearlbl.Location = new System.Drawing.Point(19, 108);
            this.yearlbl.Name = "yearlbl";
            this.yearlbl.Size = new System.Drawing.Size(39, 16);
            this.yearlbl.TabIndex = 3;
            this.yearlbl.Text = "Year:";
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(22, 56);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(333, 24);
            this.courseComboBox.TabIndex = 1;
            this.courseComboBox.SelectedIndexChanged += new System.EventHandler(this.courseComboBox_SelectedIndexChanged_1);
            // 
            // courselbl
            // 
            this.courselbl.AutoSize = true;
            this.courselbl.Location = new System.Drawing.Point(19, 22);
            this.courselbl.Name = "courselbl";
            this.courselbl.Size = new System.Drawing.Size(53, 16);
            this.courselbl.TabIndex = 0;
            this.courselbl.Text = "Course:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentId,
            this.firstName,
            this.middleInitial,
            this.lastName,
            this.course,
            this.year,
            this.reason,
            this.controlNo,
            this.date});
            this.dataGridView1.DataSource = this.addTransactionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(409, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1502, 946);
            this.dataGridView1.TabIndex = 1;
            // 
            // studentId
            // 
            this.studentId.DataPropertyName = "student_Id";
            this.studentId.HeaderText = "Student ID";
            this.studentId.MinimumWidth = 6;
            this.studentId.Name = "studentId";
            this.studentId.Width = 150;
            // 
            // firstName
            // 
            this.firstName.DataPropertyName = "firstName";
            this.firstName.HeaderText = "First Name";
            this.firstName.MinimumWidth = 6;
            this.firstName.Name = "firstName";
            this.firstName.Width = 150;
            // 
            // middleInitial
            // 
            this.middleInitial.DataPropertyName = "middleInitial";
            this.middleInitial.HeaderText = "Middle Initial";
            this.middleInitial.MinimumWidth = 6;
            this.middleInitial.Name = "middleInitial";
            this.middleInitial.Width = 125;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "lastName";
            this.lastName.HeaderText = "Last Name";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.Width = 150;
            // 
            // course
            // 
            this.course.DataPropertyName = "course";
            this.course.HeaderText = "Course";
            this.course.MinimumWidth = 6;
            this.course.Name = "course";
            this.course.Width = 250;
            // 
            // year
            // 
            this.year.DataPropertyName = "year";
            this.year.HeaderText = "Year";
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            this.year.Width = 150;
            // 
            // reason
            // 
            this.reason.DataPropertyName = "reason";
            this.reason.HeaderText = "Transaction";
            this.reason.MinimumWidth = 6;
            this.reason.Name = "reason";
            this.reason.Width = 200;
            // 
            // controlNo
            // 
            this.controlNo.DataPropertyName = "controlNo";
            this.controlNo.HeaderText = "Contro lNo";
            this.controlNo.MinimumWidth = 6;
            this.controlNo.Name = "controlNo";
            this.controlNo.Width = 200;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // addTransactionTableAdapter
            // 
            this.addTransactionTableAdapter.ClearBeforeFill = true;
            // 
            // numberOfTransaction
            // 
            this.numberOfTransaction.AutoSize = true;
            this.numberOfTransaction.Location = new System.Drawing.Point(12, 388);
            this.numberOfTransaction.Name = "numberOfTransaction";
            this.numberOfTransaction.Size = new System.Drawing.Size(153, 16);
            this.numberOfTransaction.TabIndex = 2;
            this.numberOfTransaction.Text = "Number of Transactions:";
            // 
            // dateComboBox
            // 
            this.dateComboBox.FormattingEnabled = true;
            this.dateComboBox.Location = new System.Drawing.Point(22, 143);
            this.dateComboBox.Name = "dateComboBox";
            this.dateComboBox.Size = new System.Drawing.Size(135, 24);
            this.dateComboBox.TabIndex = 15;
            this.dateComboBox.SelectedIndexChanged += new System.EventHandler(this.dateComboBox_SelectedIndexChanged);
            // 
            // transactionComboBox
            // 
            this.transactionComboBox.FormattingEnabled = true;
            this.transactionComboBox.Location = new System.Drawing.Point(22, 235);
            this.transactionComboBox.Name = "transactionComboBox";
            this.transactionComboBox.Size = new System.Drawing.Size(333, 24);
            this.transactionComboBox.TabIndex = 16;
            this.transactionComboBox.SelectedIndexChanged += new System.EventHandler(this.transactionComboBox_SelectedIndexChanged);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.numberOfTransaction);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Name = "Report";
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGBOOKPLVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LOGBOOKPLVDataSet1 lOGBOOKPLVDataSet1;
        private System.Windows.Forms.BindingSource addTransactionBindingSource;
        private LOGBOOKPLVDataSet1TableAdapters.addTransactionTableAdapter addTransactionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleInitial;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn course;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.Label courselbl;
        private System.Windows.Forms.Label transactionlbl;
        private System.Windows.Forms.Label yearlbl;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.Label numberOfTransaction;
        private System.Windows.Forms.CheckBox allTransactionCheckBox;
        private System.Windows.Forms.CheckBox allDateCheckBox;
        private System.Windows.Forms.CheckBox allCourseCheckBox;
        private System.Windows.Forms.ComboBox dateComboBox;
        private System.Windows.Forms.ComboBox transactionComboBox;
    }
}