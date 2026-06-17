namespace FeeCollectionApp.Views
{
    partial class DashboardView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            flpCards = new FlowLayoutPanel();
            cardStudents = new Panel();
            lblStudents = new Label();
            lblStudentsValue = new Label();
            cardCollected = new Panel();
            lblCollected = new Label();
            lblCollectedValue = new Label();
            cardPending = new Panel();
            lblPending = new Label();
            lblPendingValue = new Label();
            cardCleared = new Panel();
            lblCleared = new Label();
            lblClearedValue = new Label();
            pnlCharts = new Panel();
            flpCards.SuspendLayout();
            cardStudents.SuspendLayout();
            cardCollected.SuspendLayout();
            cardPending.SuspendLayout();
            cardCleared.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(23, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(299, 52);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📊 Dashboard";
            // 
            // flpCards
            // 
            flpCards.BackColor = Color.Transparent;
            flpCards.Controls.Add(cardStudents);
            flpCards.Controls.Add(cardCollected);
            flpCards.Controls.Add(cardPending);
            flpCards.Controls.Add(cardCleared);
            flpCards.Location = new Point(20, 84);
            flpCards.Name = "flpCards";
            flpCards.Size = new Size(1060, 114);
            flpCards.TabIndex = 1;
            // 
            // cardStudents
            // 
            cardStudents.BackColor = Color.FromArgb(52, 152, 219);
            cardStudents.BorderStyle = BorderStyle.FixedSingle;
            cardStudents.Controls.Add(lblStudents);
            cardStudents.Controls.Add(lblStudentsValue);
            cardStudents.Location = new Point(3, 3);
            cardStudents.Name = "cardStudents";
            cardStudents.Padding = new Padding(10);
            cardStudents.Size = new Size(240, 101);
            cardStudents.TabIndex = 0;
            // 
            // lblStudents
            // 
            lblStudents.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStudents.ForeColor = Color.White;
            lblStudents.Location = new Point(10, 10);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new Size(220, 30);
            lblStudents.TabIndex = 0;
            lblStudents.Text = "👨‍🎓 Total Students";
            lblStudents.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStudentsValue
            // 
            lblStudentsValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentsValue.ForeColor = Color.White;
            lblStudentsValue.Location = new Point(10, 40);
            lblStudentsValue.Name = "lblStudentsValue";
            lblStudentsValue.Size = new Size(220, 50);
            lblStudentsValue.TabIndex = 1;
            lblStudentsValue.Text = "0";
            lblStudentsValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardCollected
            // 
            cardCollected.BackColor = Color.FromArgb(46, 204, 113);
            cardCollected.BorderStyle = BorderStyle.FixedSingle;
            cardCollected.Controls.Add(lblCollected);
            cardCollected.Controls.Add(lblCollectedValue);
            cardCollected.Location = new Point(249, 3);
            cardCollected.Name = "cardCollected";
            cardCollected.Padding = new Padding(10);
            cardCollected.Size = new Size(240, 101);
            cardCollected.TabIndex = 1;
            // 
            // lblCollected
            // 
            lblCollected.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCollected.ForeColor = Color.White;
            lblCollected.Location = new Point(10, 10);
            lblCollected.Name = "lblCollected";
            lblCollected.Size = new Size(220, 30);
            lblCollected.TabIndex = 0;
            lblCollected.Text = "💰 Total Collected";
            lblCollected.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCollectedValue
            // 
            lblCollectedValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCollectedValue.ForeColor = Color.White;
            lblCollectedValue.Location = new Point(10, 40);
            lblCollectedValue.Name = "lblCollectedValue";
            lblCollectedValue.Size = new Size(220, 50);
            lblCollectedValue.TabIndex = 1;
            lblCollectedValue.Text = "0 PKR";
            lblCollectedValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardPending
            // 
            cardPending.BackColor = Color.FromArgb(231, 76, 60);
            cardPending.BorderStyle = BorderStyle.FixedSingle;
            cardPending.Controls.Add(lblPending);
            cardPending.Controls.Add(lblPendingValue);
            cardPending.Location = new Point(495, 3);
            cardPending.Name = "cardPending";
            cardPending.Padding = new Padding(10);
            cardPending.Size = new Size(240, 101);
            cardPending.TabIndex = 2;
            // 
            // lblPending
            // 
            lblPending.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPending.ForeColor = Color.White;
            lblPending.Location = new Point(10, 10);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(220, 30);
            lblPending.TabIndex = 0;
            lblPending.Text = "⏳ Total Pending";
            lblPending.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPendingValue
            // 
            lblPendingValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingValue.ForeColor = Color.White;
            lblPendingValue.Location = new Point(10, 39);
            lblPendingValue.Name = "lblPendingValue";
            lblPendingValue.Size = new Size(220, 49);
            lblPendingValue.TabIndex = 1;
            lblPendingValue.Text = "0 PKR";
            lblPendingValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardCleared
            // 
            cardCleared.BackColor = Color.FromArgb(155, 89, 182);
            cardCleared.BorderStyle = BorderStyle.FixedSingle;
            cardCleared.Controls.Add(lblCleared);
            cardCleared.Controls.Add(lblClearedValue);
            cardCleared.Location = new Point(741, 3);
            cardCleared.Name = "cardCleared";
            cardCleared.Padding = new Padding(10);
            cardCleared.Size = new Size(240, 101);
            cardCleared.TabIndex = 3;
            // 
            // lblCleared
            // 
            lblCleared.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCleared.ForeColor = Color.White;
            lblCleared.Location = new Point(10, 10);
            lblCleared.Name = "lblCleared";
            lblCleared.Size = new Size(220, 30);
            lblCleared.TabIndex = 0;
            lblCleared.Text = "✅ Cleared Students";
            lblCleared.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblClearedValue
            // 
            lblClearedValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClearedValue.ForeColor = Color.White;
            lblClearedValue.Location = new Point(10, 39);
            lblClearedValue.Name = "lblClearedValue";
            lblClearedValue.Size = new Size(220, 50);
            lblClearedValue.TabIndex = 1;
            lblClearedValue.Text = "0";
            lblClearedValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCharts
            // 
            pnlCharts.BackColor = Color.White;
            pnlCharts.BorderStyle = BorderStyle.FixedSingle;
            pnlCharts.Location = new Point(20, 220);
            pnlCharts.Name = "pnlCharts";
            pnlCharts.Size = new Size(1060, 400);
            pnlCharts.TabIndex = 2;
            // 
            // DashboardView
            // 
            BackColor = Color.FromArgb(240, 242, 245);
            Controls.Add(lblTitle);
            Controls.Add(flpCards);
            Controls.Add(pnlCharts);
            Name = "DashboardView";
            Size = new Size(1120, 680);
            flpCards.ResumeLayout(false);
            cardStudents.ResumeLayout(false);
            cardCollected.ResumeLayout(false);
            cardPending.ResumeLayout(false);
            cardCleared.ResumeLayout(false);
            ResumeLayout(false);
        }

        // Control declarations
        private Label lblTitle;
        private FlowLayoutPanel flpCards;
        private Panel pnlCharts;

        private Panel cardStudents;
        private Label lblStudents;
        private Label lblStudentsValue;

        private Panel cardCollected;
        private Label lblCollected;
        private Label lblCollectedValue;

        private Panel cardPending;
        private Label lblPending;
        private Label lblPendingValue;

        private Panel cardCleared;
        private Label lblCleared;
        private Label lblClearedValue;
    }
}