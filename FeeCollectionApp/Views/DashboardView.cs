using App.Core.Contracts;
using App.Core.Models;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FeeCollectionApp.Views
{
    public partial class DashboardView : UserControl
    {
        IStudentAccountService _accountService;
        IFeeTransactionService _transactionService;
        IStudentService _studentService;

        public DashboardView(
            IStudentAccountService accountService,
            IFeeTransactionService transactionService,
            IStudentService studentService)
        {
            InitializeComponent();
            _accountService = accountService;
            _transactionService = transactionService;
            _studentService = studentService;
            LoadDashboard();
        }

        void LoadDashboard()
        {
            var accounts = _accountService.GetAll();
            var students = _studentService.GetAll();
            var transactions = _transactionService.GetAll();

            // ---------- SUMMARY CARDS ----------
            int totalStudents = students.Count;
            decimal totalCollected = 0;
            decimal totalPending = 0;
            int clearedCount = 0;

            for (int i = 0; i < accounts.Count; i++)
            {
                totalCollected = totalCollected + accounts[i].PaidFee;
                decimal remaining = accounts[i].TotalFee - accounts[i].PaidFee;
                totalPending = totalPending + remaining;

                if (remaining <= 0)
                {
                    clearedCount++;
                }
            }

            lblStudentsValue.Text = totalStudents.ToString();
            lblCollectedValue.Text = totalCollected.ToString("N0") + " PKR";
            lblPendingValue.Text = totalPending.ToString("N0") + " PKR";
            lblClearedValue.Text = clearedCount.ToString();

            // Clear old charts
            pnlCharts.Controls.Clear();

            // ---------- CHART 1: Program-wise Collection (Bar Chart) ----------
            var programData = new Dictionary<string, decimal>();

            for (int i = 0; i < accounts.Count; i++)
            {
                var a = accounts[i];
                string program = "";

                for (int j = 0; j < students.Count; j++)
                {
                    if (students[j].Id == a.StudentId)
                    {
                        program = students[j].Program;
                        break;
                    }
                }

                if (program != "")
                {
                    if (programData.ContainsKey(program))
                    {
                        programData[program] = programData[program] + a.PaidFee;
                    }
                    else
                    {
                        programData[program] = a.PaidFee;
                    }
                }
            }

            var programNames = new List<string>();
            var programValues = new List<decimal>();

            foreach (var kvp in programData)
            {
                programNames.Add(kvp.Key);
                programValues.Add(kvp.Value);
            }

            // Panel for Chart 1 with Title
            Panel panel1 = new Panel();
            panel1.Location = new System.Drawing.Point(15, 15);
            panel1.Size = new System.Drawing.Size(500, 360);
            panel1.BackColor = System.Drawing.Color.White;

            Label lblTitle1 = new Label();
            lblTitle1.Text = "📊 Program-wise Fee Collection";
            lblTitle1.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblTitle1.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle1.Location = new System.Drawing.Point(10, 10);
            lblTitle1.Size = new System.Drawing.Size(480, 35);
            lblTitle1.TextAlign = ContentAlignment.MiddleCenter;

            // Chart 1 - Bar Chart
            var chart1 = new CartesianChart();
            chart1.Location = new System.Drawing.Point(10, 50);
            chart1.Size = new System.Drawing.Size(480, 290);
            chart1.BackColor = System.Drawing.Color.White;

            chart1.Series = new ISeries[]
            {
                new ColumnSeries<decimal>
                {
                    Values = programValues.ToArray(),
                    Name = "Collected Amount",
                    Fill = new SolidColorPaint(new SKColor(52, 152, 219))
                }
            };

            chart1.XAxes = new[]
            {
                new Axis {
                    Labels = programNames.ToArray()
                }
            };

            chart1.YAxes = new[]
            {
                new Axis {
                    Name = "Amount (PKR)"
                }
            };

            panel1.Controls.Add(lblTitle1);
            panel1.Controls.Add(chart1);

            // ---------- CHART 2: Monthly Collection (Line Chart) ----------
            var monthlyData = new Dictionary<string, decimal>();

            for (int i = 0; i < transactions.Count; i++)
            {
                var t = transactions[i];
                string monthKey = t.PaymentDate.ToString("MMM yyyy");

                if (monthlyData.ContainsKey(monthKey))
                {
                    monthlyData[monthKey] = monthlyData[monthKey] + t.AmountPaid;
                }
                else
                {
                    monthlyData[monthKey] = t.AmountPaid;
                }
            }

            var monthNames = new List<string>();
            var monthValues = new List<decimal>();

            foreach (var kvp in monthlyData)
            {
                monthNames.Add(kvp.Key);
                monthValues.Add(kvp.Value);
            }

            // Panel for Chart 2 with Title
            Panel panel2 = new Panel();
            panel2.Location = new System.Drawing.Point(530, 15);
            panel2.Size = new System.Drawing.Size(500, 360);
            panel2.BackColor = System.Drawing.Color.White;

            Label lblTitle2 = new Label();
            lblTitle2.Text = "📈 Monthly Collection Trend";
            lblTitle2.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblTitle2.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle2.Location = new System.Drawing.Point(10, 10);
            lblTitle2.Size = new System.Drawing.Size(480, 35);
            lblTitle2.TextAlign = ContentAlignment.MiddleCenter;

            // Chart 2 - Line Chart
            var chart2 = new CartesianChart();
            chart2.Location = new System.Drawing.Point(10, 50);
            chart2.Size = new System.Drawing.Size(480, 290);
            chart2.BackColor = System.Drawing.Color.White;

            chart2.Series = new ISeries[]
            {
                new LineSeries<decimal>
                {
                    Values = monthValues.ToArray(),
                    Name = "Monthly Collection",
                    Fill = null,
                    Stroke = new SolidColorPaint(new SKColor(46, 204, 113), 3)
                }
            };

            chart2.XAxes = new[]
            {
                new Axis {
                    Labels = monthNames.ToArray()
                }
            };

            chart2.YAxes = new[]
            {
                new Axis {
                    Name = "Amount (PKR)"
                }
            };

            panel2.Controls.Add(lblTitle2);
            panel2.Controls.Add(chart2);

            // Add both panels to main panel
            pnlCharts.Controls.Add(panel1);
            pnlCharts.Controls.Add(panel2);
        }
    }
}