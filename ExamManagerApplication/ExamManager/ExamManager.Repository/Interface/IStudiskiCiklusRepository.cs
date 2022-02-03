using ExamManager.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Repository.Interface
{
    public interface IStudiskiCiklusRepository
    {
        IEnumerable<StudiskiCiklus> GetAll();
        StudiskiCiklus Get(string id);
        void Insert(StudiskiCiklus entity);
        void Update(StudiskiCiklus entity);
        void Delete(StudiskiCiklus entity);
    }
}
