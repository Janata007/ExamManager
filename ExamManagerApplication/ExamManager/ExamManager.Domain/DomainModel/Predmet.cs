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
        public string PredmetId { get; set; }

        public Semestar Semestar { get; set; }

        public DateTime PolaganjeOd { get; set; }

        public DateTime PolaganjeDo { get; set; }

        public int VremetraenjeNaTerminVoMinuti { get; set; }

        public int BrojNaTermin { get; set; }

        public virtual ICollection<StudentPolagaPredmet> StudentiKoiPolagaatPredmet { get; set; }

        public string StudiskiCiklusId { get; set; }
        public virtual StudiskiCiklus StudiskiCiklus { get; set; }

        public virtual ICollection<PredmetOdStudiskaPrograma> PredmetOdStudiskiProgrami { get; set; }

        public virtual ICollection<Termin> PredmetSePolagaVoTermini { get; set; }
    }
}
