namespace FeeCollectionApp.Forms
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            pnlPayment = new Panel();
            pnlMain = new Panel();
            flpbtn = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tblProducts = new TableLayoutPanel();
            txtRemaining = new TextBox();
            txtPaidSoFar = new TextBox();
            txtTotalFee = new TextBox();
            txtProgram = new TextBox();
            cmbStudent = new ComboBox();
            lblAmountPaid = new Label();
            lblRemaining = new Label();
            lblPaidSoFar = new Label();
            lblTotalFee = new Label();
            lblProgram = new Label();
            lblName = new Label();
            dtpPaymentDate = new DateTimePicker();
            lblPaymentDate = new Label();
            nudAmountPaid = new NumericUpDown();
            pnlPayment.SuspendLayout();
            pnlMain.SuspendLayout();
            flpbtn.SuspendLayout();
            tblProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmountPaid).BeginInit();
            SuspendLayout();
            // 
            // pnlPayment
            // 
            pnlPayment.BackColor = Color.White;
            pnlPayment.Controls.Add(pnlMain);
            pnlPayment.Controls.Add(tblProducts);
            pnlPayment.Dock = DockStyle.Fill;
            pnlPayment.Location = new Point(0, 0);
            pnlPayment.Name = "pnlPayment";
            pnlPayment.Padding = new Padding(18);
            pnlPayment.Size = new Size(844, 520);
            pnlPayment.TabIndex = 1;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(flpbtn);
            pnlMain.Dock = DockStyle.Bottom;
            pnlMain.Location = new Point(18, 396);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(16);
            pnlMain.Size = new Size(808, 106);
            pnlMain.TabIndex = 1;
            // 
            // flpbtn
            // 
            flpbtn.Controls.Add(btnSave);
            flpbtn.Controls.Add(btnCancel);
            flpbtn.Dock = DockStyle.Fill;
            flpbtn.FlowDirection = FlowDirection.RightToLeft;
            flpbtn.Location = new Point(16, 16);
            flpbtn.Name = "flpbtn";
            flpbtn.Padding = new Padding(10);
            flpbtn.Size = new Size(776, 74);
            flpbtn.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(641, 13);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 50);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(523, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 50);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tblProducts
            // 
            tblProducts.BackColor = Color.White;
            tblProducts.ColumnCount = 2;
            tblProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tblProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tblProducts.Controls.Add(txtRemaining, 1, 4);
            tblProducts.Controls.Add(txtPaidSoFar, 1, 3);
            tblProducts.Controls.Add(txtTotalFee, 1, 2);
            tblProducts.Controls.Add(txtProgram, 1, 1);
            tblProducts.Controls.Add(cmbStudent, 1, 0);
            tblProducts.Controls.Add(lblAmountPaid, 0, 5);
            tblProducts.Controls.Add(lblRemaining, 0, 4);
            tblProducts.Controls.Add(lblPaidSoFar, 0, 3);
            tblProducts.Controls.Add(lblTotalFee, 0, 2);
            tblProducts.Controls.Add(lblProgram, 0, 1);
            tblProducts.Controls.Add(lblName, 0, 0);
            tblProducts.Controls.Add(dtpPaymentDate, 1, 6);
            tblProducts.Controls.Add(lblPaymentDate, 0, 6);
            tblProducts.Controls.Add(nudAmountPaid, 1, 5);
            tblProducts.Dock = DockStyle.Top;
            tblProducts.Location = new Point(18, 18);
            tblProducts.Name = "tblProducts";
            tblProducts.Padding = new Padding(11, 0, 0, 0);
            tblProducts.RowCount = 7;
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66824F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6682415F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6640759F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6682415F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66824F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6629639F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblProducts.Size = new Size(808, 355);
            tblProducts.TabIndex = 0;
            // 
            // txtRemaining
            // 
            txtRemaining.Dock = DockStyle.Fill;
            txtRemaining.Location = new Point(134, 211);
            txtRemaining.Name = "txtRemaining";
            txtRemaining.ReadOnly = true;
            txtRemaining.Size = new Size(671, 31);
            txtRemaining.TabIndex = 16;
            // 
            // txtPaidSoFar
            // 
            txtPaidSoFar.Dock = DockStyle.Fill;
            txtPaidSoFar.Location = new Point(134, 159);
            txtPaidSoFar.Name = "txtPaidSoFar";
            txtPaidSoFar.ReadOnly = true;
            txtPaidSoFar.Size = new Size(671, 31);
            txtPaidSoFar.TabIndex = 15;
            // 
            // txtTotalFee
            // 
            txtTotalFee.Dock = DockStyle.Fill;
            txtTotalFee.Location = new Point(134, 107);
            txtTotalFee.Name = "txtTotalFee";
            txtTotalFee.ReadOnly = true;
            txtTotalFee.Size = new Size(671, 31);
            txtTotalFee.TabIndex = 14;
            // 
            // txtProgram
            // 
            txtProgram.Dock = DockStyle.Fill;
            txtProgram.Location = new Point(134, 55);
            txtProgram.Name = "txtProgram";
            txtProgram.ReadOnly = true;
            txtProgram.Size = new Size(671, 31);
            txtProgram.TabIndex = 13;
            // 
            // cmbStudent
            // 
            cmbStudent.Dock = DockStyle.Fill;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(134, 3);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(671, 33);
            cmbStudent.TabIndex = 12;
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.AutoSize = true;
            lblAmountPaid.Dock = DockStyle.Fill;
            lblAmountPaid.Location = new Point(14, 260);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(114, 52);
            lblAmountPaid.TabIndex = 11;
            lblAmountPaid.Text = "Amount Paid";
            lblAmountPaid.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRemaining
            // 
            lblRemaining.AutoSize = true;
            lblRemaining.Dock = DockStyle.Fill;
            lblRemaining.Location = new Point(14, 208);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(114, 52);
            lblRemaining.TabIndex = 10;
            lblRemaining.Text = "Remaining";
            lblRemaining.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPaidSoFar
            // 
            lblPaidSoFar.AutoSize = true;
            lblPaidSoFar.Dock = DockStyle.Fill;
            lblPaidSoFar.Location = new Point(14, 156);
            lblPaidSoFar.Name = "lblPaidSoFar";
            lblPaidSoFar.Size = new Size(114, 52);
            lblPaidSoFar.TabIndex = 9;
            lblPaidSoFar.Text = "Paid So Far";
            lblPaidSoFar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalFee
            // 
            lblTotalFee.AutoSize = true;
            lblTotalFee.Dock = DockStyle.Fill;
            lblTotalFee.Location = new Point(14, 104);
            lblTotalFee.Name = "lblTotalFee";
            lblTotalFee.Size = new Size(114, 52);
            lblTotalFee.TabIndex = 8;
            lblTotalFee.Text = "Total Fee";
            lblTotalFee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Dock = DockStyle.Fill;
            lblProgram.Location = new Point(14, 52);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(114, 52);
            lblProgram.TabIndex = 7;
            lblProgram.Text = "Program";
            lblProgram.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Location = new Point(14, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(114, 52);
            lblName.TabIndex = 6;
            lblName.Text = "Student Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Dock = DockStyle.Fill;
            dtpPaymentDate.Location = new Point(134, 315);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(671, 31);
            dtpPaymentDate.TabIndex = 17;
            // 
            // lblPaymentDate
            // 
            lblPaymentDate.AutoSize = true;
            lblPaymentDate.Location = new Point(14, 312);
            lblPaymentDate.Name = "lblPaymentDate";
            lblPaymentDate.Size = new Size(108, 43);
            lblPaymentDate.TabIndex = 18;
            lblPaymentDate.Text = "PaymentDate";
            // 
            // nudAmountPaid
            // 
            nudAmountPaid.Dock = DockStyle.Fill;
            nudAmountPaid.Location = new Point(134, 263);
            nudAmountPaid.Name = "nudAmountPaid";
            nudAmountPaid.Size = new Size(671, 31);
            nudAmountPaid.TabIndex = 19;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 520);
            Controls.Add(pnlPayment);
            Name = "PaymentForm";
            Text = "PaymentForm";
            pnlPayment.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            flpbtn.ResumeLayout(false);
            tblProducts.ResumeLayout(false);
            tblProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmountPaid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPayment;
        private Panel pnlMain;
        private FlowLayoutPanel flpbtn;
        private Button btnSave;
        private Button btnCancel;
        private TableLayoutPanel tblProducts;
        private ComboBox cmbStudent;
        private Label lblAmountPaid;
        private Label lblRemaining;
        private Label lblPaidSoFar;
        private Label lblTotalFee;
        private Label lblProgram;
        private Label lblName;
        private TextBox txtTotalFee;
        private TextBox txtProgram;
        private TextBox txtPaidSoFar;
        private TextBox txtRemaining;
        private DateTimePicker dtpPaymentDate;
        private Label lblPaymentDate;
        private NumericUpDown nudAmountPaid;
    }
}