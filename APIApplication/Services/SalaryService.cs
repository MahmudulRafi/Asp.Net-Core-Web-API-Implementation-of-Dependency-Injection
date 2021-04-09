using APIApplication.Model;
using APIApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIApplication.Services
{
    public class SalaryService : ISalaryService
    {
        private readonly ISalaryRepository _repository;

        public SalaryService(ISalaryRepository repository)
        {
            _repository = repository;
        }

        public Salary GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Salary> GetSalariesList()
        {
            return _repository.GetSalariesList();
        }

        public void Insert(Salary salary)
        {
            _repository.Insert(salary);
        }

        public void Update(Salary salary)
        {
            _repository.Update(salary);
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
        public void SaveChange()
        {
            _repository.SaveChange();
        }

        public void StateModified(Salary salary)
        {
            _repository.StateModified(salary);
        }

        public bool SalaryExists(int id)
        {
            return _repository.SalaryExists(id);
        }

    }
}
