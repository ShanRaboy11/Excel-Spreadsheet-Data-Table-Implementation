namespace DataGridView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            btnAddRow = new Button();
            btnDeleteRow = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            btnDeleteColumn = new Button();
            btnAddColumn = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addRowToolStripMenuItem = new ToolStripMenuItem();
            addColumnToolStripMenuItem = new ToolStripMenuItem();
            deleteRowToolStripMenuItem = new ToolStripMenuItem();
            deleteColumnToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(126, 204, 169);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(191, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(734, 518);
            dataGridView1.TabIndex = 0;
            // 
            // btnAddRow
            // 
            btnAddRow.BackColor = Color.FromArgb(153, 204, 255);
            btnAddRow.BackgroundImageLayout = ImageLayout.None;
            btnAddRow.FlatStyle = FlatStyle.Flat;
            btnAddRow.Font = new Font("Helvetica Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddRow.ForeColor = SystemColors.ActiveCaptionText;
            btnAddRow.Location = new Point(29, 52);
            btnAddRow.Name = "btnAddRow";
            btnAddRow.Size = new Size(95, 34);
            btnAddRow.TabIndex = 1;
            btnAddRow.Text = "ADD";
            btnAddRow.UseVisualStyleBackColor = false;
            btnAddRow.Click += btnAddRow_Click;
            // 
            // btnDeleteRow
            // 
            btnDeleteRow.BackColor = Color.FromArgb(153, 204, 255);
            btnDeleteRow.BackgroundImageLayout = ImageLayout.None;
            btnDeleteRow.FlatStyle = FlatStyle.Flat;
            btnDeleteRow.Font = new Font("Helvetica Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDeleteRow.ForeColor = SystemColors.ActiveCaptionText;
            btnDeleteRow.Location = new Point(29, 113);
            btnDeleteRow.Name = "btnDeleteRow";
            btnDeleteRow.Size = new Size(95, 34);
            btnDeleteRow.TabIndex = 2;
            btnDeleteRow.Text = "DELETE";
            btnDeleteRow.UseVisualStyleBackColor = false;
            btnDeleteRow.Click += btnDeleteRow_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 204, 153);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDeleteRow);
            panel1.Controls.Add(btnAddRow);
            panel1.Location = new Point(18, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 178);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica Neue", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(45, 16);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 3;
            label1.Text = "ROW";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 204, 153);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnDeleteColumn);
            panel2.Controls.Add(btnAddColumn);
            panel2.Location = new Point(18, 333);
            panel2.Name = "panel2";
            panel2.Size = new Size(154, 178);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica Neue", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(29, 19);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 3;
            label2.Text = "COLUMN";
            // 
            // btnDeleteColumn
            // 
            btnDeleteColumn.BackColor = Color.FromArgb(153, 204, 255);
            btnDeleteColumn.BackgroundImageLayout = ImageLayout.None;
            btnDeleteColumn.FlatStyle = FlatStyle.Flat;
            btnDeleteColumn.Font = new Font("Helvetica Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDeleteColumn.ForeColor = SystemColors.ActiveCaptionText;
            btnDeleteColumn.Location = new Point(29, 115);
            btnDeleteColumn.Name = "btnDeleteColumn";
            btnDeleteColumn.Size = new Size(95, 34);
            btnDeleteColumn.TabIndex = 2;
            btnDeleteColumn.Text = "DELETE";
            btnDeleteColumn.UseVisualStyleBackColor = false;
            btnDeleteColumn.Click += btnDeleteColumn_Click;
            // 
            // btnAddColumn
            // 
            btnAddColumn.BackColor = Color.FromArgb(153, 204, 255);
            btnAddColumn.BackgroundImageLayout = ImageLayout.None;
            btnAddColumn.FlatStyle = FlatStyle.Flat;
            btnAddColumn.Font = new Font("Helvetica Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddColumn.ForeColor = SystemColors.ActiveCaptionText;
            btnAddColumn.Location = new Point(29, 56);
            btnAddColumn.Name = "btnAddColumn";
            btnAddColumn.Size = new Size(95, 34);
            btnAddColumn.TabIndex = 1;
            btnAddColumn.Text = "ADD";
            btnAddColumn.UseVisualStyleBackColor = false;
            btnAddColumn.Click += btnAddColumn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Helvetica Neue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(943, 25);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(42, 21);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(113, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(113, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Helvetica Neue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addRowToolStripMenuItem, addColumnToolStripMenuItem, deleteRowToolStripMenuItem, deleteColumnToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(176, 92);
            // 
            // addRowToolStripMenuItem
            // 
            addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
            addRowToolStripMenuItem.Size = new Size(175, 22);
            addRowToolStripMenuItem.Text = "Add Row";
            addRowToolStripMenuItem.Click += btnAddRow_Click;
            // 
            // addColumnToolStripMenuItem
            // 
            addColumnToolStripMenuItem.Name = "addColumnToolStripMenuItem";
            addColumnToolStripMenuItem.Size = new Size(175, 22);
            addColumnToolStripMenuItem.Text = "Add Column";
            addColumnToolStripMenuItem.Click += btnAddColumn_Click;
            // 
            // deleteRowToolStripMenuItem
            // 
            deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            deleteRowToolStripMenuItem.Size = new Size(175, 22);
            deleteRowToolStripMenuItem.Text = "Delete Row";
            deleteRowToolStripMenuItem.Click += btnDeleteRow_Click;
            // 
            // deleteColumnToolStripMenuItem
            // 
            deleteColumnToolStripMenuItem.Name = "deleteColumnToolStripMenuItem";
            deleteColumnToolStripMenuItem.Size = new Size(175, 22);
            deleteColumnToolStripMenuItem.Text = "Delete Column";
            deleteColumnToolStripMenuItem.Click += btnDeleteColumn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(204, 255, 229);
            ClientSize = new Size(943, 575);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Helvetica Neue", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Table";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Button btnAddRow;
        private Button btnDeleteRow;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button btnDeleteColumn;
        private Button btnAddColumn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addRowToolStripMenuItem;
        private ToolStripMenuItem addColumnToolStripMenuItem;
        private ToolStripMenuItem deleteRowToolStripMenuItem;
        private ToolStripMenuItem deleteColumnToolStripMenuItem;
    }
}
