﻿using MVCEFApp.Models;
using System;
using Microsoft.EntityFrameworkCore;



namespace MVCEFApp.Models
{
    public class HospitalDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            String conString = @"server=200411LTP2868\SQLEXPRESS;database=HospitalDB;integrated security=true;Encrypt=false;";
            options.UseSqlServer(conString);
        }



    }
}
