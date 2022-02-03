using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamManager.Domain.DomainModel
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
