using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Domain.DomainModel
{
    public class PredmetOdStudiskaPrograma
    {
        public string PredmetId { get; set; }
        public Predmet Predmet { get; set; }

        public Guid StudiskaProgramaId { get; set; }
        public StudiskaPrograma StudiskaPrograma { get; set; }
    }
}
