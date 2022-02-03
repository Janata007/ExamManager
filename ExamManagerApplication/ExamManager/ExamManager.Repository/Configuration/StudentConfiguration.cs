using ExamManager.Domain.DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamManager.Repository.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                 GenerateStudents()
            ); 
        }

        private Student[] GenerateStudents()
        {
            List<Student> students = new List<Student>();

            //prva godina 
            for(int i = 0; i < 500; i++)
            {
                students.Add(new Student
                {
                    BrojNaIndeks = 1000 + i,
                    ImePrezime = "StudentPrva" + i,
                });
            }

            //vtora godina
            for (int i = 0; i < 250; i++)
            {
                students.Add(new Student
                {
                    BrojNaIndeks = 2000 + i,
                    ImePrezime = "StudentVtora" + i
                });
            }
            //treta godina
            for (int i = 0; i < 125; i++)
            {
                students.Add(new Student
                {
                    BrojNaIndeks = 3000 + i,
                    ImePrezime = "StudentTreta" + i
                });
            }
            //cetvrta godina
            for (int i = 0; i < 50; i++)
            {
                students.Add(new Student
                {
                    BrojNaIndeks = 4000 + i,
                    ImePrezime = "StudentCetvrta" + i
                });
            }
            return students.ToArray();
        }
    }
}
