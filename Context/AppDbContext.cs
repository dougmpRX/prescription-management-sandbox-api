using Microsoft.EntityFrameworkCore;
using prescription_management_sandbox_api.Entities;

namespace prescription_management_sandbox_api.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Professional> Professionals { get; set; }
        public DbSet<Institution> Institutions { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            // Tables configuration
            mb.Entity<Prescription>().HasKey(p => p.Id);
            mb.Entity<Prescription>().Property(p => p.Type)
                                 .HasConversion<string>()
                                 .HasMaxLength(11)
                                 .IsRequired();
            
            mb.Entity<Medicine>().HasKey(m => m.Id);
            mb.Entity<Medicine>().Property(m => m.Category)
                                 .HasConversion<string>()
                                 .HasMaxLength(17)
                                 .IsRequired();
            mb.Entity<Medicine>().Property(m => m.Name)
                                 .HasMaxLength(80)                 
                                 .IsRequired();
            mb.Entity<Medicine>().Property(m => m.Dosage)
                                 .HasPrecision(4,2);
            mb.Entity<Medicine>().Property(m => m.UsageDescription)
                                 .HasMaxLength(255)
                                 .IsRequired();

            mb.Entity<Patient>().HasKey(p => p.Id);
            mb.Entity<Patient>().Property(p => p.Name)
                                .HasMaxLength(100)
                                .IsRequired();
            mb.Entity<Patient>().Property(p => p.CPF)
                                .HasMaxLength(11)
                                .IsRequired();
            mb.Entity<Patient>().Property(p => p.Gender)
                                .HasConversion<string>()
                                .HasMaxLength(9)
                                .IsRequired();
            mb.Entity<Patient>().Property(p => p.Address)
                                .HasMaxLength(200)
                                .IsRequired();
            mb.Entity<Patient>().Property(p => p.PhoneNumber)
                                .HasMaxLength(15)
                                .IsRequired();
            mb.Entity<Patient>().Property(p => p.Email)
                                .HasMaxLength(100);

            mb.Entity<Professional>().HasKey(p => p.Id);
            mb.Entity<Professional>().Property(p => p.Name)
                                     .HasMaxLength (100)
                                     .IsRequired();
            mb.Entity<Professional>().Property(p => p.Category)
                                     .HasConversion<string>()
                                     .HasMaxLength(10)
                                     .IsRequired();
            mb.Entity<Professional>().Property(p => p.RegistryType)
                                     .HasConversion<string>()
                                     .HasMaxLength(5)
                                     .IsRequired();
            mb.Entity<Professional>().Property(p => p.RegistryState)
                                     .HasConversion<string>()
                                     .HasMaxLength(2)
                                     .IsRequired();
            mb.Entity<Professional>().Property(p => p.ResgistryNumber)
                                     .HasMaxLength(10)
                                     .IsRequired();

            mb.Entity<Institution>().HasKey(i => i.Id);
            mb.Entity<Institution>().Property(i => i.Name)
                                    .HasMaxLength(100)
                                    .IsRequired();
            mb.Entity<Institution>().Property(i => i.CNPJ)
                                    .HasMaxLength(14)
                                    .IsRequired();
            mb.Entity<Institution>().Property(i => i.Address)
                                    .HasMaxLength(200)
                                    .IsRequired();
            mb.Entity<Institution>().Property(i => i.PhoneNumber)
                                    .HasMaxLength(15)
                                    .IsRequired();

            //Relationships
            mb.Entity<Prescription>().HasOne<Patient>(p => p.Patient)
                                     .WithMany(p => p.Prescriptions);
            mb.Entity<Prescription>().HasOne<Professional>(p => p.Professional)
                                     .WithMany(p => p.Prescriptions);
            mb.Entity<Prescription>().HasOne<Institution>(p => p.Institution)
                                     .WithOne();
            mb.Entity<Prescription>().HasMany<Medicine>(p => p.Medicines)
                                     .WithOne();
        }
    }
}
