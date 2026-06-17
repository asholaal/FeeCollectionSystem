
using System.Collections.Generic;
using App.Core.Models;

namespace App.Core.Contracts
{
    public interface IFeeStructureService
    {
        List<FeeStructure> GetAll();
        FeeStructure? GetById(string id);
        FeeStructure? GetByProgram(string program);
        FeeStructure Add(FeeStructure feeStructure);
        bool Update(FeeStructure feeStructure);
        bool Delete(string id);
        List<FeeStructure> Search(string keyword);
    }
}