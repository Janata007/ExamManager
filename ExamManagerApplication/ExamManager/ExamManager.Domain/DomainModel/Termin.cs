using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Domain.DomainModel
{
    public class Termin : BaseEntity 
    {
        public DateTime VremeNaZapocnuvanje { get; set; }
        
        public DateTime VremeNaZavrshuvanje { get; set; }

        public string Predmet { get; set; }

        public string StudentiPolagaatVoTermin { get; set; }

        public string Dezuren { get; set; }

        public string Prostorija { get; set; }
    }
}
