using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Domain.DTO
{
    public class IspitDTO
    {
        public Guid ispitId { get; set; }
        public string KodNaPredmet { get; set; }
        //public DateTime PolaganjeOd { get; set; }
        //public DateTime PolaganjeDo { get; set; }
        //public int BrojNaTermini { get; set; }
        public int Vremetraenje { get; set; }
    }
}
