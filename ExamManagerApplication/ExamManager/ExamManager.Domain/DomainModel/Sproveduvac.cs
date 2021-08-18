using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ExamManager.Domain.DomainModel
{
    public class Sproveduvac  : BaseEntity
    {
     
        public string ImePrezime { get; set; }

        public virtual Termin SproveduvacDezuraVoTermin { get; set; }
    }
}
