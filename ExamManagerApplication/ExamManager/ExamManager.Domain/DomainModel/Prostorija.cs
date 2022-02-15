using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Domain.DomainModel
{
    public class Prostorija : BaseEntity 
    {
        public string Ime { get; set; }

        public int Kapacitet { get; set; }

    }
}
