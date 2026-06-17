using System.Collections.Generic;
using App.Core.Models;

namespace App.Core.Contracts
{
    public interface IStudentAccountService
    {
        List<StudentAccount> GetAll();
        StudentAccount? GetByStudentId(string studentId);
        StudentAccount CreateAccount(string studentId, decimal totalFee);
        bool UpdatePaidFee(string studentId, decimal amount);
    }
}