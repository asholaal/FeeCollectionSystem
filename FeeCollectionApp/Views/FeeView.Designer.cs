namespace FeeCollectionApp.Views
{
    partial class FeeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeeView));
            tblFees = new TableLayoutPanel();
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
            lblCount = new Label();
            dgvFees = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colProgram = new DataGridViewTextBoxColumn();
            colTotalFee = new DataGridViewTextBoxColumn();
            tblFees.SuspendLayout();
            tsCommands.SuspendLayout();
            flpFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFees).BeginInit();
            SuspendLayout();
            // 
            // tblFees
            // 
            tblFees.ColumnCount = 1;
            tblFees.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblFees.Controls.Add(tsCommands, 0, 0);
            tblFees.Controls.Add(flpFilters, 0, 1);
            tblFees.Controls.Add(dgvFees, 0, 2);
            tblFees.Dock = DockStyle.Fill;
            tblFees.Location = new Point(0, 0);
            tblFees.Margin = new Padding(3, 4, 3, 4);
            tblFees.Name = "tblFees";
            tblFees.Padding = new Padding(18, 20, 18, 20);
            tblFees.RowCount = 3;
            tblFees.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblFees.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblFees.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tblFees.Size = new Size(1149, 588);
            tblFees.TabIndex = 1;
            // 
            // tsCommands
            // 
            tsCommands.ImageScalingSize = new Size(24, 24);
            tsCommands.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbView, tsbDelete, toolStripSeparator1, tsbRefresh });
            tsCommands.Location = new Point(18, 20);
            tsCommands.Name = "tsCommands";
            tsCommands.Size = new Size(1113, 34);
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
            flpFilters.Controls.Add(lblCount);
            flpFilters.Dock = DockStyle.Fill;
            flpFilters.Location = new Point(21, 77);
            flpFilters.Name = "flpFilters";
            flpFilters.Size = new Size(1107, 48);
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
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(282, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(80, 28);
            lblCount.TabIndex = 2;
            lblCount.Text = "Count:0";
            // 
            // dgvFees
            // 
            dgvFees.AllowUserToAddRows = false;
            dgvFees.AllowUserToDeleteRows = false;
            dgvFees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFees.BackgroundColor = Color.White;
            dgvFees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFees.Columns.AddRange(new DataGridViewColumn[] { colId, colProgram, colTotalFee });
            dgvFees.Dock = DockStyle.Fill;
            dgvFees.Location = new Point(21, 131);
            dgvFees.MultiSelect = false;
            dgvFees.Name = "dgvFees";
            dgvFees.ReadOnly = true;
            dgvFees.RowHeadersVisible = false;
            dgvFees.RowHeadersWidth = 62;
            dgvFees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFees.Size = new Size(1107, 434);
            dgvFees.TabIndex = 2;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
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
            colTotalFee.HeaderText = "TotalFee";
            colTotalFee.MinimumWidth = 8;
            colTotalFee.Name = "colTotalFee";
            colTotalFee.ReadOnly = true;
            // 
            // FeeView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblFees);
            Name = "FeeView";
            Size = new Size(1149, 588);
            Load += FeeView_Load;
            tblFees.ResumeLayout(false);
            tblFees.PerformLayout();
            tsCommands.ResumeLayout(false);
            tsCommands.PerformLayout();
            flpFilters.ResumeLayout(false);
            flpFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblFees;
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
        private DataGridView dgvFees;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colProgram;
        private DataGridViewTextBoxColumn colTotalFee;
    }
}
