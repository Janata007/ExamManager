using ExamManager.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ExamManager.Service.Interface
{
    public interface ICustomTerminUtilService
    {
        public void AddTermin(CustomTermin ct);

        public List<CustomTermin> GetAllTermini();
        public CustomTermin GetDetailsForTermin(int id);

        public HttpWebResponse invokePost();

    }
}
