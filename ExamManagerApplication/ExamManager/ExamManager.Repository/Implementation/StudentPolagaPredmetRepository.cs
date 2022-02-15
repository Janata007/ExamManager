using ExamManager.Domain.DomainModel;
using ExamManager.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamManager.Repository.Implementation
{
    public class StudentPolagaPredmetRepository : IStudentPolagaPredmetRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<StudentPolagaPredmet> entities;
        public StudentPolagaPredmetRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<StudentPolagaPredmet>();
        }
        public IEnumerable<StudentPolagaPredmet> GetAll()
        {
            return entities.AsEnumerable();

        }

        public IEnumerable<StudentPolagaPredmet> GetAllPredmetiForStudent(int id)
        {
            return entities.Where(z => z.BrojNaIndeks == id).AsEnumerable();
        }

        public void Insert(StudentPolagaPredmet entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }
    }
}
