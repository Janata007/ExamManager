using ExamManager.Domain.DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ExcelDataReader;
using System.Linq;

namespace ExamManager.Repository.Configuration
{
    public class PredmetOdStudiskaProgramaConfiguration : IEntityTypeConfiguration<PredmetOdStudiskaPrograma>
    {
        public void Configure(EntityTypeBuilder<PredmetOdStudiskaPrograma> builder)
        {
            builder.HasData(
                ReadCourseAndProgramFromFile()
                );
        }

        private PredmetOdStudiskaPrograma[] ReadCourseAndProgramFromFile()
        {
            List<PredmetOdStudiskaPrograma> predmetiOdStudiskiProgrami = new List<PredmetOdStudiskaPrograma>();

            string filePath = $"{Directory.GetCurrentDirectory()}\\Files\\predmetiOdStudiskaPrograma.xlsx";

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = System.IO.File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    while (reader.Read())
                    {
                        string kod = reader.GetValue(0).ToString();
                        string[] programi = reader.GetValue(1).ToString().Split(",").Select(p => p.Trim())
                                                                                    .Where(p => !string.IsNullOrWhiteSpace(p))
                                                                                    .ToArray();
                        foreach (string p in programi)
                        {
                            predmetiOdStudiskiProgrami.Add(new PredmetOdStudiskaPrograma
                            {
                                KodNaPredmet = kod,
                                ImeNaStudiskaPrograma=p
                            });
                            if(p.Equals("Софтверско инженерство и информациски системи"))
                            {
                                predmetiOdStudiskiProgrami.Add(new PredmetOdStudiskaPrograma
                                {
                                    KodNaPredmet = kod,
                                    ImeNaStudiskaPrograma = "Software engineering and information systems"
                                });
                            }
                        }
                        
                    }
                }
            }

            return predmetiOdStudiskiProgrami.ToArray();
        }
    }
}
