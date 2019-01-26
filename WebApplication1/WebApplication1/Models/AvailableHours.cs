using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public partial class AvailableHours
    {
        public AvailableHours()
        {
            DaySchedule = new HashSet<DaySchedule>();
        }
        [Key]
        public int IdHour { get; set; }
        public string HourInterval { get; set; }
        public bool? HourAvailability { get; set; }

        public ICollection<DaySchedule> DaySchedule { get; set; }
    }
}
