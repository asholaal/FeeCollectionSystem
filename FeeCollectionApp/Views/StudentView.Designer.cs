namespace FeeCollectionApp.Views
{
    partial class StudentView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentView));
            tableLayoutPanel1 = new TableLayoutPanel();
            tsCommands = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbView = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            flpFilters = new FlowLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblProgram = new Label();
            cmbProgram = new ComboBox();
            lblCount = new Label();
            dgvStudents = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colRollNo = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colProgram = new DataGridViewTextBoxColumn();
            colContactNo = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tsCommands.SuspendLayout();
            flpFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tsCommands, 0, 0);
            tableLayoutPanel1.Controls.Add(flpFilters, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvStudents, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(18, 20, 18, 20);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(1276, 661);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tsCommands
            // 
            tsCommands.ImageScalingSize = new Size(24, 24);
            tsCommands.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbView, tsbDelete, toolStripSeparator1, tsbRefresh });
            tsCommands.Location = new Point(18, 20);
            tsCommands.Name = "tsCommands";
            tsCommands.Size = new Size(1240, 34);
            tsCommands.TabIndex = 0;
            tsCommands.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            tsbAdd.Font = new Font("Segoe UI Symbol", 9F);
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(74, 29);
            tsbAdd.Text = "Add";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.Font = new Font("Segoe UI Symbol", 9F);
            tsbEdit.Image = (Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(70, 29);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbView
            // 
            tsbView.Font = new Font("Segoe UI Symbol", 9F);
            tsbView.Image = (Image)resources.GetObject("tsbView.Image");
            tsbView.ImageTransparentColor = Color.Magenta;
            tsbView.Name = "tsbView";
            tsbView.Size = new Size(77, 29);
            tsbView.Text = "View";
            tsbView.Click += tsbView_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Font = new Font("Segoe UI Symbol", 9F);
            tsbDelete.Image = (Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(90, 29);
            tsbDelete.Text = "Delete";
            tsbDelete.Click += tsbDelete_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 34);
            // 
            // tsbRefresh
            // 
            tsbRefresh.Font = new Font("Segoe UI Symbol", 9F);
            tsbRefresh.Image = (Image)resources.GetObject("tsbRefresh.Image");
            tsbRefresh.ImageTransparentColor = Color.Magenta;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new Size(99, 29);
            tsbRefresh.Text = "Refresh";
            tsbRefresh.Click += tsbRefresh_Click;
            // 
            // flpFilters
            // 
            flpFilters.Controls.Add(lblSearch);
            flpFilters.Controls.Add(txtSearch);
            flpFilters.Controls.Add(lblProgram);
            flpFilters.Controls.Add(cmbProgram);
            flpFilters.Controls.Add(lblCount);
            flpFilters.Dock = DockStyle.Fill;
            flpFilters.Location = new Point(21, 85);
            flpFilters.Name = "flpFilters";
            flpFilters.Size = new Size(1234, 56);
            flpFilters.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(70, 28);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(79, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(197, 31);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgram.Location = new Point(282, 0);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(88, 28);
            lblProgram.TabIndex = 3;
            lblProgram.Text = "Program";
            // 
            // cmbProgram
            // 
            cmbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Location = new Point(376, 3);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(182, 33);
            cmbProgram.TabIndex = 4;
            cmbProgram.SelectedIndexChanged += cmbProgram_SelectedIndexChanged;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(564, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(80, 28);
            lblCount.TabIndex = 2;
            lblCount.Text = "Count:0";
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { colId, colRollNo, colName, colProgram, colContactNo });
            dgvStudents.Dock = DockStyle.Fill;
            dgvStudents.Location = new Point(21, 147);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 62;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(1234, 491);
            dgvStudents.TabIndex = 2;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colRollNo
            // 
            colRollNo.DataPropertyName = "RollNo";
            colRollNo.HeaderText = "RollNo";
            colRollNo.MinimumWidth = 8;
            colRollNo.Name = "colRollNo";
            colRollNo.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "FullName";
            colName.HeaderText = "FullName";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colProgram
            // 
            colProgram.DataPropertyName = "Program";
            colProgram.HeaderText = "Program";
            colProgram.MinimumWidth = 8;
            colProgram.Name = "colProgram";
            colProgram.ReadOnly = true;
            // 
            // colContactNo
            // 
            colContactNo.DataPropertyName = "ContactNo";
            colContactNo.HeaderText = "ContactNo";
            colContactNo.MinimumWidth = 8;
            colContactNo.Name = "colContactNo";
            colContactNo.ReadOnly = true;
            // 
            // StudentView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "StudentView";
            Size = new Size(1276, 661);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tsCommands.ResumeLayout(false);
            tsCommands.PerformLayout();
            flpFilters.ResumeLayout(false);
            flpFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ToolStrip tsCommands;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbView;
        private ToolStripButton tsbDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbRefresh;
        private FlowLayoutPanel flpFilters;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblCount;
        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colRollNo;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colProgram;
        private DataGridViewTextBoxColumn colContactNo;
        private Label lblProgram;
        private ComboBox cmbProgram;
    }
}
