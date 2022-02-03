using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ExamManager.Domain.DomainModel
{
    public class Student
    {
        [Key]
        public int BrojNaIndeks { get; set; }

        public string ImePrezime { get; set; }

        public virtual ICollection<StudentPolagaPredmet> StudentPolagaPredmeti { get; set; }

        public Guid? TerminId { get; set; }
        public int? CustomTerminId { get; set; }
        public virtual Termin StudentPolagaVoTermin { get; set; }

    }
}
