using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public partial class Patients : IdentityUser
    {
      
        public string Fullname { get; set; }
        public string PersonalCode { get; set; }
       
        public string PhoneNumber { get; set; }
        public string PatientAddress { get; set; }
       
    }
}
