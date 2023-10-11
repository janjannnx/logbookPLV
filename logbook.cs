using logbookPLV.LOGBOOKPLVDataSetTableAdapters;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;



namespace logbookPLV
{
    public partial class logbook : Form
    {
        private OpenFileDialog openFileDialog1;
        public logbook()
        {
            InitializeComponent();
            this.MaximizeBox = true;
        }
        public Bitmap CapturedImage
        {
            get { return pictureBox2.Image as Bitmap; }
            set { pictureBox2.Image = value; }
        }
        private void logbook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void logbook_Load_1(object sender, EventArgs e)
        {
            this.addTransactionTableAdapter.Fill(this.lOGBOOKPLVDataSet.addTransaction);
            disp_data();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Select an Image";
        }
        private void Logbook_Load(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
        }
        public void disp_data()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HEO3J7VO\SQLEXPRESS;Initial Catalog=LOGBOOKPLV;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from addTransaction";

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HEO3J7VO\SQLEXPRESS;Initial Catalog=LOGBOOKPLV;Integrated Security=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO addTransaction(student_Id, firstName, middleInitial, lastName, course, year, reason, controlNo, date, imageData) VALUES (@studentId, @firstName, @middleInitial, @lastName, @course, @year, @reason, @controlNo, @date, @imageData)", con))
                    {
                        cmd.Parameters.AddWithValue("@studentId", txtstudentId.Text);
                        cmd.Parameters.AddWithValue("@firstName", txtfirstName.Text);
                        cmd.Parameters.AddWithValue("@middleInitial", txtmiddleInitial.Text);
                        cmd.Parameters.AddWithValue("@lastName", txtlastName.Text);
                        cmd.Parameters.AddWithValue("@course", txtcourse.Text);
                        cmd.Parameters.AddWithValue("@year", txtyear.Text);
                        cmd.Parameters.AddWithValue("@reason", txttransaction.Text);
                        cmd.Parameters.AddWithValue("@controlNo", txtcontrolNo.Text);
                        cmd.Parameters.AddWithValue("@date", txtdate.Text);

                        Bitmap capturedImage = CapturedImage;

                        if (capturedImage != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                capturedImage.Save(ms, ImageFormat.Jpeg);
                                byte[] imageBytes = ms.ToArray();
                                SqlParameter paramImageData = new SqlParameter("@imageData", SqlDbType.VarBinary);
                                paramImageData.Value = imageBytes;
                                cmd.Parameters.Add(paramImageData);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No image captured.");
                            return;
                        }

                        int i = cmd.ExecuteNonQuery();
                        if (i != 0)
                        {
                            MessageBox.Show("Transaction saved.");
                            ClearInputFields();
                            disp_data();
                        }
                        else
                        {
                            MessageBox.Show("Error saving transaction. Please try again.");
                        }
                    }
                }
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HEO3J7VO\SQLEXPRESS;Initial Catalog=LOGBOOKPLV;Integrated Security=True"))
                        {
                            con.Open();
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM addTransaction WHERE id = @id", con))
                            {
                                cmd.Parameters.AddWithValue("@id", id);

                                int i = cmd.ExecuteNonQuery();

                                if (i > 0)
                                {
                                    MessageBox.Show("Record deleted successfully.");
                                    disp_data();
                                }
                                else
                                {
                                    MessageBox.Show("No records were deleted. Please check if the record exists.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void ClearInputFields()
        {
            txtstudentId.Clear();
            txtfirstName.Clear();
            txtmiddleInitial.Clear();
            txtlastName.Clear();
            txtcourse.Clear();
            txtyear.Clear();
            txttransaction.Clear();
            txtcontrolNo.Clear();
        }

        private bool ValidateInput()
        {
                if (string.IsNullOrWhiteSpace(txtfirstName.Text))
                {
                    MessageBox.Show("First Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txtlastName.Text))
                {
                    MessageBox.Show("Last Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txtdate.Text))
                {
                    MessageBox.Show("Date is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txttransaction.Text))
                {
                    MessageBox.Show("Reason/Transaction is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txtyear.Text))
                {
                    MessageBox.Show("Year field is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            return true;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Visible = true;
        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (!string.IsNullOrEmpty(txtsearch.Text))
                {
                    dataGridView1.DataSource = addTransactionBindingSource;
                }
                else
                {
                    
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) => pictureBox1.Image = new Bitmap("logbookPLV.Properties.Resources.PLV_BG");
        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string studentId = selectedRow.Cells["student_Id"].Value.ToString();
                string firstName = selectedRow.Cells["firstName"].Value.ToString();
                string middleInitial = selectedRow.Cells["middleInitial"].Value.ToString();
                string lastName = selectedRow.Cells["lastName"].Value.ToString();
                string course = selectedRow.Cells["course"].Value.ToString();
                string year = selectedRow.Cells["year"].Value.ToString();
                string reason = selectedRow.Cells["reason"].Value.ToString();
                string controlNo = selectedRow.Cells["controlNo"].Value.ToString();
                string date = selectedRow.Cells["date"].Value.ToString();
                int selectedRowId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                byte[] imageData = (byte[])selectedRow.Cells["imageData"].Value;

                transaction editForm = new transaction(studentId, firstName, middleInitial, lastName, course, year, reason, controlNo, date, imageData);
                editForm.SelectedRowId = selectedRowId;
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    disp_data();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }


        private void txtfirstName_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtsearch.Text.Trim();

            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HEO3J7VO\SQLEXPRESS;Initial Catalog=LOGBOOKPLV;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        cmd.CommandText = "SELECT * FROM addTransaction WHERE firstName LIKE @searchTerm OR lastName LIKE @searchTerm OR student_Id LIKE @searchTerm";
                        cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM addTransaction";
                    }

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void uploadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pictureBox2.Image = new Bitmap(selectedFilePath);
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.ShowReadOnly = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                pictureBox2.Image = new Bitmap(selectedFilePath);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["imageData"].Index)
            {
                if (e.Value != null)
                {
                    byte[] imageData = (byte[])e.Value;
                    if (imageData.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            e.Value = Image.FromStream(ms);
                        }
                    }
                }
            }
        }

        private byte[] GetImageDataFromSelectedRow()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    byte[] imageData = (byte[])selectedRow.Cells["imageData"].Value;
                    return imageData;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving image data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null;
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            byte[] imageData = GetImageDataFromSelectedRow();

            if (imageData != null)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string studentId = selectedRow.Cells["student_Id"].Value.ToString();
                    string firstName = selectedRow.Cells["firstName"].Value.ToString();
                    string middleInitial = selectedRow.Cells["middleInitial"].Value.ToString();
                    string lastName = selectedRow.Cells["lastName"].Value.ToString();
                    string course = selectedRow.Cells["course"].Value.ToString();
                    string year = selectedRow.Cells["year"].Value.ToString();
                    string reason = selectedRow.Cells["reason"].Value.ToString();
                    string controlNo = selectedRow.Cells["controlNo"].Value.ToString();
                    string date = selectedRow.Cells["date"].Value.ToString();

                    detailsForm detailsForm = new detailsForm(studentId, firstName, middleInitial, lastName, course, year, reason, controlNo, date, imageData);
                    detailsForm.Show(this);
                }
            }
            else
            {
                MessageBox.Show("Please select a row with image data to view details.");
            }
        }

        private void takePhoto_Click(object sender, EventArgs e)
        {
            CapturePreviewForm capturePreviewForm = new CapturePreviewForm();
            capturePreviewForm.Show(this);
            pictureBox2.Image = capturePreviewForm.CapturedImage;
        }
    }


    }
