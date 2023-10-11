using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;



namespace logbookPLV
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        private DataTable transactionData;

        private void Report_Load(object sender, EventArgs e)
        {
            this.addTransactionTableAdapter.Fill(this.lOGBOOKPLVDataSet1.addTransaction);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;

            transactionData = LoadTransactionData();
            dataGridView1.DataSource = transactionData;
            int rowCount = dataGridView1.RowCount - 1;
            numberOfTransaction.Text = "Number of Transaction: " + rowCount.ToString();
            LoadCourseComboBox();
            LoadYearComboBox();
            LoadTransactionComboBox();
        }
        private DataTable LoadTransactionData()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HEO3J7VO\SQLEXPRESS;Initial Catalog=LOGBOOKPLV;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM addTransaction", con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
        }
        private void LoadCourseComboBox()
        {
            var distinctCourses = transactionData.AsEnumerable()
                .Select(row => row.Field<string>("Course"))
                .Distinct()
                .ToList();

            courseComboBox.DataSource = distinctCourses;
        }
        private void LoadYearComboBox()
        {
            var distinctYears = transactionData.AsEnumerable()
                .Select(row => row.Field<string>("Year"))
                .Distinct()
                .ToList();

            dateComboBox.DataSource = distinctYears;
        }
        private void LoadTransactionComboBox()
        {
            var distinctTransaction = transactionData.AsEnumerable()
                .Select(row => row.Field<string>("Reason"))
                .Distinct()
                .ToList();

            transactionComboBox.DataSource = distinctTransaction;
        }

        private void ExportToExcel(DataGridView dataGridView)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;
                for (int i = 1; i <= dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j]?.Value?.ToString() ?? "";
                    }
                }
                int rowCount = dataGridView.Rows.Count - 1;
                worksheet.Cells[rowCount + 2, 1] = "Number of Transactions:";
                worksheet.Cells[rowCount + 2, 2] = rowCount;
                worksheet.UsedRange.Columns.AutoFit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data to Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void transactionlbl_Click(object sender, EventArgs e)
        {

        }

        private void extractButton_Click(object sender, EventArgs e)
        {
            ExportToExcel(dataGridView1);
        }

        private void courseComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            {
                string selectedCourse = courseComboBox.SelectedItem as string;

                if (string.IsNullOrEmpty(selectedCourse))
                {
                    dataGridView1.DataSource = transactionData;
                }
                else
                {
                    DataTable filteredData = transactionData.Clone();
                    DataRow[] filteredRows = transactionData.Select("Course = '" + selectedCourse + "'");

                    foreach (DataRow row in filteredRows)
                    {
                        filteredData.ImportRow(row);
                    }

                    dataGridView1.DataSource = filteredData;
                }
                int rowCount = dataGridView1.RowCount - 1;
                numberOfTransaction.Text = "Number of Transaction: " + rowCount.ToString();
            }

        }
        private void allCourseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool selectAllCourses = allCourseCheckBox.Checked;
            courseComboBox.Enabled = !selectAllCourses;

            if (selectAllCourses)
            {
                dataGridView1.DataSource = transactionData;
                int rowCount = dataGridView1.RowCount - 1;
                numberOfTransaction.Text = "Number of Transaction: " + rowCount.ToString();
            }
            else
            {
                courseComboBox_SelectedIndexChanged_1(null, null);
            }
        }
        private void dateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedYear = dateComboBox.SelectedItem as string;

            if (string.IsNullOrEmpty(selectedYear))
            {
                dataGridView1.DataSource = transactionData;
            }
            else
            {
                DataTable filteredData = transactionData.Clone();
                DataRow[] filteredRows = transactionData.Select("Year = '" + selectedYear + "'");

                foreach (DataRow row in filteredRows)
                {
                    filteredData.ImportRow(row);
                }

                dataGridView1.DataSource = filteredData;
            }
            int rowCount = dataGridView1.RowCount - 1;
            numberOfTransaction.Text = "Number of Transaction: " + rowCount.ToString();
        }

        private void allDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool selectAllYears = allDateCheckBox.Checked;
            dateComboBox.Enabled = !selectAllYears;

            if (selectAllYears)
            {
                dataGridView1.DataSource = transactionData;
                int rowCount = dataGridView1.RowCount - 1;
                numberOfTransaction.Text = "Number of Transaction: " + rowCount.ToString();
            }
            else
            {
                dateComboBox_SelectedIndexChanged(null, null);
            }
        }

        private void allTransactionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool selectAllTransactions = allTransactionCheckBox.Checked;
            transactionComboBox.Enabled = !selectAllTransactions;

            if (selectAllTransactions)
            {
                dataGridView1.DataSource = transactionData;
                int rowCount = dataGridView1.RowCount - 1;
                numberOfTransaction.Text = "Number of Transaction: " + rowCount.ToString();
            }
            else
            {
                transactionComboBox_SelectedIndexChanged(null, null);
            }
        }

        private void transactionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTransaction = transactionComboBox.SelectedItem as string;

            if (string.IsNullOrEmpty(selectedTransaction))
            {
                dataGridView1.DataSource = transactionData;
            }
            else
            {
                DataTable filteredData = transactionData.Clone();
                DataRow[] filteredRows = transactionData.Select("Reason = '" + selectedTransaction + "'");

                foreach (DataRow row in filteredRows)
                {
                    filteredData.ImportRow(row);
                }

                dataGridView1.DataSource = filteredData;
            }
            int rowCount = dataGridView1.RowCount - 1;
            numberOfTransaction.Text = "Number of Transaction: " + rowCount.ToString();
        }
    }
}
