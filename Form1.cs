using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;
using System;
using System.Data;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = dataTable;
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
        }

        public static string ShowDialogue(string title, string prompt, string defaultText = "")
        {
            Form form = new Form()
            {
                Width = 600,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Font = new Font("Helvetica Neue", 12, FontStyle.Regular),
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label()
            {
                Left = 50,
                Top = 20,
                Font = new Font("Helvetica Neue", 12, FontStyle.Regular),
                Text = prompt,
                AutoSize = true
            };

            TextBox textBox = new TextBox()
            {
                Left = 50,
                Top = 50,
                Width = 400,
                Text = defaultText
            };

            Button okButton = new Button()
            {
                Text = "OK",
                Left = 350,
                Width = 100,
                Top = 100,
                DialogResult = DialogResult.OK
            };

            Button cancelButton = new Button()
            {
                Text = "Cancel",
                Left = 460,
                Width = 100,
                Top = 100,
                DialogResult = DialogResult.Cancel
            };

            form.Controls.Add(textLabel);
            form.Controls.Add(textBox);
            form.Controls.Add(okButton);
            form.Controls.Add(cancelButton);

            form.AcceptButton = okButton;
            form.CancelButton = cancelButton;

            return form.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (dataTable.Columns.Count > 0) 
            {
                dataTable.Rows.Add();
            }
            else
            {
                MessageBox.Show("Please add at least one column first.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataTable.Rows.Count > 0)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataTable.Rows.Count)
                {
                    dataTable.Rows.RemoveAt(rowIndex);
                }
            }
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            string header = ShowDialogue("Add Column Header", "Enter name of the column header");

            if (!string.IsNullOrEmpty(header))
            {
                try
                {
                    dataTable.Columns.Add(header);
                }
                catch (DuplicateNameException)
                {
                    MessageBox.Show("Column header already exists", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteColumn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataTable.Columns.Count > 0)
            {
                int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
                if (columnIndex >= 0 && columnIndex < dataTable.Columns.Count)
                {
                    dataTable.Columns.RemoveAt(columnIndex);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter =
                "XLS files (*.xls, *.xlt)|*.xls;*.xlt|" +
                "XLSX files (*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx;*.xlsm;*.xltx;*.xltm|: +" +
                "ODS fieles (*.ods, *.ots)|*.ods;*.ots|" +
                "CSV files (*.csv, *.tsv)|*.csv;*.tsv|" +
                "HTML files (*.html, *.htm)|*.html;*.htm";
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var workbook = ExcelFile.Load(openFileDialog.FileName);
                    var worksheet = workbook.Worksheets.ActiveWorksheet;

                    dataTable = worksheet.CreateDataTable(new CreateDataTableOptions()
                    {
                        ColumnHeaders = true,
                        StartRow = 0,
                    });

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading file {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter =
                "XLS (*.xls)|*.xls|" +
                "XLT (*.xlt)|*.xlt|" +
                "XLSX (*.xlsx)|*.xlsx|" +
                "XLSM (*.xlsm)|*.xlsm|" +
                "XLTX (*.xltx)|*.xltx|" +
                "XLTM (*.xltm)|*.xltm|" +
                "ODS (*.ods)|*.ods|" +
                "OTS (*.ots)|*.ots|" +
                "CSV (*.csv)|*.csv|" +
                "TSV (*.tsv)|*.tsv|" +
                "HTML (*.html)|*.html|" +
                "MHTML (.mhtml)|*.mhtml|" +
                "PDF (*.pdf)|*.pdf|" +
                "XPS (*.xps)|*.xps|" +
                "BMP (*.bmp)|*.bmp|" +
                "GIF (*.gif)|*.gif|" +
                "JPEG (*.jpg)|*.jpg|" +
                "PNG (*.png)|*.png|" +
                "TIFF (*.tif)|*.tif|" +
                "WMP (*.wdp)|*.wdp";

            saveFileDialog.FilterIndex = 3;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add("Sheet1");
           
                DataGridViewConverter.ImportFromDataGridView(
                worksheet,
                this.dataGridView1,
                new ImportFromDataGridViewOptions() { ColumnHeaders = true });
                workbook.Save(saveFileDialog.FileName);
            }
        }
    }
}