using ExamManager.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Repository.Interface
{
    public interface IIspitRepository
    {
        Ispit GetDetailsForIspit(Guid? id);
    }
}
