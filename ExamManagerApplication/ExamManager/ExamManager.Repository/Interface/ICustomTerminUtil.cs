using ExamManager.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Repository.Interface
{
    public interface ICustomTerminUtil
    {
        public void AddTermin(CustomTermin ct);
        public List<CustomTermin> GetTermins();
        public CustomTermin GetTerminDetails(int id);
        public string getJson();
    }
}
