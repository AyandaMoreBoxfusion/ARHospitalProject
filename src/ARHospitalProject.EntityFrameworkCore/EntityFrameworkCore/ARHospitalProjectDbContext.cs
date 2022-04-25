using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ARHospitalProject.Authorization.Roles;
using ARHospitalProject.Authorization.Users;
using ARHospitalProject.MultiTenancy;
using ARHospitalProject.Domain;

namespace ARHospitalProject.EntityFrameworkCore
{
    public class ARHospitalProjectDbContext : AbpZeroDbContext<Tenant, Role, User, ARHospitalProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorAvaliability> DoctorAvaliabilities { get; set; }
        public DbSet<DoctorCheckIn> DoctorCheckIns { get; set; }
        public DbSet<DoctorCheckOut> DoctorCheckOuts { get; set; }
        public DbSet<DoctorOfficeReceptionist> DoctorOfficeReceptionists { get; set; }
        public DbSet<FrontDeskReceptiontionist> FrontDeskReceptiontionists { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PrescribedMedication> PrescribedMedications { get; set; }
        public DbSet<Specialization> Specializations { get; set; }



        public ARHospitalProjectDbContext(DbContextOptions<ARHospitalProjectDbContext> options)
            : base(options)
        {
        }
    }
}
