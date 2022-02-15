using ExamManager.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Service.Interface
{
    public interface IStudentService
    {

        List<Student> Getstudents();

        Student GetDetailsForStudent(int? id);

        List<Student> GetStudentiPaginated(int page);
        List<Student> GetDetailsForStudentWithId(List<int> ids);

        void CreateNewStudent(Student s);
        void UpdateStudent(Student s);
        void DeleteStudent(int? id);

    }
}
