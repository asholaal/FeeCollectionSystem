using System;
using System.Collections.Generic;
using System.Text;


using App.Core.Models;

namespace App.Core.Contracts
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student? GetById(string id);
        Student Add(Student student);
        bool Update(Student student);
        bool Delete(string id);
        List<Student> Search(string keyword);
        List<string> GetPrograms();
    }
}