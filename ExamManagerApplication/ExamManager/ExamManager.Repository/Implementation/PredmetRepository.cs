using ExamManager.Domain.DomainModel;
using ExamManager.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExamManager.Repository.Implementation
{
    public class PredmetRepository : IPredmetRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<Predmet> entities;

        public PredmetRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<Predmet>();
        }

        public IEnumerable<Predmet> GetAll()
        {
            return entities.AsEnumerable();
        }

        public Predmet Get(string id)
        {
            return entities
                .Include(z => z.PredmetOdStudiskiProgrami)
                .Include(z => z.StudiskiCiklus)
                .Include(z => z.PredmetSePolagaVoTermini)
                .Include(z => z.StudentiKoiPolagaatPredmet)
                .SingleOrDefault(z => z.PredmetId == id);
        }

        public void Insert(Predmet entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(Predmet entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public void Delete(Predmet entity)
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
