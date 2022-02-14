using ExamManager.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Repository.Interface
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        IEnumerable<Student> GetStudentiPaginated(int page);
        Student Get(int? id);
        void Insert(Student entity);
        void Update(Student entity);
        void Delete(Student entity);
    }
}
