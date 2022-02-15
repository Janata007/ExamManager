using ExamManager.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Service.Interface
{
    public interface ITerminService
    {
        List<Termin> GetAllTermini();
        List<Termin> GetTerminiPaginated(int page);

        Termin GetDetailsForTermin(Guid id);

        void CreateNewTermin(Termin t);

    }
}
