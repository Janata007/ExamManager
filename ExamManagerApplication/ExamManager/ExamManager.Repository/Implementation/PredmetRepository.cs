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
            return entities.Include(z=>z.StudiskiCiklus).AsEnumerable();
        }

        public Predmet Get(string kodNaPredmet)
        {
            return entities
                .Include(z => z.PredmetOdStudiskiProgrami)
                .Include(z => z.StudiskiCiklus)
                .Include(z => z.StudentiKoiPolagaatPredmet)
                .SingleOrDefault(z => z.KodNaPredmet == kodNaPredmet);
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

        public IEnumerable<Predmet> FilterByName(string name)
        {
            return this.entities.Where(z => z.ImeNaPredmet.Contains(name)).Include(z=>z.StudiskiCiklus).AsEnumerable();
        }
    }
}
