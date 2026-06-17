
using App.Core.Contracts;
using App.Core.Models;
using FeeCollectionApp.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FeeCollectionApp.Views
{
    public partial class PaymentView : UserControl
    {
        private readonly IStudentService _studentService;
        private readonly IFeeStructureService _feeService;
        private readonly IStudentAccountService _accountService;
        private readonly IFeeTransactionService _transactionService;

        private List<object> paymentList = new List<object>();

        public PaymentView(
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

            SetupStatusCombo();
            LoadData();
        }

       
        // ComboBox Setup
     

        void SetupStatusCombo()
        {
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbStatus.Items.Add("All");
            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("Cleared");

            cmbStatus.SelectedIndex = 0;
        }

         //Load Data
        
        void LoadData()
        {
            paymentList.Clear();

            var accounts = _accountService.GetAll();
            var students = _studentService.GetAll();

            foreach (var account in accounts)
            {
                var student = students
                    .FirstOrDefault(x => x.Id == account.StudentId);

                if (student == null)
                    continue;

                decimal remaining =
                    account.TotalFee - account.PaidFee;

                paymentList.Add(new
                {
                    student.RollNo,
                    StudentName = student.FullName,
                    student.Program,

                    account.TotalFee,
                    account.PaidFee,

                    Remaining = remaining,

                    Status = remaining <= 0
                        ? "Cleared"
                        : "Pending"
                });
            }

            dgvPayments.DataSource = null;
            dgvPayments.DataSource = paymentList;

            lblCount.Text =
                "Count: " + paymentList.Count;
        }

        
        // Filter
        

        void FilterData()
        {
            string search =
                txtSearch.Text.ToLower();

            string status =
                cmbStatus.Text;

            var filtered = paymentList
                .Where(x =>
                {
                    dynamic d = x;

                    bool searchMatch =

                        d.RollNo.ToString().ToLower().Contains(search)

                        ||

                        d.StudentName.ToString().ToLower().Contains(search)

                        ||

                        d.Program.ToString().ToLower().Contains(search);

                    bool statusMatch =

                        status == "All"

                        ||

                        d.Status.ToString() == status;

                    return searchMatch && statusMatch;
                })
                .ToList();

            dgvPayments.DataSource = null;
            dgvPayments.DataSource = filtered;

            lblCount.Text =
                "Count: " + filtered.Count;
        }

      
        // Search + Filter Events
        

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        // Add
        

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            PaymentForm form = new PaymentForm(
                _studentService,
                _feeService,
                _accountService,
                _transactionService);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        
        // View
        
        private void tsbView_Click(object sender, EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select record first");
                return;
            }

            string rollNo =
                dgvPayments.SelectedRows[0].Cells[0].Value.ToString();




            var student = _studentService.GetAll()
                .FirstOrDefault(s => s.RollNo == rollNo);

            if (student == null)
            {
                MessageBox.Show("Student not found");
                return;
            }

            var account = _accountService.GetAll()
                .FirstOrDefault(a => a.StudentId == student.Id);

            if (account == null)
            {
                MessageBox.Show("Account not found");
                return;
            }

            PaymentForm form = new PaymentForm(
                _studentService,
                _feeService,
                _accountService,
                _transactionService,
                account,
                true);

            form.ShowDialog();
        }

        
        // Edit
       
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select record first");
                return;
            }

            string status = dgvPayments.SelectedRows[0].Cells[6].Value.ToString();





            if (status != "Pending")
            {
                MessageBox.Show(
                    "Only Pending payment can be edited");

                return;
            }

            PaymentForm form = new PaymentForm(
                _studentService,
                _feeService,
                _accountService,
                _transactionService);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        
        // Delete
       
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Can't delete payment record");
        }

        

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            cmbStatus.SelectedIndex = 0;

            LoadData();
        }
    }
}


