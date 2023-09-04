using System;
using System.ComponentModel.DataAnnotations;

namespace TestSoftDebut4.Models
{
    public class EmployeeBackupModel
    {
        [Key]
        public string EmpNum { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
    }
}
