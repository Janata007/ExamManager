using ExamManager.Domain.DomainModel;
using ExcelDataReader;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExamManager.Repository.Configuration
{
    public class IspitConfiguration : IEntityTypeConfiguration<Ispit>
    {
        public void Configure(EntityTypeBuilder<Ispit> builder)
        {
            builder.HasData(
                ReadExamScheduleFromFile()
            );
        }

        private Ispit [] ReadExamScheduleFromFile()
        {
            List<Ispit> ispiti = new List<Ispit>();

            string filePath = $"{Directory.GetCurrentDirectory()}\\Files\\ispiti.xlsx";

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = System.IO.File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    int day=0, month=0, year=0;

                    while (reader.Read())
                    {
                        string a = reader.GetValue(0).ToString();
                        if (a.Split(".").Length == 3)
                        {
                            string[] tmp = a.Split(".");
                            day = int.Parse(tmp[0]);
                            month = int.Parse(tmp[1]);
                            year = int.Parse(tmp[2]);
                        }
                        else
                        {

                            string[] clock = reader.GetValue(2).ToString().Split("-");

                            string[] fromTime = clock[0].Split(":");
                            string[] toTime = clock[1].Split(":");

                            DateTime from = new DateTime(year, month, day, int.Parse(fromTime[0]), int.Parse(fromTime[1]), 0);
                            DateTime to = new DateTime(year, month, day, int.Parse(toTime[0]), int.Parse(toTime[1]), 0);
                            int vremetraenje = int.Parse(reader.GetValue(3).ToString());
                            TimeSpan timeSpan = to - from;
                            int brojTermini = (int)Math.Round(timeSpan.TotalMinutes / vremetraenje);
                            ispiti.Add(new Ispit
                            {
                                Id = Guid.NewGuid(),
                                PolaganjeOd = from,
                                PolaganjeDo = to,
                                VremetraenjeNaTerminVoMinuti = vremetraenje,
                                BrojNaTermin = brojTermini,
                                KodNaPredmet = a
                            });
                        }
                    }
                }
            }

            return ispiti.ToArray();
        }
    }
}
