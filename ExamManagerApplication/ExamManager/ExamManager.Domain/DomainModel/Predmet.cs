using ExamManager.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ExamManager.Domain.DomainModel
{
    public class Predmet 
    {
        [Key]
        public string KodNaPredmet { get; set; }

        public string ImeNaPredmet { get; set; }

        public Semestar Semestar { get; set; }

        public virtual ICollection<StudentPolagaPredmet> StudentiKoiPolagaatPredmet { get; set; }

        public string StudiskiCiklusId { get; set; }
        public virtual StudiskiCiklus StudiskiCiklus { get; set; }

        public virtual ICollection<PredmetOdStudiskaPrograma> PredmetOdStudiskiProgrami { get; set; }

        public virtual ICollection<Ispit> IspitiPoPredmet { get; set; }

    }
}
