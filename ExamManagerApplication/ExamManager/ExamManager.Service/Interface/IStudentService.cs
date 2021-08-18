using ExamManager.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Service.Interface
{
    interface IStudentService
    {

        List<Student> GetAllStudents();

        Student GetDetailsForStudent(int? id);

        void CreateNewStudent(Student s);
        void UpdateStudent(Student s);
        void DeleteStudent(int? id);

    }
}
