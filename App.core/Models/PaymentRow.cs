using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Models
{
    public class PaymentRow
    {
        public string RollNo { get; set; }

        public string StudentName { get; set; }

        public string Program { get; set; }

        public decimal TotalFee { get; set; }

        public decimal PaidFee { get; set; }

        public decimal Remaining { get; set; }

        public string Status { get; set; }
    }
}
