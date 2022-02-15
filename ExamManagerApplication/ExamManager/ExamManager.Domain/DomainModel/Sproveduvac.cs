using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ExamManager.Domain.DomainModel
{
    public class Sproveduvac  
    {
        [Key]
        public string SproveduvacId { get; set; }

        public string ImePrezime { get; set; }

    }
}
