using System;
using System.Collections.Generic;
using System.Text;
using ExamManager.Domain.DomainModel;

namespace ExamManager.Repository.Interface
{
    public interface IStudiskaProgramaRepository
    {
        IEnumerable<StudiskaPrograma> GetAll();
        StudiskaPrograma Get(string ImeNaStudiskaPrograma);
        void Insert(StudiskaPrograma entity);
        void Update(StudiskaPrograma entity);
        void Delete(StudiskaPrograma entity);
    }
}
