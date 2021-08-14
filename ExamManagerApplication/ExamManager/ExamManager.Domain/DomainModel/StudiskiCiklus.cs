using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ExamManager.Domain.DomainModel
{
    public class StudiskiCiklus
    {
        [Key]
        public string CiklusNaStudii { get; set; }

        public virtual ICollection<Predmet> PredmetiOdStudiskiCiklus { get; set; }
    }
}
