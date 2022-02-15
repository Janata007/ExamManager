using ExamManager.Domain.DomainModel;
using ExamManager.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamManager.Repository.Implementation
{
    public class IspitRepository : IIspitRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<Ispit> entities;

        public IspitRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<Ispit>();
        }

        public Ispit GetDetailsForIspit(Guid? id)
        {
            return this.entities.Include(i => i.IspitPoPredmet).SingleOrDefault(s => s.Id == id);
        }
    }
}
