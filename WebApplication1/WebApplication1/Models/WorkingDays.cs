using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public partial class WorkingDays
    {
        public WorkingDays()
        {
            DaySchedule = new HashSet<DaySchedule>();
        }

        [Key]
        public int IdDay { get; set; }
        public DateTime? WorkDay { get; set; }

        public ICollection<DaySchedule> DaySchedule { get; set; }
    }
}
