using System;
using System.ComponentModel.DataAnnotations;

namespace TestSoftDebut4.Models
{
    public class DepartmentModel
    {
        [Key]
        public string DepNo { get; set; }
        public string DepName { get; set; }
        public string Location { get; set; }
    }
}
