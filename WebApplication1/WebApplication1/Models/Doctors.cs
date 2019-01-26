using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public partial class Doctors
    {
        public Doctors()
        {
            DaySchedule = new HashSet<DaySchedule>();
        }

        [Key]
        public int IdDoctor { get; set; }
        public string Fullname { get; set; }
        public string PersonalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string HomeAddress { get; set; }
        public int? IdDepartment { get; set; }

        public Departments IdDepartmentNavigation { get; set; }
        public ICollection<DaySchedule> DaySchedule { get; set; }
    }
}
