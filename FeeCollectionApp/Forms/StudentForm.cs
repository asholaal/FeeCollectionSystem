using App.Core.Contracts;
using App.Core.Models;
using System;
using System.Windows.Forms;
using App.core.Models;
namespace FeeCollectionApp.Forms
{
    public partial class StudentForm : Form
    {
        IStudentService _studentService;
        IFeeStructureService _feeService;
        FormMode _mode;
        Student _student;

        // Add mode
        public StudentForm(IStudentService studentService, IFeeStructureService feeService, FormMode mode)
        {
            InitializeComponent();
            _studentService = studentService;
            _feeService = feeService;
            _mode = mode;
            _student = new Student();
            SetupForm();
        }

        // Edit/View mode
        public StudentForm(IStudentService studentService, IFeeStructureService feeService, FormMode mode, Student student)
        {
            InitializeComponent();
            _studentService = studentService;
            _feeService = feeService;
            _mode = mode;
            _student = student;
            SetupForm();
            LoadStudentData();
        }

        private void SetupForm()
        {
            // Load programs from FeeStructure table
            var programs = _feeService.GetAll();
            cmbProgram.Items.Clear();
            foreach (var p in programs)
            {
                cmbProgram.Items.Add(p.Program);
            }

            switch (_mode)
            {
                case FormMode.Add:
                    this.Text = "Add Student";
                    txtId.Visible = false;
                    lblId.Visible = false;
                    break;
                case FormMode.Edit:
                    this.Text = "Edit Student";
                    txtId.Visible = true;
                    lblId.Visible = true;
                    break;
                case FormMode.View:
                    this.Text = "View Student";
                    txtId.Visible = true;
                    lblId.Visible = true;
                    MakeReadOnly();
                    break;
            }
        }

        private void LoadStudentData()
        {
            txtId.Text = _student.Id;
            txtRollNo.Text = _student.RollNo;
            txtFullName.Text = _student.FullName;
            txtContactNo.Text = _student.ContactNo;
            cmbProgram.Text = _student.Program;
        }

        private void MakeReadOnly()
        {
            txtRollNo.ReadOnly = true;
            txtFullName.ReadOnly = true;
            cmbProgram.Enabled = false;
            txtContactNo.ReadOnly = true;
            btnSave.Visible = false;
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtRollNo.Text))
            {
                MessageBox.Show("Roll No is required");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Name is required");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmbProgram.Text))
            {
                MessageBox.Show("Select a program");
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateData()) return;

                _student.RollNo = txtRollNo.Text.Trim();
                _student.FullName = txtFullName.Text.Trim();
                _student.Program = cmbProgram.Text.Trim();
                _student.ContactNo = txtContactNo.Text.Trim();

                if (_mode == FormMode.Add)
                {
                    var result = _studentService.Add(_student);
                    if (result != null)
                    {
                        MessageBox.Show("Student added successfully");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    bool result = _studentService.Update(_student);
                    if (result)
                    {
                        MessageBox.Show("Student updated successfully");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}