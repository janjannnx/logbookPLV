namespace logbookPLV
{
    partial class logbook
    {
        private System.ComponentModel.IContainer components = null;
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
            System.Windows.Forms.Label controlNo_Label;
            System.Windows.Forms.Label courseLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label middleInitialLabel;
            System.Windows.Forms.Label student_idLabel;
            System.Windows.Forms.Label transactionLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label search;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logbook));
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOGBOOKPLVDataSet = new logbookPLV.LOGBOOKPLVDataSet();
            this.addTransactionTableAdapter = new logbookPLV.LOGBOOKPLVDataSetTableAdapters.addTransactionTableAdapter();
            this.txtcontrolNo = new System.Windows.Forms.TextBox();
            this.txtcourse = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.txtfirstName = new System.Windows.Forms.TextBox();
            this.txtlastName = new System.Windows.Forms.TextBox();
            this.txtmiddleInitial = new System.Windows.Forms.TextBox();
            this.txtstudentId = new System.Windows.Forms.TextBox();
            this.txttransaction = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.takePhoto = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleInitial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewButton = new System.Windows.Forms.Button();
            controlNo_Label = new System.Windows.Forms.Label();
            courseLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            middleInitialLabel = new System.Windows.Forms.Label();
            student_idLabel = new System.Windows.Forms.Label();
            transactionLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGBOOKPLVDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlNo_Label
            // 
            controlNo_Label.AutoSize = true;
            controlNo_Label.Location = new System.Drawing.Point(20, 73);
            controlNo_Label.Name = "controlNo_Label";
            controlNo_Label.Size = new System.Drawing.Size(79, 16);
            controlNo_Label.TabIndex = 58;
            controlNo_Label.Text = "Control No. :";
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.Location = new System.Drawing.Point(342, 42);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new System.Drawing.Size(53, 16);
            courseLabel.TabIndex = 61;
            courseLabel.Text = "Course:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(20, 46);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(39, 16);
            dateLabel.TabIndex = 65;
            dateLabel.Text = "Date:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(20, 17);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(75, 16);
            firstNameLabel.TabIndex = 67;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(487, 17);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(75, 16);
            lastNameLabel.TabIndex = 70;
            lastNameLabel.Text = "Last Name:";
            // 
            // middleInitialLabel
            // 
            middleInitialLabel.AutoSize = true;
            middleInitialLabel.Location = new System.Drawing.Point(320, 17);
            middleInitialLabel.Name = "middleInitialLabel";
            middleInitialLabel.Size = new System.Drawing.Size(84, 16);
            middleInitialLabel.TabIndex = 71;
            middleInitialLabel.Text = "Middle Initial:";
            // 
            // student_idLabel
            // 
            student_idLabel.AutoSize = true;
            student_idLabel.Location = new System.Drawing.Point(342, 70);
            student_idLabel.Name = "student_idLabel";
            student_idLabel.Size = new System.Drawing.Size(69, 16);
            student_idLabel.TabIndex = 72;
            student_idLabel.Text = "Student Id:";
            // 
            // transactionLabel
            // 
            transactionLabel.AutoSize = true;
            transactionLabel.Location = new System.Drawing.Point(19, 98);
            transactionLabel.Name = "transactionLabel";
            transactionLabel.Size = new System.Drawing.Size(81, 16);
            transactionLabel.TabIndex = 73;
            transactionLabel.Text = "Transaction:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(342, 101);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(39, 16);
            yearLabel.TabIndex = 74;
            yearLabel.Text = "Year:";
            // 
            // search
            // 
            search.AutoSize = true;
            search.Location = new System.Drawing.Point(14, 172);
            search.Name = "search";
            search.Size = new System.Drawing.Size(53, 16);
            search.TabIndex = 70;
            search.Text = "Search:";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1766, 479);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 57);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(1766, 552);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(95, 57);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addTransactionBindingSource
            // 
            this.addTransactionBindingSource.DataMember = "addTransaction";
            this.addTransactionBindingSource.DataSource = this.lOGBOOKPLVDataSet;
            // 
            // lOGBOOKPLVDataSet
            // 
            this.lOGBOOKPLVDataSet.DataSetName = "LOGBOOKPLVDataSet";
            this.lOGBOOKPLVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addTransactionTableAdapter
            // 
            this.addTransactionTableAdapter.ClearBeforeFill = true;
            // 
            // txtcontrolNo
            // 
            this.txtcontrolNo.Location = new System.Drawing.Point(110, 70);
            this.txtcontrolNo.Name = "txtcontrolNo";
            this.txtcontrolNo.Size = new System.Drawing.Size(200, 22);
            this.txtcontrolNo.TabIndex = 5;
            // 
            // txtcourse
            // 
            this.txtcourse.Location = new System.Drawing.Point(432, 39);
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.Size = new System.Drawing.Size(200, 22);
            this.txtcourse.TabIndex = 4;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(110, 42);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(200, 22);
            this.txtdate.TabIndex = 3;
            // 
            // txtfirstName
            // 
            this.txtfirstName.Location = new System.Drawing.Point(110, 14);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(200, 22);
            this.txtfirstName.TabIndex = 0;
            this.txtfirstName.TextChanged += new System.EventHandler(this.txtfirstName_TextChanged);
            // 
            // txtlastName
            // 
            this.txtlastName.Location = new System.Drawing.Point(568, 14);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(200, 22);
            this.txtlastName.TabIndex = 2;
            // 
            // txtmiddleInitial
            // 
            this.txtmiddleInitial.Location = new System.Drawing.Point(410, 14);
            this.txtmiddleInitial.Name = "txtmiddleInitial";
            this.txtmiddleInitial.Size = new System.Drawing.Size(49, 22);
            this.txtmiddleInitial.TabIndex = 1;
            // 
            // txtstudentId
            // 
            this.txtstudentId.Location = new System.Drawing.Point(432, 67);
            this.txtstudentId.Name = "txtstudentId";
            this.txtstudentId.Size = new System.Drawing.Size(200, 22);
            this.txtstudentId.TabIndex = 6;
            // 
            // txttransaction
            // 
            this.txttransaction.Location = new System.Drawing.Point(109, 95);
            this.txttransaction.Name = "txttransaction";
            this.txttransaction.Size = new System.Drawing.Size(200, 22);
            this.txttransaction.TabIndex = 7;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(432, 98);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(78, 22);
            this.txtyear.TabIndex = 8;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(798, 61);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(95, 57);
            this.Add.TabIndex = 9;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(70, 166);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(341, 22);
            this.txtsearch.TabIndex = 12;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearch_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.takePhoto);
            this.panel1.Controls.Add(this.uploadButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 136);
            this.panel1.TabIndex = 75;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // takePhoto
            // 
            this.takePhoto.Location = new System.Drawing.Point(652, 86);
            this.takePhoto.Name = "takePhoto";
            this.takePhoto.Size = new System.Drawing.Size(104, 36);
            this.takePhoto.TabIndex = 3;
            this.takePhoto.Text = "Take Photo";
            this.takePhoto.UseVisualStyleBackColor = true;
            this.takePhoto.Click += new System.EventHandler(this.takePhoto_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(652, 41);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(104, 36);
            this.uploadButton.TabIndex = 1;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = global::logbookPLV.Properties.Resources.plv_logo_colored;
            this.pictureBox1.Image = global::logbookPLV.Properties.Resources.PLV_BG;
            this.pictureBox1.InitialImage = global::logbookPLV.Properties.Resources.plv_logo_colored;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1262, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1280, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.student_id,
            this.firstName,
            this.middleInitial,
            this.lastName,
            this.course,
            this.year,
            this.reason,
            this.controlNo,
            this.date,
            this.imageData});
            this.dataGridView1.DataSource = this.addTransactionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 215);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1715, 762);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // student_id
            // 
            this.student_id.DataPropertyName = "student_id";
            this.student_id.HeaderText = "Student ID";
            this.student_id.MinimumWidth = 6;
            this.student_id.Name = "student_id";
            this.student_id.ReadOnly = true;
            this.student_id.Width = 125;
            // 
            // firstName
            // 
            this.firstName.DataPropertyName = "firstName";
            this.firstName.HeaderText = "First Name";
            this.firstName.MinimumWidth = 6;
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            this.firstName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.firstName.Width = 150;
            // 
            // middleInitial
            // 
            this.middleInitial.DataPropertyName = "middleInitial";
            this.middleInitial.HeaderText = "M.I.";
            this.middleInitial.MinimumWidth = 6;
            this.middleInitial.Name = "middleInitial";
            this.middleInitial.ReadOnly = true;
            this.middleInitial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.middleInitial.Width = 80;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "lastName";
            this.lastName.HeaderText = "Last Name";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            this.lastName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lastName.Width = 150;
            // 
            // course
            // 
            this.course.DataPropertyName = "course";
            this.course.HeaderText = "Course";
            this.course.MinimumWidth = 6;
            this.course.Name = "course";
            this.course.ReadOnly = true;
            this.course.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.course.Width = 200;
            // 
            // year
            // 
            this.year.DataPropertyName = "year";
            this.year.HeaderText = "Year";
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            this.year.ReadOnly = true;
            this.year.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.year.Width = 80;
            // 
            // reason
            // 
            this.reason.DataPropertyName = "reason";
            this.reason.HeaderText = "Transaction";
            this.reason.MinimumWidth = 6;
            this.reason.Name = "reason";
            this.reason.ReadOnly = true;
            this.reason.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reason.Width = 200;
            // 
            // controlNo
            // 
            this.controlNo.DataPropertyName = "controlNo";
            this.controlNo.HeaderText = "Control No.";
            this.controlNo.MinimumWidth = 6;
            this.controlNo.Name = "controlNo";
            this.controlNo.ReadOnly = true;
            this.controlNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.controlNo.Width = 150;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.date.Width = 150;
            // 
            // imageData
            // 
            this.imageData.DataPropertyName = "imageData";
            this.imageData.HeaderText = "Signature";
            this.imageData.MinimumWidth = 6;
            this.imageData.Name = "imageData";
            this.imageData.ReadOnly = true;
            this.imageData.Visible = false;
            this.imageData.Width = 125;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(1766, 622);
            this.viewButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(95, 57);
            this.viewButton.TabIndex = 76;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // logbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(controlNo_Label);
            this.Controls.Add(this.txtcontrolNo);
            this.Controls.Add(courseLabel);
            this.Controls.Add(this.txtcourse);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.txtfirstName);
            this.Controls.Add(search);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.txtlastName);
            this.Controls.Add(middleInitialLabel);
            this.Controls.Add(this.txtmiddleInitial);
            this.Controls.Add(student_idLabel);
            this.Controls.Add(this.txtstudentId);
            this.Controls.Add(transactionLabel);
            this.Controls.Add(this.txttransaction);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "logbook";
            this.Text = "Logbook";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.logbook_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.addTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGBOOKPLVDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private LOGBOOKPLVDataSet lOGBOOKPLVDataSet;
        private System.Windows.Forms.BindingSource addTransactionBindingSource;
        private LOGBOOKPLVDataSetTableAdapters.addTransactionTableAdapter addTransactionTableAdapter;
        private System.Windows.Forms.TextBox txtcontrolNo;
        private System.Windows.Forms.TextBox txtcourse;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.TextBox txtfirstName;
        private System.Windows.Forms.TextBox txtlastName;
        private System.Windows.Forms.TextBox txtmiddleInitial;
        private System.Windows.Forms.TextBox txtstudentId;
        private System.Windows.Forms.TextBox txttransaction;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleInitial;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn course;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageData;
        private System.Windows.Forms.Button takePhoto;
    }
}