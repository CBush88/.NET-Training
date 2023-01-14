using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgrammingPractice_EF_CodeFirst.Models
{
    public class GradeCriteria
    {
        public int Id { get; set; }
        public string GradeName { get; set; }
        public decimal MinPercentage { get; set; }
        public decimal MaxPercentage { get; set; }
    }
}