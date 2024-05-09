using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace HealthcareManagement.Screens.OperationsLab
{
    public partial class OpenCSVFile : Form
    {
        public OpenCSVFile()
        {
            InitializeComponent();
        }

        // Declare csvFilePath as a class-level variable
        private string csvFilePath;
        public List<string> tests = new List<string>();

        private void OpenCSVFile_Load(object sender, EventArgs e)
        {
            csvFilePath = Application.StartupPath + "\\table_2.csv";
            LoadCSVToDataGridView(csvFilePath);

            for (int index = 0; index < dataGridView1.ColumnCount - 1; index++)
            {
                comboColumns.Items.Add(index.ToString());
            }
            comboColumns.Text = "2";
        }
        public void LoadCSVToDataGridView(string csvFilePath)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (StreamReader reader = new StreamReader(csvFilePath))
                {
                    string headerLine = reader.ReadLine();
                    MessageBox.Show(headerLine);
                    if (headerLine != null)
                    {
                        string[] headers = headerLine.Split(',');
                        MessageBox.Show(headers.Length.ToString());
                        for (int index = 0; index < headers.Length; index++)
                        {
                            DataGridViewTextBoxColumn tb = new DataGridViewTextBoxColumn();
                            tb.Name = index.ToString();
                            dataGridView1.Columns.Add(tb);
                        }
                    }
                    while (!reader.EndOfStream)
                    {
                        string dataLine = reader.ReadLine();
                        if (dataLine != null)
                        {
                            string[] data = dataLine.Split(',');
                            dataGridView1.Rows.Add(data);
                        }
                    }
                }
                dataGridView1.AutoResizeColumns();
                DataGridViewCheckBoxColumn tb1 = new DataGridViewCheckBoxColumn();
                tb1.Name = "Sel";
                dataGridView1.Columns.Add(tb1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading CSV file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tests.Count.ToString());
            Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = int.Parse(comboColumns.SelectedItem.ToString());

            // Check if the checkbox cell and the cell value are not null
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells[dataGridView1.Columns.Count - 1] != null)
            {
                var checkboxCellValue = dataGridView1.CurrentRow.Cells[dataGridView1.Columns.Count - 1].Value;

                // Check if the checkbox cell value is a boolean
                if (checkboxCellValue is bool isCheckboxChecked)
                {
                    if (isCheckboxChecked)
                    {
                        // Check if the target cell exists and its value is not null
                        var targetCell = dataGridView1.CurrentRow.Cells[columnIndex];
                        if (targetCell != null && targetCell.Value != null)
                        {
                            tests.Add(targetCell.Value.ToString());
                        }
                    }
                    else
                    {
                        // Check if the target cell exists and its value is not null
                        var targetCell = dataGridView1.CurrentRow.Cells[columnIndex];
                        if (targetCell != null && targetCell.Value != null)
                        {
                            tests.Remove(targetCell.Value.ToString());
                        }
                    }
                }
            }

        }
    }
}