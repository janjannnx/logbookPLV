using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logbookPLV
{
    public partial class detailsForm : Form
    {
        public detailsForm(string studentId, string firstName, string middleInitial, string lastName, string course, string year, string reason, string controlNo, string date, byte[] imageData)
        {
            InitializeComponent();
            lblStudentId.Text = $"Student ID: {studentId}";
            string fullName = $"{firstName} {middleInitial} {lastName}";
            lblName.Text = $"Name: {fullName}";
            lblCourse.Text = $"Course: {course}";
            lblYear.Text = $"Year: {year}";
            lblReason.Text = $"Reason: {reason}";
            lblControlNo.Text = $"Control No: {controlNo}";
            lblDate.Text = $"Date: {date}";

            try
            {
                if (imageData != null && imageData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void detailsFormcs_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
