using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExamManager.Domain.DomainModel
{
    public class CustomTermin
    {
        [Key]
        public int Id { get; set; }
        public int duration { get; set; }
        public Guid examId { get; set; }
        public virtual Ispit Ispit {get; set;}
        public string roomId { get; set; }

        public List<int> students { get; set; }
        //public virtual ICollection<Student> students { get; set; }
        public string teacherId { get; set; }

        public DateTime timeSlot{ get; set; }
        

    }
}
