using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public partial class Departments
    {
        public Departments()
        {
            Doctors = new HashSet<Doctors>();
        }
        [Key]
        public int IdDepartment { get; set; }
        public string DepartmentName { get; set; }
        public string Observations { get; set; }

        public ICollection<Doctors> Doctors { get; set; }
    }
}
