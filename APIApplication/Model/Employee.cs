using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIApplication.Model
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }
        
        public string Email { get; set; }

        public string Designation { get; set; }

        public int SalaryId { get; set; }

        [ForeignKey("SalaryId")]

        public virtual Salary Salary { get; set; }
    }
}
