using ExamManager.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Service.Interface
{
    public interface IStudentPolagaPredmetService
    {
        List<StudentPredmetDTO> GetAll();
    }
}
