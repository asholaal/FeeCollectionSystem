namespace FeeCollectionApp.Forms
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            tblStudent = new TableLayoutPanel();
            txtId = new TextBox();
            lblId = new Label();
            txtContactNo = new TextBox();
            lblContactNo = new Label();
            lblProgram = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            lblRollNo = new Label();
            txtRollNo = new TextBox();
            cmbProgram = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tblStudent.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblStudent
            // 
            tblStudent.ColumnCount = 2;
            tblStudent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblStudent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tblStudent.Controls.Add(txtId, 1, 4);
            tblStudent.Controls.Add(lblId, 0, 4);
            tblStudent.Controls.Add(txtContactNo, 1, 3);
            tblStudent.Controls.Add(lblContactNo, 0, 3);
            tblStudent.Controls.Add(lblProgram, 0, 2);
            tblStudent.Controls.Add(txtFullName, 1, 1);
            tblStudent.Controls.Add(lblFullName, 0, 1);
            tblStudent.Controls.Add(lblRollNo, 0, 0);
            tblStudent.Controls.Add(txtRollNo, 1, 0);
            tblStudent.Controls.Add(cmbProgram, 1, 2);
            tblStudent.Dock = DockStyle.Top;
            tblStudent.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblStudent.Location = new Point(0, 0);
            tblStudent.Name = "tblStudent";
            tblStudent.RowCount = 5;
            tblStudent.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblStudent.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tblStudent.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tblStudent.RowStyles.Add(new RowStyle());
            tblStudent.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tblStudent.Size = new Size(800, 194);
            tblStudent.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(123, 151);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(674, 31);
            txtId.TabIndex = 9;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Dock = DockStyle.Fill;
            lblId.Location = new Point(3, 148);
            lblId.Name = "lblId";
            lblId.Size = new Size(114, 46);
            lblId.TabIndex = 8;
            lblId.Text = "Id";
            // 
            // txtContactNo
            // 
            txtContactNo.Dock = DockStyle.Fill;
            txtContactNo.Location = new Point(123, 114);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.ScrollBars = ScrollBars.Vertical;
            txtContactNo.Size = new Size(674, 31);
            txtContactNo.TabIndex = 7;
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Dock = DockStyle.Fill;
            lblContactNo.Location = new Point(3, 111);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(114, 37);
            lblContactNo.TabIndex = 6;
            lblContactNo.Text = "Contact NO";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Dock = DockStyle.Fill;
            lblProgram.Location = new Point(3, 73);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(114, 38);
            lblProgram.TabIndex = 4;
            lblProgram.Text = "Program";
            // 
            // txtFullName
            // 
            txtFullName.Dock = DockStyle.Fill;
            txtFullName.Location = new Point(123, 38);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(674, 31);
            txtFullName.TabIndex = 3;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Dock = DockStyle.Fill;
            lblFullName.Location = new Point(3, 35);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(114, 38);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name";
            // 
            // lblRollNo
            // 
            lblRollNo.AutoSize = true;
            lblRollNo.Dock = DockStyle.Fill;
            lblRollNo.Location = new Point(3, 0);
            lblRollNo.Name = "lblRollNo";
            lblRollNo.Size = new Size(114, 35);
            lblRollNo.TabIndex = 0;
            lblRollNo.Text = "Roll No";
            // 
            // txtRollNo
            // 
            txtRollNo.Dock = DockStyle.Fill;
            txtRollNo.Location = new Point(123, 3);
            txtRollNo.Name = "txtRollNo";
            txtRollNo.Size = new Size(674, 31);
            txtRollNo.TabIndex = 1;
            // 
            // cmbProgram
            // 
            cmbProgram.Dock = DockStyle.Fill;
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Location = new Point(123, 76);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(674, 32);
            cmbProgram.TabIndex = 10;
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
            flowLayoutPanel1.TabIndex = 2;
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
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tblStudent);
            Name = "StudentForm";
            Text = "StudentForm";
            tblStudent.ResumeLayout(false);
            tblStudent.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblStudent;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtContactNo;
        private Label lblContactNo;
        private Label lblProgram;
        private TextBox txtFullName;
        private Label lblFullName;
        private Label lblRollNo;
        private TextBox txtRollNo;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cmbProgram;
    }
}