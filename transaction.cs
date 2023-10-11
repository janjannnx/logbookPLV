using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace logbookPLV
{
    public partial class transaction : Form
    {

        public int SelectedRowId { get; set; }
        private OpenFileDialog openFileDialog1;
        public transaction(string studentId, string firstName, string middleInitial, string lastName, string course, string year, string reason, string controlNo, string date, byte[] imageData)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.TopMost = true;
            txtstudentId.Text = studentId;
            txtfirstName.Text = firstName;
            txtmiddleInitial.Text = middleInitial;
            txtlastName.Text = lastName;
            txtcourse.Text = course;
            txtyear.Text = year;
            txttransaction.Text = reason;
            txtcontrolNo.Text = controlNo;
            txtdate.Text = date;

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HEO3J7VO\SQLEXPRESS;Initial Catalog=LOGBOOKPLV;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE addTransaction SET firstName = @firstName, middleInitial = @middleInitial, lastName = @lastName, course = @course, year = @year, reason = @reason, controlNo = @controlNo, date = @date, student_Id = @studentId WHERE id = @id", con))
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
                    cmd.Parameters.AddWithValue("@id", SelectedRowId);

                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Transaction updated.");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error updating transaction. Please try again.");
                    }
                }
            }
            if (Application.OpenForms["logbook"] is logbook mainForm)
            {
                mainForm.disp_data();
            }
        }


        private void transaction_Load(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Select an Image";
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pictureBox1.Image = new Bitmap(selectedFilePath);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e) => pictureBox1.Image = new Bitmap("logbookPLV.Properties.Resources.PLV_BG");
    }
}
