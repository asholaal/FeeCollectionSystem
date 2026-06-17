using App.Core.Contracts;
using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FeeCollectionApp.Forms
{
    public partial class PaymentForm : Form
    {
        IStudentService _studentService;
        IFeeStructureService _feeService;
        IStudentAccountService _accountService;
        IFeeTransactionService _transactionService;

        List<Student> _students;
        List<FeeStructure> _fees;

        Student _selectedStudent;
        StudentAccount _selectedAccount;
        bool _isViewMode = false;

        // ADD mode
        public PaymentForm(
            IStudentService studentService,
            IFeeStructureService feeService,
            IStudentAccountService accountService,
            IFeeTransactionService transactionService)
        {
            InitializeComponent();

            _studentService = studentService;
            _feeService = feeService;
            _accountService = accountService;
            _transactionService = transactionService;
            _isViewMode = false;

            cmbStudent.SelectedIndexChanged += cmbStudent_SelectedIndexChanged;
            LoadStudents();
        }

        // VIEW mode
        public PaymentForm(
            IStudentService studentService,
            IFeeStructureService feeService,
            IStudentAccountService accountService,
            IFeeTransactionService transactionService,
            StudentAccount account,
            bool isViewMode)
        {
            InitializeComponent();

            _studentService = studentService;
            _feeService = feeService;
            _accountService = accountService;
            _transactionService = transactionService;
            _isViewMode = true;
            _selectedAccount = account;

            _fees = _feeService.GetAll(); 
            LoadStudentsForView(account);
            MakeReadOnly();
        }

        void LoadStudents()
        {
            _students = _studentService.GetAll();
            _fees = _feeService.GetAll();

            cmbStudent.DataSource = _students;
            cmbStudent.DisplayMember = "FullName";
            cmbStudent.ValueMember = "Id";
        }

        void LoadStudentsForView(StudentAccount account)
        {
            var student = _studentService.GetAll().FirstOrDefault(s => s.Id == account.StudentId);
            if (student == null) return;

            cmbStudent.DataSource = new List<Student> { student };
            cmbStudent.DisplayMember = "FullName";
            cmbStudent.ValueMember = "Id";
            cmbStudent.SelectedIndex = 0;

            _selectedStudent = student;

            var fee = _fees.FirstOrDefault(x => x.Program == student.Program);
            decimal totalFee = fee != null ? fee.TotalFee : account.TotalFee;

            txtProgram.Text = student.Program;
            txtTotalFee.Text = totalFee.ToString("F2");
            txtPaidSoFar.Text = account.PaidFee.ToString("F2");
            txtRemaining.Text = (totalFee - account.PaidFee).ToString("F2");
        }

        void MakeReadOnly()
        {
            cmbStudent.Enabled = false;
            nudAmountPaid.Enabled = false;
            dtpPaymentDate.Enabled = false;
            btnSave.Visible = false;
            this.Text = "View Payment Details";
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isViewMode || cmbStudent.SelectedItem == null) return;

            _selectedStudent = (Student)cmbStudent.SelectedItem;
            txtProgram.Text = _selectedStudent.Program;

            var fee = _fees.FirstOrDefault(x => x.Program == _selectedStudent.Program);
            decimal totalFee = fee != null ? fee.TotalFee : 0;
            txtTotalFee.Text = totalFee.ToString();

            _selectedAccount = _accountService.GetByStudentId(_selectedStudent.Id);
            decimal paid = _selectedAccount != null ? _selectedAccount.PaidFee : 0;
            txtPaidSoFar.Text = paid.ToString();

            decimal remaining = totalFee - paid;
            txtRemaining.Text = remaining.ToString();
            nudAmountPaid.Maximum = remaining > 0 ? remaining : 0;

            if (remaining <= 0)
            {
                MessageBox.Show("Payment already cleared for this student!", "Already Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nudAmountPaid.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                nudAmountPaid.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_isViewMode) return;

            if (_selectedStudent == null) { MessageBox.Show("Select student"); return; }

            decimal amount = nudAmountPaid.Value;
            if (amount <= 0) { MessageBox.Show("Enter valid amount"); return; }

            FeeTransaction t = new FeeTransaction();
            t.ReceiptNo = "TRX-" + Guid.NewGuid().ToString("N").Substring(0, 6);
            t.StudentId = _selectedStudent.Id;
            t.AmountPaid = amount;
            t.PaymentDate = dtpPaymentDate.Value;

            _transactionService.Add(t);

            if (_selectedAccount == null)
            {
                decimal totalFee = Convert.ToDecimal(txtTotalFee.Text);
                _accountService.CreateAccount(_selectedStudent.Id, totalFee);
            }
            _accountService.UpdatePaidFee(_selectedStudent.Id, amount);

            MessageBox.Show("Payment saved!");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}