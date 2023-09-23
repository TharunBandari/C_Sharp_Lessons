﻿using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MVCEFApp.Models
{
    public class RepositoryDoctor
    {
        public static List<Doctor> GetDoctors() 
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var List = ctx.Doctors.ToList();
            return List;
        }
        public static Doctor GetDoctorById(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var doctor = ctx.Doctors.First();
            return doctor;
        }
        public static void AddNewDoctor(Doctor doctor)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Doctors.Add(doctor);
            ctx.SaveChanges();
        }
        public static void ModifyDoctor(Doctor doctor)
        {
            HospitalDbContext ctx =new HospitalDbContext();
            ctx.Entry(doctor).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        public static void RemoveDoctor(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            Doctor doctor = ctx.Doctors.First();
            ctx.Doctors.Remove(doctor);
            ctx.SaveChanges();
        }


    }
}
