using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public partial class DaySchedule
    {
        [Key]
        public int IdSchedule { get; set; }
        public int IdDoctor { get; set; }
        public int IdDay { get; set; }
        public int IdHour { get; set; }

        public WorkingDays IdDayNavigation { get; set; }
        public Doctors IdDoctorNavigation { get; set; }
        public AvailableHours IdHourNavigation { get; set; }
    }
}
