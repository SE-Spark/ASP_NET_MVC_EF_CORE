using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_MVC_CORE.Models
{
    public class EmpClass
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public Decimal Salary { get; set; }

    }
}
