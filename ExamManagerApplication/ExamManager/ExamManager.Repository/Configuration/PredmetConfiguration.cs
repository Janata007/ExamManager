using ExamManager.Domain.DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using ExamManager.Domain.Enumerations;
using System.IO;
using ClosedXML.Excel;
using ExcelDataReader;

namespace ExamManager.Repository.Configuration
{
    public class PredmetConfiguration : IEntityTypeConfiguration<Predmet>
    {
        public void Configure(EntityTypeBuilder<Predmet> builder)
        {

            builder.HasData(
               ReadCoursesFromFile()
                );
        }

        private Predmet[] ReadCoursesFromFile()
        {
            List<Predmet> predmeti = new List<Predmet>() ;

            string filePath = $"{Directory.GetCurrentDirectory()}\\Files\\predmeti.xlsx";

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = System.IO.File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    while (reader.Read())
                    {
                        predmeti.Add(new Predmet
                        {
                            KodNaPredmet=reader.GetValue(0).ToString(),
                            ImeNaPredmet=reader.GetValue(1).ToString(),
                            Semestar= reader.GetValue(2).ToString().Equals("L") ? Semestar.Leten : Semestar.Zimski,
                            StudiskiCiklusId= "Додипломски"
                        });
                    }
                }
            }

            return predmeti.ToArray();

        }
    }
}
