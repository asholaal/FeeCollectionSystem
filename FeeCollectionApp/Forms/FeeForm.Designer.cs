namespace FeeCollectionApp.Forms
{
    partial class FeeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeeForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tblStudent = new TableLayoutPanel();
            txtId = new TextBox();
            lblId = new Label();
            txtProgram = new TextBox();
            lblProgram = new Label();
            lblTotalFee = new Label();
            nudTotalFee = new NumericUpDown();
            flowLayoutPanel1.SuspendLayout();
            tblStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalFee).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 392);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 58);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(661, 9);
            btnSave.Margin = new Padding(9);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(3);
            btnSave.Size = new Size(130, 44);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(513, 9);
            btnCancel.Margin = new Padding(9);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(3);
            btnCancel.Size = new Size(130, 44);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tblStudent
            // 
            tblStudent.ColumnCount = 2;
            tblStudent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblStudent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tblStudent.Controls.Add(txtId, 1, 2);
            tblStudent.Controls.Add(lblId, 0, 2);
            tblStudent.Controls.Add(txtProgram, 1, 1);
            tblStudent.Controls.Add(lblProgram, 0, 1);
            tblStudent.Controls.Add(lblTotalFee, 0, 0);
            tblStudent.Controls.Add(nudTotalFee, 1, 0);
            tblStudent.Dock = DockStyle.Top;
            tblStudent.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblStudent.Location = new Point(0, 0);
            tblStudent.Name = "tblStudent";
            tblStudent.RowCount = 3;
            tblStudent.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblStudent.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblStudent.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblStudent.Size = new Size(800, 160);
            tblStudent.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(123, 103);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(674, 31);
            txtId.TabIndex = 9;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Dock = DockStyle.Fill;
            lblId.Location = new Point(3, 100);
            lblId.Name = "lblId";
            lblId.Size = new Size(114, 60);
            lblId.TabIndex = 8;
            lblId.Text = "Id";
            // 
            // txtProgram
            // 
            txtProgram.Dock = DockStyle.Fill;
            txtProgram.Location = new Point(123, 53);
            txtProgram.Name = "txtProgram";
            txtProgram.Size = new Size(674, 31);
            txtProgram.TabIndex = 5;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Dock = DockStyle.Fill;
            lblProgram.Location = new Point(3, 50);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(114, 50);
            lblProgram.TabIndex = 4;
            lblProgram.Text = "Program";
            // 
            // lblTotalFee
            // 
            lblTotalFee.AutoSize = true;
            lblTotalFee.Dock = DockStyle.Fill;
            lblTotalFee.Location = new Point(3, 0);
            lblTotalFee.Name = "lblTotalFee";
            lblTotalFee.Size = new Size(114, 50);
            lblTotalFee.TabIndex = 0;
            lblTotalFee.Text = "Total Fee";
            // 
            // nudTotalFee
            // 
            nudTotalFee.Dock = DockStyle.Fill;
            nudTotalFee.Location = new Point(123, 3);
            nudTotalFee.Name = "nudTotalFee";
            nudTotalFee.Size = new Size(674, 31);
            nudTotalFee.TabIndex = 10;
            // 
            // FeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblStudent);
            Controls.Add(flowLayoutPanel1);
            Name = "FeeForm";
            Text = "FeeForm";
            flowLayoutPanel1.ResumeLayout(false);
            tblStudent.ResumeLayout(false);
            tblStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalFee).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSave;
        private Button btnCancel;
        private TableLayoutPanel tblStudent;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtProgram;
        private Label lblProgram;
        private Label lblTotalFee;
        private NumericUpDown nudTotalFee;
    }
}