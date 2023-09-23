using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;



namespace MVCEFApp.Models
{
    public class RepositoryPatient
    {
        public static List<Patient> GetPatients()
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var List = ctx.Patients.ToList();
            return List;
        }
        public static Patient GetPatientsById(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var patient = ctx.Patients.First();
            return patient;
        }
        public static void AddNewPatient(Patient patient)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Patients.Add(patient);
            ctx.SaveChanges();
        }
        public static void ModifyPatient(Patient patient)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Entry(patient).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        public static void RemovePatient(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            Patient patient = ctx.Patients.First();
            ctx.Patients.Remove(patient);
            ctx.SaveChanges();
        }
    }
}
