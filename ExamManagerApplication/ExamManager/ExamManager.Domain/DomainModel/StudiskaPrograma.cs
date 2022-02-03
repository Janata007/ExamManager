using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ExamManager.Domain.DomainModel
{
    public class StudiskaPrograma
    {
        [Key]
        public string ImeNaStudiskaPrograma { get; set; }

        public virtual ICollection<PredmetOdStudiskaPrograma> PredmetiOdStudiskaPrograma { get; set; }
    }
}
