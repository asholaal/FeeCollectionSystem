using App.Core.Contracts;
using App.Core.Models;
using FeeCollectionApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using App.core.Models;

namespace FeeCollectionApp.Views
{
    public partial class FeeView : UserControl
    {
        private IFeeStructureService _feeService;
        private List<FeeStructure> _allFees;
        private BindingSource _bindingSource = new BindingSource();

        public FeeView(IFeeStructureService feeService)
        {
            InitializeComponent();
            _feeService = feeService;

            SetupDataGridView();
            LoadData();
        }

        private void SetupDataGridView()
        {
            dgvFees.AutoGenerateColumns = false;
            dgvFees.DataSource = _bindingSource;

            // Columns are already defined in designer, set DataPropertyName
            colId.DataPropertyName = "Id";
            colProgram.DataPropertyName = "Program";
            colTotalFee.DataPropertyName = "TotalFee";
        }

        private void LoadData()
        {
            _allFees = _feeService.GetAll();
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            var filtered = _allFees.AsEnumerable();

            // Apply search filter
            if (!string.IsNullOrEmpty(keyword))
            {
                filtered = filtered.Where(f =>
                    (f.Program?.ToLower().Contains(keyword) ?? false));
            }

            var result = filtered.ToList();
            _bindingSource.DataSource = result;

            lblCount.Text = $"Count: {result.Count}";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            using (var form = new FeeForm(_feeService, FormMode.Add))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is FeeStructure selected)
            {
                using (var form = new FeeForm(_feeService, FormMode.Edit, selected))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a fee structure to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is FeeStructure selected)
            {
                using (var form = new FeeForm(_feeService, FormMode.View, selected))
                {
                    form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please select a fee structure to view.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is FeeStructure selected)
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete '{selected.Program}'?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    bool result = _feeService.Delete(selected.Id);
                    if (result)
                    {
                        MessageBox.Show("Fee structure deleted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete fee structure!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a fee structure to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadData();
        }

        private void FeeView_Load(object sender, EventArgs e)
        {
            // Already handled in constructor
        }
    }
}