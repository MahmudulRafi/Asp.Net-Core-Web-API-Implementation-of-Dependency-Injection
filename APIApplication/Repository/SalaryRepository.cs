using APIApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace APIApplication.Repository
{
    public class SalaryRepository : ISalaryRepository
    {
        private readonly DataContext _context;

        public SalaryRepository(DataContext context)
        {
            _context = context;
        }


        public List<Salary> GetSalariesList()
        {
            return _context.Salaries.ToList();
        }

        public Salary GetById(int id)
        {
            return _context.Salaries.Where(salary => salary.SalaryID == id).SingleOrDefault();

        }

        public void Insert(Salary salary)
        {
            _context.Salaries.Add(salary);
        }

        public void Update(Salary salary)
        {
            _context.Salaries.Update(salary);
        }

        public void Delete(int id)
        {
            Salary salary = GetById(id);
            _context.Salaries.Remove(salary);
        }

        public void StateModified(Salary salary)
        {
            _context.Entry(salary).State = EntityState.Modified;
        }

        public void SaveChange()
        {
            _context.SaveChanges();
        }


        public bool SalaryExists(int id)
        {
            return _context.Salaries.Any(salary => salary.SalaryID == id);
        }
    }
}
