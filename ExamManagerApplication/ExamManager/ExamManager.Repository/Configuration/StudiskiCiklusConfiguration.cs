using ExamManager.Domain.DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Repository.Configuration
{
    public class StudiskiCiklusConfiguration : IEntityTypeConfiguration<StudiskiCiklus>
    {
        public void Configure(EntityTypeBuilder<StudiskiCiklus> builder)
        {
            builder.HasData(
                new StudiskiCiklus { CiklusNaStudii = "Додипломски" },
                new StudiskiCiklus { CiklusNaStudii = "Магистерски" },
                new StudiskiCiklus { CiklusNaStudii = "Докторски" }

                );
        }
    }
}
