using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Domain.DomainModel
{
    public class StudentPolagaPredmet
    {
        public int BrojNaIndeks { get; set; }
        public Student Student { get; set; }

        public string KodNaPredmet { get; set; }
        public Predmet Predmet { get; set; }
    }
}
