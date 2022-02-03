using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Domain.DomainModel
{
    public class Vkupen
    {
        public Vkupen(CustomTermin customTermin, List<Student> students) {
            this.customTermin = customTermin;
            this.students = students;
        }

        public CustomTermin customTermin;
        public List<Student> students;
    }
}
