using App.Core.Contracts;
using App.Core.Models;
using FeeCollectionApp.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using App.core.Models;
namespace FeeCollectionApp.Views
{
    public partial class StudentView : UserControl
    {
        IStudentService _studentService;
        IFeeStructureService _feeService;
        List<Student> _allStudents;
        BindingSource bs = new BindingSource();

        public StudentView(IStudentService studentService, IFeeStructureService feeService)
        {
            InitializeComponent();
            _studentService = studentService;
            _feeService = feeService;
            LoadData();
            LoadProgramFilter();
        }

        void LoadData()
        {
            _allStudents = _studentService.GetAll();
            bs.DataSource = _allStudents;
            dgvStudents.DataSource = bs;
            lblCount.Text = "Count: " + _allStudents.Count;
        }

        void LoadProgramFilter()
        {
            var programs = _feeService.GetAll();
            cmbProgram.Items.Clear();
            cmbProgram.Items.Add("All");
            foreach (var p in programs)
            {
                cmbProgram.Items.Add(p.Program);
            }
            cmbProgram.SelectedIndex = 0;
        }

        void FilterData()
        {
            string search = txtSearch.Text.ToLower();
            string program = cmbProgram.SelectedItem.ToString();

            List<Student> filtered = new List<Student>();

            foreach (var s in _allStudents)
            {
                bool match = true;

                if (search != "")
                {
                    if (!s.FullName.ToLower().Contains(search) &&
                        !s.RollNo.ToLower().Contains(search) &&
                        !s.Program.ToLower().Contains(search))
                    {
                        match = false;
                    }
                }

                if (program != "All")
                {
                    if (s.Program != program)
                    {
                        match = false;
                    }
                }

                if (match)
                {
                    filtered.Add(s);
                }
            }

            bs.DataSource = filtered;
            lblCount.Text = "Count: " + filtered.Count;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cmbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm(_studentService, _feeService, FormMode.Add);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                FilterData();
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (bs.Current is Student s)
            {
                StudentForm form = new StudentForm(_studentService, _feeService, FormMode.Edit, s);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                    FilterData();
                }
            }
            else
            {
                MessageBox.Show("Select a record first");
            }
        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            if (bs.Current is Student s)
            {
                StudentForm form = new StudentForm(_studentService, _feeService, FormMode.View, s);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a record first");
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (bs.Current is Student s)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + s.FullName + "?", "Confirm", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    bool result = _studentService.Delete(s.Id);
                    if (result)
                    {
                        MessageBox.Show("Deleted successfully");
                        LoadData();
                        FilterData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a record first");
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cmbProgram.SelectedIndex = 0;
            LoadData();
        }

        
    }
}