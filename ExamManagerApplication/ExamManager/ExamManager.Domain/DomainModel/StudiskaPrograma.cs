using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Domain.DomainModel
{
    public class StudiskaPrograma : BaseEntity
    {
        public string ImeNaStudiskaPrograma { get; set; }

        public virtual ICollection<PredmetOdStudiskaPrograma> PredmetiOdStudiskaPrograma { get; set; }
    }
}
