using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExamManager.Domain.DTO
{
    public class DisplayTermin
    {
        public Guid TerminId { get; set; }

        public string Predmet { get; set; }

        public string DatumNaPolaganje { get; set; }

        public int BrojNaTermini { get; set; }
    }
}
