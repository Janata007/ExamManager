using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Domain.DomainModel
{
    public class PredmetOdStudiskaPrograma
    {
        public string KodNaPredmet { get; set; }
        public Predmet Predmet { get; set; }

        public string ImeNaStudiskaPrograma { get; set; }
        public StudiskaPrograma StudiskaPrograma { get; set; }
    }
}
