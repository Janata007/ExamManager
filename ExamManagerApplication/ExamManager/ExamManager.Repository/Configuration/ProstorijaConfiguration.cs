using ExamManager.Domain.DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Repository.Configuration
{
    public class ProstorijaConfiguration : IEntityTypeConfiguration<Prostorija>
    {
        public void Configure(EntityTypeBuilder<Prostorija> builder)
        {
            builder.HasData(
                
                GenerateProstorii()

                );
        }

        private Prostorija[] GenerateProstorii()
        {
            List<Prostorija> prostorii = new List<Prostorija>();
            Random rnd = new Random();
            for(int i = 1; i < 11; i++)
            {
                prostorii.Add(new Prostorija
                {
                    Id = Guid.NewGuid(),
                    Ime = "Lab" + i,
                    Kapacitet = rnd.Next(25, 70)
                });
            }
            return prostorii.ToArray();
        }

    }
}
