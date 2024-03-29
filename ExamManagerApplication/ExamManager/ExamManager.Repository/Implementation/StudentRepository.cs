﻿using ExamManager.Domain.DomainModel;
using ExamManager.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExamManager.Repository.Implementation
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<Student> entities;

        public StudentRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<Student>();
        }

        public IEnumerable<Student> GetAll()
        {
            return entities.AsEnumerable();
        }

        public Student Get(int? id)
        {
            return entities
                .Include(z => z.StudentPolagaPredmeti)
                .SingleOrDefault(z => z.BrojNaIndeks == id);

        }

        public void Insert(Student entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(Student entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public void Delete(Student entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<Student> GetStudentiPaginated(int page)
        {
            int maxRows = 10;
            return entities.OrderBy(z => z.BrojNaIndeks).Skip((page - 1) * maxRows).Take(maxRows).AsEnumerable();
        }

        public IEnumerable<Student> GetDetailsForStudentWithId(List<int> ids)
        {
            return entities.Where(z => ids.Contains(z.BrojNaIndeks)).AsEnumerable();
        }
    }
}
