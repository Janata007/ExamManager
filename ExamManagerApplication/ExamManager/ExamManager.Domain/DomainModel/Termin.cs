using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Domain.DomainModel
{
    public class Termin : BaseEntity 
    {
        public DateTime VremeNaZapocnuvanje { get; set; }
        
        public DateTime VremeNaZavrshuvanje { get; set; }

        public Guid ispitId { get; set; }
        public virtual Ispit TerminVoKojSePolagaIspit { get; set; }

        public virtual ICollection<Student> StudentiPolagaatVoTermin { get; set; }

        public string SproveduvacId { get; set; }
        public virtual Sproveduvac DezurenSproveduvacVoTermin { get; set; }

        public Guid ProstorijaId { get; set; }
        public virtual Prostorija TerminSeRealiziraVoProstija { get; set; }
    }
}
