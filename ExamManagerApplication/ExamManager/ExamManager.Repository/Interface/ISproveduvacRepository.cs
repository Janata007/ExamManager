using ExamManager.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Repository.Interface
{
    public interface ISproveduvacRepository
    {
        IEnumerable<Sproveduvac> GetAll();
        IEnumerable<Sproveduvac> GetSproveduvaciPaginated(int page);
        IEnumerable<Sproveduvac> GetDetailsForSproveduvacWithId(List<String> ids);
        Sproveduvac Get(string id);
        void Insert(Sproveduvac entity);
        void Update(Sproveduvac entity);
        void Delete(Sproveduvac entity);
    }
}
