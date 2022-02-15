using ExamManager.Domain.DomainModel;
using ExamManager.Domain.Identity;
using ExamManager.Repository.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ExamManager.Repository
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ispit> Ispiti { get; set; }
        public virtual DbSet<Predmet> Predmeti { get; set; }
        public virtual DbSet<PredmetOdStudiskaPrograma> PredmetiOdStudiskaPrograma { get; set; }
        public virtual DbSet<Prostorija> Prostorii { get; set; }
        public virtual DbSet<Sproveduvac> Sproveduvaci { get; set; }
        public virtual DbSet<Student> Studenti { get; set; }
        public virtual DbSet<StudentPolagaPredmet> StudentiPolagaatPredmeti { get; set; }
        public virtual DbSet<StudiskaPrograma> StudiskiProgrami { get; set; }
        public virtual DbSet<StudiskiCiklus> StudickiCiklusi { get; set; }
        public virtual DbSet<Termin> Termini { get; set; }
 
        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);

            builder.Entity<Ispit>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();
          
            builder.Entity<Ispit>()
                .HasOne(z => z.IspitPoPredmet)
                .WithMany(z => z.IspitiPoPredmet)
                .HasForeignKey(z => z.KodNaPredmet);

            builder.Entity<Predmet>()
                .Property(z => z.KodNaPredmet)
                .ValueGeneratedOnAdd();
                                   

            builder.Entity<Predmet>()
                .HasOne(z => z.StudiskiCiklus)
                .WithMany(z => z.PredmetiOdStudiskiCiklus)
                .HasForeignKey(z => z.StudiskiCiklusId);

            builder.Entity<Prostorija>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Sproveduvac>()
                .Property(z=>z.SproveduvacId)
                .ValueGeneratedOnAdd();

            builder.Entity<Student>()
                     .Property(z => z.BrojNaIndeks)
                    .ValueGeneratedOnAdd();
            /*
            builder.Entity<Student>()
                .HasOne(z => z.StudentPolagaVoTermin)
                .WithMany(z => z.StudentiPolagaatVoTermin)
                .HasForeignKey(z => z.TerminId)
                .IsRequired(false);
            */
            builder.Entity<StudiskaPrograma>()
                .Property(z=>z.ImeNaStudiskaPrograma)
                .ValueGeneratedOnAdd();

            builder.Entity<StudiskiCiklus>()
                .Property(z=>z.CiklusNaStudii)
                .ValueGeneratedOnAdd();

            builder.Entity<Termin>()
                .Property(z=>z.Id)
                .ValueGeneratedOnAdd();

            /*
            builder.Entity<Termin>()
                .HasOne(z => z.TerminVoKojSePolagaIspit)
                .WithMany(z => z.IspitSePolagaVoTermini)
                .HasForeignKey(z => z.ispitId);

            builder.Entity<Termin>()
                .HasOne(z => z.DezurenSproveduvacVoTermin)
                .WithOne(z => z.SproveduvacDezuraVoTermin)
               .HasForeignKey<Termin>(z => z.SproveduvacId);

            builder.Entity<Termin>()
                .HasOne(z => z.TerminSeRealiziraVoProstija)
                .WithMany(z => z.ProstijaVoKojaSeRealiziraTermin)
                .HasForeignKey(z => z.ProstorijaId);*/

            builder.Entity<PredmetOdStudiskaPrograma>()
                .HasKey(z => new { z.KodNaPredmet, z.ImeNaStudiskaPrograma });

            builder.Entity<PredmetOdStudiskaPrograma>()
                .HasOne(z => z.StudiskaPrograma)
                .WithMany(z => z.PredmetiOdStudiskaPrograma)
                .HasForeignKey(z => z.ImeNaStudiskaPrograma);

            builder.Entity<PredmetOdStudiskaPrograma>()
                .HasOne(z => z.Predmet)
                .WithMany(z => z.PredmetOdStudiskiProgrami)
                .HasForeignKey(z => z.KodNaPredmet);

            builder.Entity<StudentPolagaPredmet>()
                .HasKey(z => new { z.BrojNaIndeks, z.KodNaPredmet });

            /*
            builder.Entity<StudentPolagaPredmet>()
                .HasOne(z => z.Student)
                .WithMany(z => z.StudentPolagaPredmeti)
                .HasForeignKey(z => z.BrojNaIndeks);

            builder.Entity<StudentPolagaPredmet>()
                .HasOne(z => z.Predmet)
                .WithMany(z => z.StudentiKoiPolagaatPredmet)
                .HasForeignKey(z => z.KodNaPredmet);*/
            
            builder.ApplyConfiguration(new StudiskiCiklusConfiguration());
            builder.ApplyConfiguration(new StudiskaProgramaConfiguration());
            builder.ApplyConfiguration(new PredmetConfiguration());
            builder.ApplyConfiguration(new PredmetOdStudiskaProgramaConfiguration());
            builder.ApplyConfiguration(new ProstorijaConfiguration());
            builder.ApplyConfiguration(new SproveduvacConfiguration());
            builder.ApplyConfiguration(new StudentConfiguration());
            builder.ApplyConfiguration(new StudentPolagaPredmetConfiguration());
            builder.ApplyConfiguration(new IspitConfiguration());
        }


    }
}
