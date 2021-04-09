using APIApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIApplication.Services
{
    public interface ISalaryService
    {
        public List<Salary> GetSalariesList();

        public Salary GetById(int id);

        public void Insert(Salary salary);

        public void Update(Salary salary);

        public void Delete(int id);

        public void SaveChange();

        public void StateModified(Salary salary);

        public bool SalaryExists(int id);
    }
}
