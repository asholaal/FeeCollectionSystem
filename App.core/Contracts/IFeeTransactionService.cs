using System.Collections.Generic;
using App.Core.Models;

namespace App.Core.Contracts
{
    public interface IFeeTransactionService
    {
        List<FeeTransaction> GetAll();
        FeeTransaction? GetById(string receiptNo);
        List<FeeTransaction> GetByStudentId(string studentId);
        FeeTransaction Add(FeeTransaction transaction);
        bool Delete(string receiptNo);
    }
}