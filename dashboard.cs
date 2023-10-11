using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logbookPLV
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void logbookButton_Click(object sender, EventArgs e)
        {
            logbook logbook = new logbook();
            logbook.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }
    }
}
