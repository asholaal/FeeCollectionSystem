using App.Core.Contracts;
using App.Core.Models;
using System;
using System.Windows.Forms;
using App.core.Models;

namespace FeeCollectionApp.Forms
{
    public partial class FeeForm : Form
    {
        private IFeeStructureService _feeService;
        private FormMode _mode;
        private FeeStructure _feeStructure;

        // Constructor for Add mode
        public FeeForm(IFeeStructureService service, FormMode mode)
        {
            InitializeComponent();
            _feeService = service;
            _mode = mode;
            _feeStructure = new FeeStructure();
            SetupForm();
        }

        // Constructor for Edit/View mode
        public FeeForm(IFeeStructureService service, FormMode mode, FeeStructure feeStructure)
        {
            InitializeComponent();
            _feeService = service;
            _mode = mode;
            _feeStructure = feeStructure;
            SetupForm();
            LoadFeeData();
        }

        private void SetupForm()
        {
            // Setup NumericUpDown
            nudTotalFee.Minimum = 0;
            nudTotalFee.Maximum = 9999999;
            nudTotalFee.DecimalPlaces = 2;

            switch (_mode)
            {
                case FormMode.Add:
                    this.Text = "Add Fee Structure";
                    txtId.Visible = false;
                    lblId.Visible = false;
                    btnSave.Visible = true;
                    break;
                case FormMode.Edit:
                    this.Text = "Edit Fee Structure";
                    txtId.Visible = true;
                    lblId.Visible = true;
                    btnSave.Visible = true;
                    break;
                case FormMode.View:
                    this.Text = "View Fee Structure";
                    txtId.Visible = true;
                    lblId.Visible = true;
                    btnSave.Visible = false;
                    MakeReadOnly();
                    break;
            }
        }

        private void LoadFeeData()
        {
            txtId.Text = _feeStructure.Id;
            txtProgram.Text = _feeStructure.Program;
            nudTotalFee.Value = _feeStructure.TotalFee;
        }

        private void MakeReadOnly()
        {
            txtProgram.ReadOnly = true;
            nudTotalFee.Enabled = false;
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtProgram.Text))
            {
                MessageBox.Show("Program name is required!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nudTotalFee.Value <= 0)
            {
                MessageBox.Show("Please enter a valid total fee (greater than 0)!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateData())
                    return;

                _feeStructure.Program = txtProgram.Text.Trim();
                _feeStructure.TotalFee = nudTotalFee.Value;

                if (_mode == FormMode.Add)
                {
                    var result = _feeService.Add(_feeStructure);
                    if (result != null)
                    {
                        MessageBox.Show("Fee structure added successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Failed to add fee structure!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    bool result = _feeService.Update(_feeStructure);
                    if (result)
                    {
                        MessageBox.Show("Fee structure updated successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Failed to update fee structure!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}