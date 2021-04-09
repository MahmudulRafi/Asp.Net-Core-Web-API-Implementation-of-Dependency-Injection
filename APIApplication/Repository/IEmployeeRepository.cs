using APIApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIApplication.Repository
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetEmployeesList();

        public Employee GetById(int id);

        public void Insert(Employee employee);

        public void Update(Employee employee);

        public void Delete(int id);

        public void SaveChange();

        public void StateModified(Employee employee);

        public bool EmployeeExists(int id);
    }
}
