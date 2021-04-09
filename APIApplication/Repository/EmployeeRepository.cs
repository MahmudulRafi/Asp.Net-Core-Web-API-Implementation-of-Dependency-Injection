using APIApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace APIApplication.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;

        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }

        public Employee GetById(int id)
        {
            return _context.Employees.Where(emp => emp.EmployeeID == id).SingleOrDefault();
        }

        public List<Employee> GetEmployeesList()
        {
            return _context.Employees.ToList();
        }

        public void Insert(Employee employee)
        {
            _context.Employees.Add(employee);
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(employee);
        }

        public void Delete(int id)
        {
            Employee employee = GetById(id);
            _context.Employees.Remove(employee);
        }

        public void SaveChange()
        {
            _context.SaveChanges();
        }

        public void StateModified(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
        }

        public bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeID == id);
        }
    }
}
