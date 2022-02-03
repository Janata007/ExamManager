using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Domain.DTO
{
    public class TerminDTO
    {
        public Guid ispitId { get; set; }

        public List<DateTime> Termini { get; set; }
    }
}
