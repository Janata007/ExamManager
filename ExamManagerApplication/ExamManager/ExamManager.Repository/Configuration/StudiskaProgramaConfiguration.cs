using ExamManager.Domain.DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Repository.Configuration
{
    public class StudiskaProgramaConfiguration : IEntityTypeConfiguration<StudiskaPrograma>
    {
        public void Configure(EntityTypeBuilder<StudiskaPrograma> builder)
        {
            builder.HasData(
                new StudiskaPrograma { ImeNaStudiskaPrograma = "Интернет мрежи и безбедност" },
                new StudiskaPrograma { ImeNaStudiskaPrograma = "Компјутерска едукација" },
                new StudiskaPrograma { ImeNaStudiskaPrograma = "Компјутерски науки" },
                new StudiskaPrograma { ImeNaStudiskaPrograma = "Компјутерско инженерство" },
                new StudiskaPrograma { ImeNaStudiskaPrograma = "Примена на информациски технологии" },
                new StudiskaPrograma { ImeNaStudiskaPrograma = "Софтверско инженерство и информациски системи" },
                new StudiskaPrograma { ImeNaStudiskaPrograma = "Software engineering and information systems" },
                new StudiskaPrograma { ImeNaStudiskaPrograma = "Професионални студии по информатички технологии" },
                new StudiskaPrograma { ImeNaStudiskaPrograma = "Професионални студии по информатика" },
                new StudiskaPrograma { ImeNaStudiskaPrograma = "Академски студии по информатика" },
                new StudiskaPrograma { ImeNaStudiskaPrograma = "Информатика и компјутерско инженерство" },
                new StudiskaPrograma { ImeNaStudiskaPrograma = "Компјутерска едукација-стара" },
                new StudiskaPrograma { ImeNaStudiskaPrograma = "Мрежни технологии" },
                new StudiskaPrograma { ImeNaStudiskaPrograma = "Примена на е-технологии" },
                new StudiskaPrograma { ImeNaStudiskaPrograma = "Компјутерски науки и инженерство" }
                );
        }
    }
}
