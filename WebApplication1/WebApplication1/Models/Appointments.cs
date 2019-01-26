using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public partial class Appointments
    {
        [Key]
        public int IdAppointment { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }
    }
}
