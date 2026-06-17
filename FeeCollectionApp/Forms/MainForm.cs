using App.Core.Contracts;
using App.Core.Services;
using FeeCollectionApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FeeCollectionApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly IStudentService _studentService;
        private readonly IFeeStructureService _feeStructureService;
        private readonly IFeeTransactionService _transactionService;
        private readonly IStudentAccountService _accountService;



        public MainForm()

        {
            InitializeComponent();
            string connString =
                ConfigurationManager
                .ConnectionStrings["FeeDbConnection"]
                .ConnectionString;

            // Service Object
            _studentService = new DbStudentService(connString);
            _feeStructureService = new DbFeeStructureService(connString);
            _transactionService = new DbFeeTransactionService(connString);
            _accountService = new DbStudentAccountService(connString);


        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnStudents_Click(object sender, EventArgs e)
        {


            pnlContent.Controls.Clear();
            StudentView view = new StudentView(_studentService, _feeStructureService);
            view.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(view);

        }

        private void btnFees_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            FeeView view = new FeeView(_feeStructureService);
            view.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(view);
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            PaymentView view = new PaymentView(
                _studentService,
                _feeStructureService,
                _accountService,
                _transactionService);
            view.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(view);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            DashboardView view = new DashboardView(_accountService, _transactionService, _studentService);
            view.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(view);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to exit?",
            "Confirm Exit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
