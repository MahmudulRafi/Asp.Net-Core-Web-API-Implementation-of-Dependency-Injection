using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIApplication.Model
{
    public class Salary
    {
        [Key]
        public int SalaryID { get; set; }

        public string ScaleName { get; set; }

        public double SalaryAmount { get; set; }

        public double HouseRentAllownce { get; set; }

        public double MedicalAllownce { get; set; }

        public double YearlyIncrement { get; set; }
    }
}
