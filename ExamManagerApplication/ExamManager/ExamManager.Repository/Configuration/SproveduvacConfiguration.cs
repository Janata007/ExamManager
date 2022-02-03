using ExamManager.Domain.DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Repository.Configuration
{
    public class SproveduvacConfiguration : IEntityTypeConfiguration<Sproveduvac>
    {
        public void Configure(EntityTypeBuilder<Sproveduvac> builder)
        {
            builder.HasData(
                GenerateStaff()
                );
        }

        private Sproveduvac[] GenerateStaff()
        {
            List<Sproveduvac> sproveduvaci = new List<Sproveduvac>();

            for(int i = 0; i < 40; i++)
            {
                sproveduvaci.Add(new Sproveduvac
                {
                    SproveduvacId = "SP"+(100+i),
                    ImePrezime="Sproveduvac"+i
                });
            }

            return sproveduvaci.ToArray();
        }
    }
}
