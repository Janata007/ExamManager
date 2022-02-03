using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExamManager.Domain.DomainModel;
using ExamManager.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace ExamManager.Repository.Implementation
{
    public class StudiskaProgramaRepository : IStudiskaProgramaRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<StudiskaPrograma> entities;

        public StudiskaProgramaRepository(ApplicationDbContext context)
        {
            this.context = context;
            this.entities = context.Set<StudiskaPrograma>();
        }

        public IEnumerable<StudiskaPrograma> GetAll()
        {
            return entities.AsEnumerable();
        }

        public StudiskaPrograma Get(string ImeNaStudiskaPrograma)
        {
            return entities.SingleOrDefault(z => z.ImeNaStudiskaPrograma == ImeNaStudiskaPrograma);
        }

        public void Insert(StudiskaPrograma entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(StudiskaPrograma entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public void Delete(StudiskaPrograma entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

    }
}
