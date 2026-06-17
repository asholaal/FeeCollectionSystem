using System;
using System.Collections.Generic;
using System.Text;
using System;



namespace App.Core.Models
{
    public class FeeTransaction
    {
        public string ReceiptNo { get; set; } = string.Empty;
        public string StudentId { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
        public decimal AmountPaid { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}