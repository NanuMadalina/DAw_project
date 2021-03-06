﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext<Patients>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<MedicalInvestigations> MedicalInvestigations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-VNCSDUQ;Database=Daw;Integrated Security = SSPI;Trusted_Connection=True;");
            }
        }
        public DbSet<WebApplication1.Models.Doctors> Doctors { get; set; }
        public DbSet<WebApplication1.Models.DaySchedule> DaySchedule { get; set; }
    }
}
