namespace FeeCollectionApp.Views
{
    partial class PaymentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentView));
            tblPayments = new TableLayoutPanel();
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
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblCount = new Label();
            dgvPayments = new DataGridView();
            colRollNo = new DataGridViewTextBoxColumn();
            colStudentName = new DataGridViewTextBoxColumn();
            colProgram = new DataGridViewTextBoxColumn();
            colTotalFee = new DataGridViewTextBoxColumn();
            colPaidFee = new DataGridViewTextBoxColumn();
            colRemaining = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            tblPayments.SuspendLayout();
            tsCommands.SuspendLayout();
            flpFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // tblPayments
            // 
            tblPayments.ColumnCount = 1;
            tblPayments.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPayments.Controls.Add(tsCommands, 0, 0);
            tblPayments.Controls.Add(flpFilters, 0, 1);
            tblPayments.Controls.Add(dgvPayments, 0, 2);
            tblPayments.Dock = DockStyle.Fill;
            tblPayments.Location = new Point(0, 0);
            tblPayments.Margin = new Padding(3, 4, 3, 4);
            tblPayments.Name = "tblPayments";
            tblPayments.Padding = new Padding(18, 20, 18, 20);
            tblPayments.RowCount = 3;
            tblPayments.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblPayments.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblPayments.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tblPayments.Size = new Size(897, 594);
            tblPayments.TabIndex = 2;
            // 
            // tsCommands
            // 
            tsCommands.ImageScalingSize = new Size(24, 24);
            tsCommands.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbView, tsbDelete, toolStripSeparator1, tsbRefresh });
            tsCommands.Location = new Point(18, 20);
            tsCommands.Name = "tsCommands";
            tsCommands.Size = new Size(861, 34);
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
            flpFilters.Controls.Add(lblStatus);
            flpFilters.Controls.Add(cmbStatus);
            flpFilters.Controls.Add(lblCount);
            flpFilters.Dock = DockStyle.Fill;
            flpFilters.Location = new Point(21, 78);
            flpFilters.Name = "flpFilters";
            flpFilters.Size = new Size(855, 49);
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
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(282, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(66, 28);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(354, 3);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(182, 33);
            cmbStatus.TabIndex = 4;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(542, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(80, 28);
            lblCount.TabIndex = 2;
            lblCount.Text = "Count:0";
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayments.BackgroundColor = Color.White;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Columns.AddRange(new DataGridViewColumn[] { colRollNo, colStudentName, colProgram, colTotalFee, colPaidFee, colRemaining, colStatus });
            dgvPayments.Dock = DockStyle.Fill;
            dgvPayments.Location = new Point(21, 133);
            dgvPayments.MultiSelect = false;
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersVisible = false;
            dgvPayments.RowHeadersWidth = 62;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(855, 438);
            dgvPayments.TabIndex = 2;
            // 
            // colRollNo
            // 
            colRollNo.DataPropertyName = "RollNo";
            colRollNo.HeaderText = "Roll No";
            colRollNo.MinimumWidth = 8;
            colRollNo.Name = "colRollNo";
            colRollNo.ReadOnly = true;
            // 
            // colStudentName
            // 
            colStudentName.DataPropertyName = "StudentName";
            colStudentName.HeaderText = "Student Name";
            colStudentName.MinimumWidth = 8;
            colStudentName.Name = "colStudentName";
            colStudentName.ReadOnly = true;
            // 
            // colProgram
            // 
            colProgram.DataPropertyName = "Program";
            colProgram.HeaderText = "Program";
            colProgram.MinimumWidth = 8;
            colProgram.Name = "colProgram";
            colProgram.ReadOnly = true;
            // 
            // colTotalFee
            // 
            colTotalFee.DataPropertyName = "TotalFee";
            colTotalFee.HeaderText = "Total Fee";
            colTotalFee.MinimumWidth = 8;
            colTotalFee.Name = "colTotalFee";
            colTotalFee.ReadOnly = true;
            // 
            // colPaidFee
            // 
            colPaidFee.DataPropertyName = "PaidFee";
            colPaidFee.HeaderText = "Paid Fee";
            colPaidFee.MinimumWidth = 8;
            colPaidFee.Name = "colPaidFee";
            colPaidFee.ReadOnly = true;
            // 
            // colRemaining
            // 
            colRemaining.DataPropertyName = "Remaining";
            colRemaining.HeaderText = "Remaining";
            colRemaining.MinimumWidth = 8;
            colRemaining.Name = "colRemaining";
            colRemaining.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // PaymentView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblPayments);
            Name = "PaymentView";
            Size = new Size(897, 594);
            tblPayments.ResumeLayout(false);
            tblPayments.PerformLayout();
            tsCommands.ResumeLayout(false);
            tsCommands.PerformLayout();
            flpFilters.ResumeLayout(false);
            flpFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblPayments;
        private ToolStrip tsCommands;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbView;
        private ToolStripButton tsbDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbRefresh;
        private FlowLayoutPanel flpFilters;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblCount;
        private DataGridView dgvPayments;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private DataGridViewTextBoxColumn colRollNo;
        private DataGridViewTextBoxColumn colStudentName;
        private DataGridViewTextBoxColumn colProgram;
        private DataGridViewTextBoxColumn colTotalFee;
        private DataGridViewTextBoxColumn colPaidFee;
        private DataGridViewTextBoxColumn colRemaining;
        private DataGridViewTextBoxColumn colStatus;
        private ToolStripButton tsbEdit;
    }
}
