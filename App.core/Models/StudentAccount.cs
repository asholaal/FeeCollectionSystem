using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Models
{
    public class StudentAccount
    {
        public string Id { get; set; } = string.Empty;
        public string StudentId { get; set; } = string.Empty;
        public string RollNo { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
        public string Program { get; set; } = string.Empty;
        public decimal TotalFee { get; set; }
        public decimal PaidFee { get; set; }
        public decimal RemainingFee => TotalFee - PaidFee;
        public string Status => RemainingFee <= 0 ? "Cleared" : "Pending";
    }
}