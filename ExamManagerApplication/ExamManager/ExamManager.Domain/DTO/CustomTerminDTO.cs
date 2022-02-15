using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Domain.DTO
{
    public class CustomTerminDTO
    {
        public int duration { get; set; }
        public Guid examId { get; set; }
        public string roomId { get; set; }
        public List<int> students { get; set; }
        public string teacherId { get; set; }
        public DateTime timeSlot { get; set; }
    }
}
