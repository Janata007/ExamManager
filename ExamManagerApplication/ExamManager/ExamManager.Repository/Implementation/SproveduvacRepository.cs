using ExamManager.Domain.DomainModel;
using ExamManager.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExamManager.Repository.Implementation
{
    public class SproveduvacRepository : ISproveduvacRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<Sproveduvac> entities;

        public SproveduvacRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<Sproveduvac>();
        }

        public IEnumerable<Sproveduvac> GetAll()
        {
            return entities.AsEnumerable();
        }

        public Sproveduvac Get(string id)
        {
            return entities
                .SingleOrDefault(z => z.SproveduvacId == id);
        }

        public void Insert(Sproveduvac entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(Sproveduvac entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public void Delete(Sproveduvac entity)
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
