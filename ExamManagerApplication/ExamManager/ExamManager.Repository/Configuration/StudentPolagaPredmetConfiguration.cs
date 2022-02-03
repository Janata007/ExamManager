using ExamManager.Domain.DomainModel;
using ExcelDataReader;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExamManager.Repository.Configuration
{
    public class StudentPolagaPredmetConfiguration : IEntityTypeConfiguration<StudentPolagaPredmet>
    {
        public void Configure(EntityTypeBuilder<StudentPolagaPredmet> builder)
        {
            builder.HasData(
                ReadStudentsCoursesFromFile()
                );
        }

        private StudentPolagaPredmet[] ReadStudentsCoursesFromFile()
        {
            List<StudentPolagaPredmet> lista = new List<StudentPolagaPredmet>();

            string filePath = $"{Directory.GetCurrentDirectory()}\\Files\\studentPolagaPredmet.xlsx";

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = System.IO.File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    while (reader.Read())
                    {
                        int indeks = int.Parse(reader.GetValue(0).ToString());
                        string [] predmeti= reader.GetValue(1).ToString().Split(",").Select(p => p.Trim())
                                                                                    .Where(p => !string.IsNullOrWhiteSpace(p))
                                                                                    .ToArray();
                        foreach(string p in predmeti)
                        {
                            lista.Add(new StudentPolagaPredmet
                            {
                                BrojNaIndeks = indeks,
                                KodNaPredmet = p
                            });
                        }
                    }
                }
            }

            return lista.ToArray();
        }

        private void StudentPolagaPredmetAlgotithm()
        {
            string[] prva ={"F18L1W031", "F18L1W007", "F18L1S013", "F18L1W033",
                        "F18L1W020", "F18L1W041", "F18L1W005", "F18L1W011",
                        "F18L1W049", "F18L1S052", "F18L1S045", "F18L1S032",
                        "F18L1S023", "F18L1S034", "F18L1S015", "F18L1S016",
                        "F18L1W070", "F18L1S003", "F18L1S146", "F18L1S116",
                        "F18L1S026", "F18L1S120"};

            string[] vtora ={ "F18L2W046", "F18L2W006", "F18L2W001", "F18L2W104",
                        "F18L2W167", "F18L2W140", "F18L2S100", "F18L2W067",
                        "F18L2W109", "F18L2S002", "F18L2S099", "F18L2S030",
                        "F18L2S017", "F18L2S110", "F18L2S082", "F18L2S029",
                        "F18L3S010", "F18L2S124", "F18L2S084", "F18L2S097",
                        "F18L2S119" };

            string[] treta ={"F18L3W024", "F18L3W134", "F18L3W064", "F18L3W008",
                    "F18L3W004", "F18L3W044", "F18L3W027", "F18L3W136",
                    "F18L3W050", "F18L3W009", "F18L3W060", "F18L3S040",
                    "F18L3W035", "F18L3S036", "F18L3S166", "F18L3S063",
                    "F18L3S019", "F18L3S138", "F18L3S130", "F18L3S094",
                    "F18L3S059", "F18L3S141", "F18L3S091", "F18L3W085",
                    "F18L3S157", "F18L3S135", "F18L3S118", "F18L3S025",
                    "F18L3W043", "F18L3S122"};

            string[] cetvrta ={ "F18L3W103", "F18L3W060", "F18L3W075", "F18L3W126",
                        "F18L3W105", "F18L3W079", "F18L3W037", "F18L3W129",
                        "F18L3W137", "F18L3S155", "F18L3S086", "F18L3S107",
                        "F18L3S077", "F18L3S022", "F18L3S028"};


            //Prva godina
            Random rnd = new Random();
            for (int i = 0; i < 500; i++)
            {

                int br = rnd.Next(1, 5);

                var randList = prva.OrderBy(item => rnd.Next());
                var tmp = randList.Take(br);

                Console.WriteLine(string.Join(",", tmp));
            }

            rnd = new Random();
            //Vtora godina
            for (int i = 0; i < 250; i++)
            {
                if (rnd.Next(5) < 0.5)
                {
                    //Console.WriteLine("less");
                    int br = rnd.Next(5, 12);
                    var predmeti = prva.Concat(vtora).ToArray();
                    var randList = predmeti.OrderBy(item => rnd.Next());
                    var tmp = randList.Take(br);
                    Console.WriteLine(string.Join(",", tmp));
                }
                else
                {
                    int br = rnd.Next(1, 5);
                    var randList = vtora.OrderBy(item => rnd.Next());
                    var tmp = randList.Take(br);
                    Console.WriteLine(string.Join(",", tmp));
                }
            }

            rnd = new Random();
            //Treta godina
            for (int i = 0; i < 125; i++)
            {
                if (rnd.Next(10) < 0.5)
                {
                    //Console.WriteLine("less");
                    int br = rnd.Next(5, 12);
                    var predmeti = prva.Concat(vtora).Concat(treta).ToArray();
                    var randList = predmeti.OrderBy(item => rnd.Next());
                    var tmp = randList.Take(br);
                    Console.WriteLine(string.Join(",", tmp));
                }
                else
                {
                    int br = rnd.Next(1, 5);
                    var randList = treta.OrderBy(item => rnd.Next());
                    var tmp = randList.Take(br);
                    Console.WriteLine(string.Join(",", tmp));
                }
            }

            rnd = new Random();
            //Cetvrta godina
            for (int i = 0; i < 50; i++)
            {
                if (rnd.Next(15) < 0.5)
                {
                    //Console.WriteLine("less");
                    int br = rnd.Next(5, 12);
                    var predmeti = prva.Concat(vtora).Concat(treta).Concat(cetvrta).ToArray();
                    var randList = predmeti.OrderBy(item => rnd.Next());
                    var tmp = randList.Take(br);
                    Console.WriteLine(string.Join(",", tmp));

                }
                else
                {
                    int br = rnd.Next(1, 5);
                    var randList = cetvrta.OrderBy(item => rnd.Next());
                    var tmp = randList.Take(br);
                    Console.WriteLine(string.Join(",", tmp));
                }
            }
        }
    }


}
