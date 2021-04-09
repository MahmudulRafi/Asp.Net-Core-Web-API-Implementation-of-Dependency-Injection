using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIApplication.Model;
using APIApplication.Services;

namespace APIApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalariesController : ControllerBase
    {
        //private readonly DataContext _context;
        private readonly ISalaryService _salaryService;

        public SalariesController(ISalaryService salaryService)
        {
            // _context = context;
            _salaryService = salaryService;
        }

        // GET: api/Salaries
        [HttpGet]
        public ActionResult<IEnumerable<Salary>> GetSalaries()
        {
            return _salaryService.GetSalariesList();
        }

        // GET: api/Salaries/5
        [HttpGet("{id}")]
        public ActionResult<Salary> GetSalary(int id)
        {
            var salary = _salaryService.GetById(id);

            if (salary == null)
            {
                return NotFound();
            }

            return salary;
        }

        // PUT: api/Salaries/5
        [HttpPut("{id}")]
        public IActionResult PutSalary(int id, Salary salary)
        {
            if (id != salary.SalaryID)
            {
                return BadRequest();
            }

            _salaryService.StateModified(salary);

            try
            {
                _salaryService.Update(salary);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalaryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Salaries
        [HttpPost]
        public ActionResult<Salary> PostSalary(Salary salary)
        {
            _salaryService.Insert(salary);
            _salaryService.SaveChange();

            return CreatedAtAction("GetSalary", new { id = salary.SalaryID }, salary);
        }

        // DELETE: api/Salaries/5
        [HttpDelete("{id}")]
        public IActionResult DeleteSalary(int id)
        {
            var salary = _salaryService.GetById(id);
            if (salary == null)
            {
                return NotFound();
            }

            _salaryService.Delete(id);
            _salaryService.SaveChange();

            return NoContent();
        }

        private bool SalaryExists(int id)
        {
            return _salaryService.SalaryExists(id);
        }
    }
}
