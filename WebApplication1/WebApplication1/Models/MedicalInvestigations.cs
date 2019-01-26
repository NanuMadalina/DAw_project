using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public partial class MedicalInvestigations
    {
        [Key]
        public int IdInvestigation { get; set; }
        public string InvName { get; set; }
        public string InvDescription { get; set; }
        public double InvPret { get; set; }
    }
}
