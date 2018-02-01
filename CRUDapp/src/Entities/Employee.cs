using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    [Table("Employee")]
    public class Employee
    {
        public Employee()
        {
        }

        [Key]
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string EmpPassword { get; set; }
        
    }
}
