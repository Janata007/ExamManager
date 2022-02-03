using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Domain.DomainModel
{
    public class Ispit : BaseEntity
    {
        public DateTime PolaganjeOd { get; set; }

        public DateTime PolaganjeDo { get; set; }

        public int VremetraenjeNaTerminVoMinuti { get; set; }

        public int BrojNaTermin { get; set; }

        public virtual ICollection<Termin> IspitSePolagaVoTermini { get; set; }

        public string KodNaPredmet { get; set; }
        public virtual Predmet IspitPoPredmet { get; set; }

    }
}
