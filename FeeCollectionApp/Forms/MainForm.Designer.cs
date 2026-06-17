namespace FeeCollectionApp.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlHeader = new Panel();
            flpRight = new FlowLayoutPanel();
            pbUser = new PictureBox();
            lbUser = new Label();
            flpLeft = new FlowLayoutPanel();
            pbLogo = new PictureBox();
            statusStrip1 = new StatusStrip();
            lbStatus = new ToolStripStatusLabel();
            flpNap = new FlowLayoutPanel();
            btnStudents = new Button();
            btnFees = new Button();
            btnPayments = new Button();
            btnDashboard = new Button();
            btnExit = new Button();
            pnlContent = new Panel();
            pnlHeader.SuspendLayout();
            flpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            flpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            statusStrip1.SuspendLayout();
            flpNap.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(flpRight);
            pnlHeader.Controls.Add(flpLeft);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1173, 52);
            pnlHeader.TabIndex = 1;
            // 
            // flpRight
            // 
            flpRight.Controls.Add(pbUser);
            flpRight.Controls.Add(lbUser);
            flpRight.Dock = DockStyle.Right;
            flpRight.Location = new Point(1034, 0);
            flpRight.Margin = new Padding(3, 4, 3, 4);
            flpRight.Name = "flpRight";
            flpRight.Size = new Size(139, 52);
            flpRight.TabIndex = 1;
            // 
            // pbUser
            // 
            pbUser.Image = (Image)resources.GetObject("pbUser.Image");
            pbUser.Location = new Point(3, 4);
            pbUser.Margin = new Padding(3, 4, 3, 4);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(36, 40);
            pbUser.TabIndex = 0;
            pbUser.TabStop = false;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Dock = DockStyle.Right;
            lbUser.Location = new Point(45, 0);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(70, 48);
            lbUser.TabIndex = 1;
            lbUser.Text = "Admin";
            lbUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpLeft
            // 
            flpLeft.Controls.Add(pbLogo);
            flpLeft.Dock = DockStyle.Left;
            flpLeft.Location = new Point(0, 0);
            flpLeft.Margin = new Padding(3, 4, 3, 4);
            flpLeft.Name = "flpLeft";
            flpLeft.Size = new Size(156, 52);
            flpLeft.TabIndex = 0;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(3, 4);
            pbLogo.Margin = new Padding(3, 4, 3, 4);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(36, 40);
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbStatus });
            statusStrip1.Location = new Point(0, 490);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1173, 32);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "Ready";
            // 
            // lbStatus
            // 
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(60, 25);
            lbStatus.Text = "Ready";
            // 
            // flpNap
            // 
            flpNap.Controls.Add(btnStudents);
            flpNap.Controls.Add(btnFees);
            flpNap.Controls.Add(btnPayments);
            flpNap.Controls.Add(btnDashboard);
            flpNap.Controls.Add(btnExit);
            flpNap.Dock = DockStyle.Left;
            flpNap.FlowDirection = FlowDirection.TopDown;
            flpNap.Location = new Point(0, 52);
            flpNap.Margin = new Padding(3, 4, 3, 4);
            flpNap.Name = "flpNap";
            flpNap.Padding = new Padding(11, 0, 0, 0);
            flpNap.Size = new Size(222, 438);
            flpNap.TabIndex = 5;
            // 
            // btnStudents
            // 
            btnStudents.FlatAppearance.BorderSize = 0;
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.Image = (Image)resources.GetObject("btnStudents.Image");
            btnStudents.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudents.Location = new Point(14, 4);
            btnStudents.Margin = new Padding(3, 4, 3, 4);
            btnStudents.Name = "btnStudents";
            btnStudents.Padding = new Padding(11, 0, 0, 0);
            btnStudents.Size = new Size(202, 50);
            btnStudents.TabIndex = 1;
            btnStudents.Text = "Students";
            btnStudents.TextAlign = ContentAlignment.MiddleLeft;
            btnStudents.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnFees
            // 
            btnFees.FlatAppearance.BorderSize = 0;
            btnFees.FlatStyle = FlatStyle.Flat;
            btnFees.Image = (Image)resources.GetObject("btnFees.Image");
            btnFees.ImageAlign = ContentAlignment.MiddleLeft;
            btnFees.Location = new Point(14, 62);
            btnFees.Margin = new Padding(3, 4, 3, 4);
            btnFees.Name = "btnFees";
            btnFees.Padding = new Padding(11, 0, 0, 0);
            btnFees.Size = new Size(202, 50);
            btnFees.TabIndex = 2;
            btnFees.Text = "Fees";
            btnFees.TextAlign = ContentAlignment.MiddleLeft;
            btnFees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFees.UseVisualStyleBackColor = true;
            btnFees.Click += btnFees_Click;
            // 
            // btnPayments
            // 
            btnPayments.FlatAppearance.BorderSize = 0;
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Image = (Image)resources.GetObject("btnPayments.Image");
            btnPayments.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayments.Location = new Point(14, 120);
            btnPayments.Margin = new Padding(3, 4, 3, 4);
            btnPayments.Name = "btnPayments";
            btnPayments.Padding = new Padding(11, 0, 0, 0);
            btnPayments.Size = new Size(202, 50);
            btnPayments.TabIndex = 7;
            btnPayments.Text = "Payments";
            btnPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnPayments.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPayments.UseVisualStyleBackColor = true;
            btnPayments.Click += btnPayments_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(14, 178);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(11, 0, 0, 0);
            btnDashboard.Size = new Size(202, 50);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(14, 236);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(11, 0, 0, 0);
            btnExit.Size = new Size(202, 50);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(222, 52);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(951, 438);
            pnlContent.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 522);
            Controls.Add(pnlContent);
            Controls.Add(flpNap);
            Controls.Add(statusStrip1);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            flpRight.ResumeLayout(false);
            flpRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            flpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            flpNap.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private FlowLayoutPanel flpRight;
        private PictureBox pbUser;
        private Label lbUser;
        private FlowLayoutPanel flpLeft;
        private PictureBox pbLogo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbStatus;
        private FlowLayoutPanel flpNap;
        private Button btnDashboard;
        private Button btnStudents;
        private Button btnFees;
        private Button btnPayments;
        private Button btnExit;
        private Panel pnlContent;
    }
}