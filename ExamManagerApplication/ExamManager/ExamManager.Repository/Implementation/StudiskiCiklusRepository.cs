using ExamManager.Domain.DomainModel;
using ExamManager.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ExamManager.Repository.Implementation
{
    public class StudiskiCiklusRepository : IStudiskiCiklusRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<StudiskiCiklus> entities;

        public StudiskiCiklusRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<StudiskiCiklus>();
        }

        public IEnumerable<StudiskiCiklus> GetAll()
        {
            return entities.AsEnumerable();
        }

        public StudiskiCiklus Get(string id)
        {
            return entities
                .Include(z=>z.PredmetiOdStudiskiCiklus)
                .SingleOrDefault(z => z.CiklusNaStudii == id);
        }

        public void Insert(StudiskiCiklus entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(StudiskiCiklus entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public void Delete(StudiskiCiklus entity)
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
