using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Models
{
    public class FeeStructure
    {
        public string Id { get; set; } = string.Empty;
        public string Program { get; set; } = string.Empty;
        public decimal TotalFee { get; set; }
    }
}